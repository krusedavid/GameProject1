using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float jumpForce = 100;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
                       
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));

        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));

        }

       if (Input.GetKeyDown(KeyCode.Space))
        {
            characterBody.AddForce(Vector3.up * jumpForce);
        }
    }

   

}
