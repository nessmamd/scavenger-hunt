using UnityEngine;
using System.Collections;
public class canvasScript : MonoBehaviour
{
    private Canvas CanvasObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameSim.globalVariable == 7){
            GetComponent<Canvas>().enabled = true;
        }
    }
}
