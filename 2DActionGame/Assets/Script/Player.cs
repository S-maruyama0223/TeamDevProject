using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int hp;
    [SerializeField]
    private int level;
    [SerializeField]
    private int attack;
    [SerializeField]
    private Sprite playerSprite;
    [SerializeField]
    private SpriteRenderer playerSpriteRenderer;
    private PlayerInf playerInf;

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

    public int Level
    {
        get { return level; }
        set
        {
            if (level != value)
                level = value;
        }
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayerSetting(PlayerInf playerInf)
    {
        hp = playerInf.hp;
        attack = playerInf.attack;
        level = playerInf.level;
        playerSprite = playerInf.cardSprite;
        playerSpriteRenderer.sprite = playerSprite;
    }
}
