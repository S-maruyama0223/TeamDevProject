using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Player {
    /// <summary>
    /// �ǂ�ݒu����o�[�`�����p�b�h�̌X����臒l
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
    /// �ǂ�ݒu����
    /// </summary>
    private void installWall() {
        // �o�[�`�����p�b�h��臒l�ȏ�ɌX�����ꍇ�ɕǂ�ݒu����
        if (floatingJoystick.Input.magnitude >= INSTALL_WALL_BORDER) {
            Debug.Log("�ǂ�ݒu");
        }
    }
}
