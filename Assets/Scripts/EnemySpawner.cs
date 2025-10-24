using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyPool _enemiesPool;
    [SerializeField] private EnemySpawnPoint[] _spawners;

    private float _spawnInterval = 2f;
    private int _minSpawnPointCount = 0;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0.0f, _spawnInterval);
    }

    private void SpawnEnemy()
    {
        Enemy enemy = _enemiesPool.GetEnemy();

        EnemySpawnPoint _currentSpawner = GetCurrentSpawner();

        enemy.transform.position = _currentSpawner.GetCurrentPosition();
        enemy.transform.rotation = _currentSpawner.GetCurrentRotation();
    }

    private EnemySpawnPoint GetCurrentSpawner()
    {
        EnemySpawnPoint currentSpawner = _spawners[Random.Range(_minSpawnPointCount, _spawners.Length)];

        return currentSpawner;
    }
}
