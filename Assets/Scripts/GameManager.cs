using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Player;
    public GameObject Background;
    public GameObject GameoverPanel;
    public GameObject[] Borders;

    private Renderer _backgroundRenderer;

    public float PlayerSpeed;
    public float CameraSpeed;
    public float BackgroundSpeed;

    public void Start()
    {
        PlayerSpeed = CameraSpeed;
        _backgroundRenderer = Background.GetComponent<Renderer>();
    }

    public void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null) 
        {
            Player.transform.position += new Vector3(PlayerSpeed * Time.deltaTime, 0, 0);
        }

        MainCamera.transform.position += new Vector3(CameraSpeed * Time.deltaTime, 0, 0);

        _backgroundRenderer.material.mainTextureOffset += new Vector2(BackgroundSpeed * Time.deltaTime, 0f);

        if(GameObject.FindGameObjectWithTag("Player") == null) 
        {
            GameoverPanel.SetActive(true);
        }
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
