using UnityEngine;

public class monaLisaBehaviour : MonoBehaviour
{
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
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 1);
    }
}
