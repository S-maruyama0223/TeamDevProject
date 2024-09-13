using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "PlayerInf", menuName = "プレイヤー/PlayerInf")]
public class PlayerInf : ScriptableObject
{
    public string Name;
    public int hp;
    public int level;
    public int attack;
    public Sprite cardSprite;
}

