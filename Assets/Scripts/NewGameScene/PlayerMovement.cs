using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform theCamera;
    public float speed;
    public float SmoothTime = 5.0f;
    private float velocity;
    public Animator animator;

    void Update()
    {
        // Movement Input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical).normalized;

        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, theCamera.eulerAngles.y, ref velocity, SmoothTime);

        transform.rotation = Quaternion.Euler(0f, angle, 0f);

        controller.Move(transform.rotation * dir * speed * Time.deltaTime);

        // Set the Speed parameter to the magnitude of movement
        animator.SetFloat("Speed", dir.magnitude);

        //When the player is moving make the player face the direction of movement
        if (dir.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + theCamera.eulerAngles.y; // Calculate the angle
            // Smooth the angle of rotation (slowly rotate the player)
            float angle2 = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref velocity, SmoothTime);
            // Rotate the player slowly
            transform.rotation = Quaternion.Euler(0f, angle2, 0f);
        }
    }
}