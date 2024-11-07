using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : PlayerBase {

    /// <summary>
    /// ©“®’e”­ËŠÔŠu 
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
            // ’eŠÛ”­Ëˆ—««««
            Debug.Log("’e‚ğ”­Ë‚µ‚Ü‚·");
            // ’eŠÛ”­Ëˆ—ªªªª
        }
    }


}
