using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Speed of the basket
    public float screenBounds = 7f; // Adjust based on your screen width

    void Update()
    {
        // Get horizontal input from player
        float move = Input.GetAxis("Horizontal");

        // Move the basket horizontally
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);

        // Clamp the basket's position within screen bounds
        float clampedX = Mathf.Clamp(transform.position.x, -screenBounds, screenBounds);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
