using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]private GameObject _dogPrefab;
    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(_dogPrefab, transform.position, _dogPrefab.transform.rotation);
                timer = 0;
            }
        }
        
    }
}
