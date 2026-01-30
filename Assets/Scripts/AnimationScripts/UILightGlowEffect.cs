using UnityEngine;
using UnityEngine.UI;

public class UILightGlowEffect : MonoBehaviour
{
    private float moveDistance = 1f; // Small pixel offset
    private float speed = 1f;      // Slow, calm movement
    private Vector2 startPosition;

    void Start()
    {
        // Anchors the light to its starting point on the ship
        startPosition = transform.localPosition;
    }

    void Update()
    {
        // Mathf.Sin creates a smooth back-and-forth loop
        float newY = Mathf.Sin(Time.time * speed) * moveDistance;

        // Updates position relative to the spaceship image
        transform.localPosition = new Vector2(startPosition.x, startPosition.y + newY);
    }
}