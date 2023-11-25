using UnityEngine;

public class MoveRobot : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 200f;
    public GameObject game_object;

    void Start()
    {
        Debug.Log(game_object.transform.position);
    }

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Get input from W and S keys for vertical movement along the Y-axis
        float verticalYInput = Input.GetKey(KeyCode.W) ? 1f : (Input.GetKey(KeyCode.S) ? -1f : 0f);

        // Calculate movement and rotation
        Vector3 movement = new Vector3(horizontalInput, verticalYInput, verticalInput);

        // Move the car forward/backward and up/down
        game_object.transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Rotate the car left/right
        game_object.transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
