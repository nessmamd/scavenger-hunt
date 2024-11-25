using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using System.Collections;


public class restartingGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void TaskOnClick()
    {
        Debug.Log("pressed");
        SceneManager.LoadScene("SampleScene");
    }
}
