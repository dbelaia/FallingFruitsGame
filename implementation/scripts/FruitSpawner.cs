using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs; // Array to hold different fruit prefabs
    public float spawnInterval = 1.5f; // Time interval between spawns
    public float screenBoundsX = 7f;  // Horizontal screen bounds for spawning fruits

    void Start()
    {
        // Ensure the array is not empty before starting the spawning process
        if (fruitPrefabs.Length > 0)
        {
            InvokeRepeating("SpawnFruit", 1f, spawnInterval); // Repeatedly spawn fruits
        }
        else
        {
            Debug.LogError("FruitSpawner: No fruit prefabs assigned! Add prefabs to the array in the Inspector.");
        }
    }

    void SpawnFruit()
    {
        // Check if the array is properly configured
        if (fruitPrefabs.Length == 0)
        {
            Debug.LogError("FruitSpawner: fruitPrefabs array is empty!");
            return;
        }

        // Randomly select a fruit prefab
        int randomIndex = Random.Range(0, fruitPrefabs.Length);
        GameObject selectedFruit = fruitPrefabs[randomIndex];

        // Ensure the selected prefab is valid
        if (selectedFruit == null)
        {
            Debug.LogError($"FruitSpawner: Prefab at index {randomIndex} is null! Check your array setup.");
            return;
        }

        // Generate a random horizontal position within screen bounds
        float randomX = Random.Range(-screenBoundsX, screenBoundsX);
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0f); // Adjust Y based on your scene's spawn height

        // Spawn the fruit prefab
        Instantiate(selectedFruit, spawnPosition, Quaternion.identity);
    }
}
