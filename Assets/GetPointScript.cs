using UnityEngine;

public class GetPointScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip getPointSoundClip;
    public int pointValue = 1;
    public PlayerProperties playerProperties;

    void OnTriggerEnter2D(Collider2D colider)
    {
        Debug.Log("Collision with point");

        if (colider.CompareTag("Player"))
        {
            Destroy(transform.gameObject);
            audioSource.clip = getPointSoundClip;
            audioSource.Play();

            playerProperties.points += pointValue;
        }
    }
}
