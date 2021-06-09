namespace OurVideoGame {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ControlledPlayerMovement : MonoBehaviour
    {

     Rigidbody2D characterMovementBody;

        float horizontalInput;
        float verticalInput;
        float diagonalMoveLimiter = 0.7f;
        public float characterRunSpeed = 10.0f;

        float isSprinting;
        // Start is called before the first frame update
        void Start()
        {
            characterMovementBody = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            //Gives a value between -1 and 1 based on what arrow key/wasd is pressed
            // Have to be changed to allow for controller input
            horizontalInput = Input.GetAxisRaw("Horizontal"); // -1 = left, 1 = right, 0 = nothing pressed
            verticalInput = Input.GetAxisRaw("Vertical"); // -1 = down, 1 = up, 0 = nothing
            isSprinting = Input.GetAxisRaw("Fire3");

            // From https://answers.unity.com/questions/630670/rotate-2d-sprite-towards-moving-direction.html
            Vector2 moveDirection = GetComponent<Rigidbody2D>().velocity;
            if (moveDirection != Vector2.zero)
            {
                float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }

        void FixedUpdate()
        {
            if( horizontalInput != 0 && verticalInput != 0)
            {
                horizontalInput *= diagonalMoveLimiter;
                verticalInput *= diagonalMoveLimiter;
            }
            characterMovementBody.velocity = new Vector2(horizontalInput * characterRunSpeed, verticalInput * characterRunSpeed);
        }
    }
}