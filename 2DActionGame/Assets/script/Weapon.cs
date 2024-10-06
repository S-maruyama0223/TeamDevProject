using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float fireRate;
    [SerializeField] private float nextFireRate;
    [SerializeField] private float speed;
    [SerializeField] private float attack;
    [SerializeField] private Vector2 movementDirection;

    public float FireRate {
        get { return fireRate; }
        set { fireRate = value; }
    }

    public float NextFireRate {
        get { return nextFireRate; }
        set { nextFireRate = value; }
    }

    public float Speed {
        get { return speed; }
        set { speed = value; }
    }

    public float Attack {
        get { return attack; }
        set { attack = value; }
    }

    public Vector2 MovementDirection {
        get { return movementDirection; }
        set { movementDirection = value; }
    }

    private void Update() {
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }


    public void InstantiateWeapon(Vector3 playerPosition, Vector2 plyaerMovementDirection) {
        GameObject weaponObject = Instantiate(gameObject);
        weaponObject.transform.position = playerPosition;
        MovementDirection = plyaerMovementDirection;
    }

}
