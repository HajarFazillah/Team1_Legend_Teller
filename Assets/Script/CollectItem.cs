using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CollectItem : MonoBehaviour
{
    public int itemValue = 1;  // Value of each coin collected

    private void Update()
    {
        transform.position += Vector3.left * GameManager.moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Access the score manager and add points
            GameManager.instance.AddScore(itemValue);

            // Update coin counter
            GameManager.instance.AddCoin();

            // Destroy the coin after collection
            Destroy(gameObject);
        }
    }
}