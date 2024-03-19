using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{ 
    public static float Scores = 0f;
    public static float b = 0f;
    public Text score;
    public Text Indiscore ;
    bool gamehasended = false;
    public GameObject LevelComplete;
    public FirstPersonController movement;
    public GameObject gameovers;
    public GameObject scoress;
    public GameObject PauseUI;


    //  public GameObject complete;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void CompleteL()
    {
        if (gamehasended == false)
        {
            movement.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            LevelComplete.SetActive(true);
          //  b = b + Scores;
           // Scores = 0;
        

        }
    }
    public void quit()
    {
        Application.Quit();
    }
    public void Mainmenu()
    {
       // PauseUI.SetActive(false);
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
      //  PauseUI.SetActive(false);
     //  scoress.SetActive(true);
        Time.timeScale = 1f;
       // b = b + Scores;
        Scores = 0;

        
           

        //  Cursor.lockState = CursorLockMode.None;
        //   Cursor.visible = false;


        // PauseUI.SetActive(false);
       

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      //  movement.enabled = true;
    }
    public IEnumerator Ends()
    {
        Debug.Log("chal bc");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  );
    }
    public IEnumerator gameover()
    {
        Debug.Log("chal bc");
        yield return new WaitForSeconds(2);
        movement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

     //  scoress.SetActive(false);
        gameovers.SetActive(true);
     //   b = b+ Scores;
    }
    public void Resume()
    {
        PauseUI.SetActive(false);
       // scoress.SetActive(true);
        Time.timeScale = 1f;

      //  Cursor.lockState = CursorLockMode.None;
      //   Cursor.visible = false;
       
       
       // PauseUI.SetActive(false);
       movement.enabled = true;

       

    }


    // Update is called once per frame
    void Update()
    {
        score.text = Scores.ToString();
        Indiscore.text = b.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
              movement.enabled = false;
          //   scoress.SetActive(false);
            Time.timeScale = 0f;
            PauseUI.SetActive(true);
          


        }
    }

}
