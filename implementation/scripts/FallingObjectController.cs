using UnityEngine;

public class FallingObjectController : MonoBehaviour
{
    void Update()
    {
        // Destroy the object if it falls below the screen
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Caught by Player!");
            Destroy(gameObject); // Destroy the apple
        }
    }
}
