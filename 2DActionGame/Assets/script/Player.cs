using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    [SerializeField] private FloatingJoystick floatingJoystick;
    [SerializeField] private float movementSpeed = 10f;
    void Update() {
        Vector2 movementDirection = new Vector2(
            Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        movementDirection = floatingJoystick.Direction;

        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
    }
}