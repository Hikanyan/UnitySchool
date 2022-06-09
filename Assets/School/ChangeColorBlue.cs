using UnityEngine;
using System.Collections;
public class ChangeColorBlue : MonoBehaviour
{
    int count = 0;
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Ball")
        {
            GetComponent<Renderer>().material.color = Color.blue;
            GetComponent<Transform>().localScale = new Vector3(1 / 2f, 1.0f, 1 / 2f);
        }

    }
}