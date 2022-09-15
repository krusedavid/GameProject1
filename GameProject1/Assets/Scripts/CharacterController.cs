using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float jumpForce = 100;
    private bool isJumping;

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

       if (Input.GetKeyDown(KeyCode.Space) && IsTouchingFloor())
        {
            /* Is a bool needed for saying when the character can jump?
             * I don't want the character to jump when it is jumping*/
            Jump();
        }


    }

    private void Jump()
    {
        characterBody.AddForce(Vector3.up * jumpForce);
    }
    private bool IsTouchingFloor()
    {
        RaycastHit hit;
        bool result = Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1f);
        return result;
    }
}
