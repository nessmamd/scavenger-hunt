using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class pillsBehaviour : MonoBehaviour
{
    public GameObject parentObject;
    private bool clicked = false;  
    public GameObject[] allChildern;
    [SerializeField] TextMeshProUGUI textComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allChildern = new GameObject[parentObject.transform.childCount]; //will this work?? 
        for (int i = 0; i < allChildern.Length; i++){
            //getchild can only be done in transform
            allChildern[i] = parentObject.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
     for(int i = 0; i < allChildern.Length; i++){
        allChildern[i].GetComponent<Renderer>().material.color = new Color(0,0,0,1); 
     }
     textComponent.text = "<s>Pills</s>";
     if(!clicked){
        gameSim.globalVariable = gameSim.globalVariable + 1;
        Debug.Log(gameSim.globalVariable);
        clicked = true; 
        }

    }

}
