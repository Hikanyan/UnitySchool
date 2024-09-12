using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PlayerMovement : MonoBehaviour
    {
        public float speed = 15f;
        private void FixedUpdate()
        {
            var velox = speed * Input.GetAxisRaw("Horizontal");
            GetComponent<Rigidbody>().velocity = new Vector3(velox,0f,0f);
        }
    }

