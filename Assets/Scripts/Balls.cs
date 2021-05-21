using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    private void OnMouseDown()
    { 
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
        Destroy(gameObject);
    }
}
