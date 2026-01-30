using UnityEngine;
using UnityEngine.UI;

public class UIElectricThrustEffect : MonoBehaviour
{
    private Image thrustImage;
    private Vector3 origin;
    
    private float intensity = 0.8f;
    private float minAlpha = 0.6f;

    void Start()
    {
        thrustImage = GetComponent<Image>();
        origin = transform.localPosition;
    }

    void Update()
    {
        float x = Random.Range(-intensity, intensity);
        float y = Random.Range(-intensity, intensity);
        transform.localPosition = origin + new Vector3(x, y, 0);

        Color c = thrustImage.color;
        c.a = Random.Range(minAlpha, 1.0f);
        thrustImage.color = c;
    }
}