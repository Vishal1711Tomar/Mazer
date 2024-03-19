using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rd.position.y < -1.00f)
        {
            StartCoroutine(FindObjectOfType<GameManager>().gameover());
        }
    }
   
}
