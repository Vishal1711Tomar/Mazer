using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject Completecanvus;
    // Start is called before the first frame update
     IEnumerator OnCollisionEnter(Collision collision)
     {
        Debug.Log("Chal BC");
        yield return new WaitForSeconds(2);
        Completecanvus.SetActive(true);
        FindObjectOfType<GameManager>().CompleteL();
     }
}
