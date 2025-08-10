using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    void Start()
    {
        StartCoroutine(SpawnWithDelay());
    }

    private Vector3 GetRandomSpawnPosition()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;
    }

    private int GetRandomAngle()
    {
        int minAngle = 0; 
        int maxAngle = 360; 

        return Random.Range(minAngle, maxAngle + 1);
    }

    private IEnumerator SpawnWithDelay()
    {
        var waitForTwoSeconds = new WaitForSeconds(2);

        while (true)
        {
            yield return waitForTwoSeconds;

            Enemy enemy = Instantiate(_enemyPrefab, GetRandomSpawnPosition(), Quaternion.identity);

            enemy.RotateAxisY(GetRandomAngle());
        }
    }
}
