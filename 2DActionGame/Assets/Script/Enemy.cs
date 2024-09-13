using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int hp;
    [SerializeField]
    private int attack;
    [SerializeField]
    private Sprite enemySprite;
    [SerializeField]
    private SpriteRenderer enemySpriteRenderer;
    private EnemyInf enemyInf;

    public int Hp
    {
        get { return hp; }
        set
        {
            if (hp != value)
                hp = value;
        }
    }

    public int Attack
    {
        get { return attack; }
        set
        {
            if (attack != value)
                attack = value;
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnemySetting(EnemyInf enemyrInf)
    {
        hp = enemyrInf.hp;
        attack = enemyrInf.attack;
        enemySprite = enemyrInf.cardSprite;
        enemySpriteRenderer.sprite = enemySprite;
    }
}
