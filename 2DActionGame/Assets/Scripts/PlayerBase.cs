using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour{
    [SerializeField] protected FloatingJoystick floatingJoystick;
    [SerializeField] private float movementSpeed = 10f;
    virtual protected void Update() {
        Vector2 movementDirection = new Vector2(
            Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        movementDirection = floatingJoystick.Direction;

        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
    }
}