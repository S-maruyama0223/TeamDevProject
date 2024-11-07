using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private Coroutine spawnCoroutine;

    private float spawnInterval = 2f;

    private void Start() {
        spawnCoroutine = StartCoroutine(spawnPrefabs());
    }

    /// <summary>
    /// spawnInterval�̒l���̊Ԋu��҂���SpawnPrefab�����s����
    /// </summary>
    /// <returns></returns>
    private IEnumerator spawnPrefabs() {
        while (true) {
            spawnPrefab();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void spawnPrefab() {
        //���W�͉��쐬
        float xPos = 4f;
        float yPos = -2f;
        Vector2 spawnPosition = new Vector2(xPos, yPos);
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }

    /// <summary>
    /// spawnInterval�̒l��ύX���邽�߂̃Z�b�^�[
    /// </summary>
    /// <param name="newInterval"></param>
    public void changeSpawnInterval(float newInterval) {
        spawnInterval = newInterval;

        if (spawnCoroutine != null) {
            StopCoroutine(spawnCoroutine);
            spawnCoroutine = StartCoroutine(spawnPrefabs());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
