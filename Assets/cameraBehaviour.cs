using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 5.0f; // Movement speed of the camera.
    public float rotationSpeed = 120.0f; // Horizontal rotation speed.
    public float mouseSensitivity = 100.0f; // Mouse sensitivity for looking around.

    private float verticalRotation = 0.0f; // Track the vertical rotation for clamping.

    void Update()
    {
        HandleMovement();
        // HandleRotation();
    }

    // Handle movement based on WASD or arrow keys
    private void HandleMovement()
    {
        // Get movement input
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right arrows
        float moveVertical = Input.GetAxis("Vertical"); // W/S or Up/Down arrows

        // Calculate movement vector
        Vector3 movement = (transform.forward * moveVertical + transform.right * moveHorizontal) * speed * Time.deltaTime;

        // Apply movement
        transform.position += movement;
    }

    // // Handle camera rotation with mouse input
    // private void HandleRotation()
    // {
    //     // Get mouse input
    //     float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    //     float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    //     // Rotate camera horizontally (yaw)
    //     transform.Rotate(Vector3.up, mouseX);

    //     // Clamp and rotate vertically (pitch)
    //     verticalRotation -= mouseY;
    //     verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // Prevent over-rotation
    //     transform.localEulerAngles = new Vector3(verticalRotation, transform.localEulerAngles.y, 0f);
    // }
}
