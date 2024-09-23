using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Player {
    /// <summary>
    /// 壁を設置するバーチャルパッドの傾きの閾値
    /// </summary>
    private static float INSTALL_WALL_BORDER = 1.4f;

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
        if (floatingJoystick.Input.magnitude >= INSTALL_WALL_BORDER) {
            Debug.Log("壁を設置");
        }
    }
}
