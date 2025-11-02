using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyPool _enemiesPool;
    [SerializeField] private EnemySpawnPoint[] _spawners;

    private Coroutine _coroutine;

    private float _spawnInterval = 2f;
    private int _minSpawnPointCount = 0;
    private bool _isWork = true;

    private void OnEnable()
    {
        _coroutine = StartCoroutine(SpawnEnemyAfterDelay(_spawnInterval));
    }

    private IEnumerator SpawnEnemyAfterDelay(float delay)
    {
        while (_isWork)
        {
            yield return new WaitForSeconds(delay);

            SpawnEnemy();
        }
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
