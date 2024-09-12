using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour
{
    int count = 0;
    private void OnCollisionEnter(Collision other)
    {
        

        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("ao");
            if (count > 0)
            {
                Debug.Log("aw");
                Destroy(gameObject, 0.2f);
            }
            Debug.Log(count);
            count++;
        }
    }
}
