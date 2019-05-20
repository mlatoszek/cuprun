using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUpdateScript : MonoBehaviour
{
    public Text pointsValueText;

    public PlayerProperties playerProperties;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsValueText.text = "" + playerProperties.points;
    }
}
