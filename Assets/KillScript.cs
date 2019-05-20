using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillScript : MonoBehaviour
{
    public Text gameOverText;

    public AudioSource audioSource;

    public AudioClip deadSoundClip;


    void OnTriggerEnter2D(Collider2D colider)
    {
        Debug.Log("Collision");

        if (colider.CompareTag("Player"))
        {
            Destroy(colider.gameObject);
            audioSource.clip = deadSoundClip;
            audioSource.Play();
            gameOverText.enabled = true;
        }
    }
}
