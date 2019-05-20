using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public GameObject player;
    private float startX;

    // Start is called before the first frame update
    void Start()
    {
        startX = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && player.active)
        {
            this.gameObject.transform.position = new Vector3(player.transform.position.x - startX, 0, -10);
        }
    }
}
