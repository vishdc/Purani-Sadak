using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public AudioSource crashThud;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashThud.Play();
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}