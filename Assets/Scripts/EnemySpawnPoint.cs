using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    private EnemySpawnPoint _currentSpawnPoint;

    private void Awake()
    {
        _currentSpawnPoint = this;
    }
    public Vector3 GetCurrentPosition()
    {
        return _currentSpawnPoint.transform.position;
    }

    public Quaternion GetCurrentRotation()
    {
        return _currentSpawnPoint.transform.rotation;
    }
}
