using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    [SerializeField] private Camera characterCamera;
    [SerializeField] private float speedH = 2.0f;
    [SerializeField] private float speedV = 2.0f;
    [SerializeField] private float walkingSpeed = 2f;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float jumpForce = 100;
    [SerializeField] private int playerIndex;
    [SerializeField] private PlayerTurn playerTurn;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    [SerializeField] private float pitchClamp = 90;

    private void Start()
    {
        {
            Cursor.visible = false;
        }
    }

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right * walkingSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
            }
            if (Input.GetKeyDown(KeyCode.Space) && IsTouchingFloor())
            {

                Jump();
            }
            ReadRotationInput();
        }
    }
    private void ReadRotationInput()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);


        characterCamera.transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        Cursor.lockState = CursorLockMode.Confined;
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
