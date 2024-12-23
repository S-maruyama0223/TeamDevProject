using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : PlayerBase {
    /// <summary>
    /// 壁を設置するバーチャルパッドの傾きの閾値
    /// </summary>
    private static float INSTALL_WALL_BORDER = 1.43f;

    private bool installable = true;

    [SerializeField] private GameObject wall;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    override protected void Update() {
        base.Update();
        installWall();
    }

    /// <summary>
    /// 壁を設置する
    /// </summary>
    private void installWall() {
        // バーチャルパッドを閾値以上に傾けた場合に壁を設置する
        if (installable && floatingJoystick.Distance >= INSTALL_WALL_BORDER) {
            Debug.Log("壁を設置");
            float xPos = transform.position.x;
            float yPos = transform.position.y;
            Vector2 spawnPosition = new Vector2(xPos, yPos);
            Instantiate(wall, spawnPosition, Quaternion.identity);
            installable = false;
        } else if (floatingJoystick.Distance < 1.0) {
            installable = true;
        }
    }
}
