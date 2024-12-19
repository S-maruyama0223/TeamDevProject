using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour {
    [SerializeField] protected FloatingJoystick floatingJoystick;
    [SerializeField] private float movementSpeed = 10f;
    virtual protected void Update() {
        Vector2 movementDirection = new Vector2(
            Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        movementDirection = floatingJoystick.Direction;

        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);

        //画面の左下端を取得
        Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(Vector3.zero);

        //画面外に出る場合は、画面端の座標に変換する
        Vector2 position = transform.position;
        position.x = Mathf.Clamp(position.x, bottomLeft.x, bottomLeft.x * -1);
        position.y = Mathf.Clamp(position.y, bottomLeft.y, bottomLeft.y * -1);
        transform.position = position;
    }
}