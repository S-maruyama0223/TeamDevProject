using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyInf", menuName = "�G�l�~�[/EnemyInf")]
public class EnemyInf : ScriptableObject
{
    public string Name;
    public int hp;
    public int attack;
    public Sprite cardSprite;
}
