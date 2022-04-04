using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badguy : MonoBehaviour
{
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border") 
        {
            Destroy(this.gameObject);
        }

        if(collision.tag == "Player") 
        {
            Destroy(_player.gameObject);
        }
    }
}
