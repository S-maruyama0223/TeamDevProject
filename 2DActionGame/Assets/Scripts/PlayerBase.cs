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

        //��ʂ̍����[���擾
        Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(Vector3.zero);

        //��ʊO�ɏo��ꍇ�́A��ʒ[�̍��W�ɕϊ�����
        Vector2 position = transform.position;
        position.x = Mathf.Clamp(position.x, bottomLeft.x, bottomLeft.x * -1);
        position.y = Mathf.Clamp(position.y, bottomLeft.y, bottomLeft.y * -1);
        transform.position = position;
    }
}