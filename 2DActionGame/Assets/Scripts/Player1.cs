using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : PlayerBase {

    /// <summary>
    /// ©“®’e”­ËŠÔŠu 
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
            // ’eŠÛ”­Ëˆ—««««
            Debug.Log("’e‚ğ”­Ë‚µ‚Ü‚·");
            //À•W‚Í‰¼ì¬
            float xPos = transform.position.x;
            float yPos = transform.position.y;
            Vector2 spawnPosition = new Vector2(xPos, yPos);
            Instantiate(bullet, spawnPosition, Quaternion.identity);
            // ’eŠÛ”­Ëˆ—ªªªª
        }
    }


}
