using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : PlayerBase {

    /// <summary>
    /// �����e���ˊԊu 
    /// </summary>
    [SerializeField] private float autoFireInterval;

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
            // �e�۔��ˏ�����������
        }
    }


}
