using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField] private int plus = 0;
    [SerializeField] GameManager gameManager;
   
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            gameManager.AddScore(plus);

            
        }

    }
}
