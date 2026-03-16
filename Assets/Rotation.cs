using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // if (Input.GetKey(KeyCode.Space))
        // {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        // }
    }
}
