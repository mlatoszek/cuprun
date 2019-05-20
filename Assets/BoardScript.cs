using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject player;
    public Sprite boardSprite;
    public PlayerMovement playerMovement;
    public int movementSpeed;

    void OnTriggerEnter2D(Collider2D colider)
    {
        Debug.Log("Collision with board");

        if (colider.CompareTag("Player"))
        {
            Destroy(transform.gameObject);
            playerMovement.runSpeed = movementSpeed;

            
            var boardObject = new GameObject("playerBoard");
            var spriteRenderer = boardObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
            spriteRenderer.sprite = boardSprite;
            boardObject.transform.localScale = new Vector3(1, 1, 1);
            boardObject.transform.position = new Vector3(1.67f, -4.05f, -0.1f);
            boardObject.transform.SetParent(player.transform,false);
            
        }
    }
}
