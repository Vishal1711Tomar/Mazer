using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open : MonoBehaviour
{ 
    public GameObject door;
    public GameObject fire;
    // public GameObject Completecanvus;
    void OnTriggerEnter(Collider collider)
    { if (GameManager.Scores >= 1)
        {
            door.transform.position = new Vector3(0,-100f,0);
          
          //  door.SetActive(false);
            fire.SetActive(true);
          //  yield return new WaitForSeconds(2);

            Debug.Log("yes");
         //   door.SetActive(true);
            StartCoroutine(hehe());
        
            

            //  Completecanvus.SetActive(true);

        }

    }
    IEnumerator hehe()
    {
        yield return new WaitForSeconds(4);
        FindObjectOfType<GameManager>().CompleteL();

    }


    // Update is called once per frame
    
}
