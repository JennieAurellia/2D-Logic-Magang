using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyGameObject;
    [SerializeField] private GameObject enemy_skeleton;

    // Start is called before the first frame update
    void Start()
    {
        enemyGameObject = GameObject.Find("Enemy");
        Debug.Log(enemyGameObject.transform.childCount);
    }

    void SpawnEnemy()
    {
        Vector3 enemySpawnPos = enemyGameObject.transform.position;
        Instantiate(enemy_skeleton, enemySpawnPos, Quaternion.identity);
    }

    public void test()
    {
        SpawnEnemy();
        Debug.Log(enemyGameObject.transform.childCount);
    }
}
