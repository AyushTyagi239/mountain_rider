using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Player movement settings
    [SerializeField] float Torque = 100f;          // How much rotational force is applied when turning
    [SerializeField] float BoostSpeed = 150f;      // Speed when boosting (Up Arrow pressed)
    [SerializeField] float BaseSpeed = 95f;        // Normal speed when not boosting
    
    // Component references
    Rigidbody2D rb2d;                              // Handles physics (movement, rotation)
    SurfaceEffector2D surfaceEffector;  
           // Controls ground movement (speed)
    
    void Start()
    {
        // Get the Rigidbody2D attached to this GameObject (player)
        rb2d = GetComponent<Rigidbody2D>();
        
        // Find the SurfaceEffector2D in the scene (used for ground speed control)
        surfaceEffector = GameObject.FindObjectOfType<SurfaceEffector2D>();
       
        // Check if we found the SurfaceEffector2D
        if(surfaceEffector == null)
        {
            Debug.LogError("No SurfaceEffector2D found in scene!");
        }
        else
        {
            Debug.Log($"Found surface: {surfaceEffector.gameObject.name}");
        }
    }

    void Update()
    {
        RotatePlayer();   // Handle left/right rotation
        RespondToBoost(); // Handle speed boost (Up Arrow)
    }

    // Controls speed boost when pressing Up Arrow
    void RespondToBoost()
    {
        if(surfaceEffector != null)
        {
            // If Up Arrow is pressed, use BoostSpeed, otherwise use BaseSpeed
            surfaceEffector.speed = Input.GetKey(KeyCode.UpArrow) ? BoostSpeed : BaseSpeed;
        }
    }

    // Handles player rotation (left/right arrows)
    void RotatePlayer()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            // Rotate counter-clockwise (left)
            rb2d.AddTorque(Torque);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            // Rotate clockwise (right)
            rb2d.AddTorque(-Torque);
        }
    }
}