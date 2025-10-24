using UnityEngine;

public class Moover : MonoBehaviour
{
    private float _moovingSpeed = 2f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _moovingSpeed * Time.deltaTime);
    }
}
