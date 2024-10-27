using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Player : MonoBehaviour{
    [SerializeField] private FloatingJoystick floatingJoystick;
    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private List<Weapon> weapons;
    public List<Weapon> Weapons {
        get { return weapons; }
        set { weapons = value; }
    }

    private void Start() {
        foreach (var weapon in weapons) {
            if (weapon != null)
                weapon.NextFireRate = 0.5f;
        }
    }

    void Update() {
        
        foreach (var weapon in weapons) {
            if (Time.time >= weapon.NextFireRate) {
                Vector2 Direction = new Vector2(0, 1);
                weapon.InstantiateWeapon(transform.position, Direction);
            }
        }
    }
}