using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndOfLevel : MonoBehaviour
{

    public void ChangeOfGame()
    {
        //Debug.Log("HIT");
        //Application.Quit();        
        SceneManager.LoadScene("Sala");
    }
    public void EndOfGame()
    {   //Debug.Log("HIT");
        Application.Quit();
        //SceneManager.LoadScene("Sala");

    }
}
