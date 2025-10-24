using UnityEngine;

public class RotationChanger : MonoBehaviour
{
    private float _rotationSpeed = 30f;

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}
