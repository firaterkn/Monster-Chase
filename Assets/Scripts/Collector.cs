using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
   

    private string ENEMY_TAG = "Enemy";
    private string PLAYER_TAG = "Player";


    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag(ENEMY_TAG) || collision.CompareTag(PLAYER_TAG)) {
            Destroy(collision.gameObject); // Destroy(gameObject) destroys the collector 
                                          // instead we want to destroy the object which hit the collector
                                          //  with the ENEMY_TAG)


        }

    }




}
