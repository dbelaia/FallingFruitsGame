using UnityEngine;

public class Fruit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the fruit collides with the basket
        if (collision.CompareTag("Basket"))
        {
            Destroy(gameObject); // Destroy the fruit
        }
    }
}