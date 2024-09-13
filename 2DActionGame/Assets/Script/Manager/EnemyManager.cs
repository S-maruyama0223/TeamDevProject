using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] AllEnemyInf allEnemyInf;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateEnemy()
    {
        foreach (EnemyInf enemyInf in allEnemyInf.allEnemyList)
        {
            GameObject player = Instantiate(enemyPrefab);
            player.GetComponent<Enemy>().EnemySetting(enemyInf);
        }
    }
}
