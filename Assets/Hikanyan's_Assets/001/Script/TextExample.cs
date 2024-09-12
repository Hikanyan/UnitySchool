using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextExample : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Nyan;

    void Start()
    {
        Debug.Log("C# Already");
        Debug.Log("Complete!");
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Spaceが押されました");
            Nyan.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("LeftShiftが押されました");
            Nyan.SetActive(true);
        }
        
    }
}
