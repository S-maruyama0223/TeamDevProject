using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AllEnemyInf", menuName = "エネミー/AllEnemyInf")]
public class AllEnemyInf : ScriptableObject
{
    public List<EnemyInf> allEnemyList;
}
