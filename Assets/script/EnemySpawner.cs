using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("怪物預製物")]
    public GameObject enemyPrefab;
    [Header("生成位置")]
    public Transform[] spawnPoints;
    [Header("生成間隔")]
    public float spawnInterval = 2f;
    [Header("怪物數量上限")]
    public int maxEnemies = 10;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
            if (enemies.Length >= maxEnemies)
                return;
            if (spawnPoints.Length == 0 || enemyPrefab == null)
                return;
            int index = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefab, spawnPoints[index].position, Quaternion.identity);
        }
    }

}
