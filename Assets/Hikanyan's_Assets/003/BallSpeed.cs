using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    public float Power = -5;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, Power);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
