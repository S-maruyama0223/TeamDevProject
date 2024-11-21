using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : PlayerBase {

    /// <summary>
    /// �����e���ˊԊu 
    /// </summary>
    [SerializeField] private float autoFireInterval;

    [SerializeField] private GameObject bullet;

    void Start() {
        StartCoroutine(autoFire());
    }

    override protected void Update() {
        base.Update();
    }

    private IEnumerator autoFire() {
        while (true) {
            yield return new WaitForSeconds(autoFireInterval);
            // �e�۔��ˏ�����������
            Debug.Log("�e�𔭎˂��܂�");
            //���W�͉��쐬
            float xPos = transform.position.x;
            float yPos = transform.position.y;
            Vector2 spawnPosition = new Vector2(xPos, yPos);
            Instantiate(bullet, spawnPosition, Quaternion.identity);
            // �e�۔��ˏ�����������
        }
    }


}
