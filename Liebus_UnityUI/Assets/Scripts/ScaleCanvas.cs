using UnityEngine;

public class ScaleCanvas : MonoBehaviour
{
    public float scaleFactor = 0.5f; // Adjust this value to control the scale factor

    void Start()
    {
        // Scale the canvas
        transform.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
    }
}