using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private Path _path;

    private void Awake()
    {
        _path = GetComponentInChildren<Path>();
    }

    private void Start()
    {
        var createdEnemy = StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        var waitSeconds = new WaitForSeconds(10);

        while (true)
        {
            var enemy = Instantiate(_enemy);
            enemy.Init(_path);

            yield return waitSeconds;
        }
    }
}