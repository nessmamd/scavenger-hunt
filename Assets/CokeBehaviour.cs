using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CokeBehaviour : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    private bool clicked = false;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        if(!clicked){
            gameSim.globalVariable = gameSim.globalVariable + 1;
            Debug.Log(gameSim.globalVariable);
            clicked = true; 
        }
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 1);
        textComponent.text = "<s>Coca Cola</s>";
    }
}
