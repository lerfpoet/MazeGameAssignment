using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 800f;
    private float mouseSensitivity = 5f;
    private Vector3 moveDirection;
    private float rotationY;

    void FixedUpdate()
    {
        HandleMovement();
    }

    void Update()
    {
            HandleRotation();

            if (Input.GetButtonDown("Jump"))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 400, 0));
            }
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        moveDirection = ((horizontal * transform.right) + (vertical * transform.forward));
        
        GetComponent<Rigidbody>().linearVelocity = (moveDirection * speed * Time.fixedDeltaTime) + new Vector3(0, GetComponent<Rigidbody>().linearVelocity.y, 0);
        
    }

    private void HandleRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");
        rotationY += mouseX * mouseSensitivity;

        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }
}