using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] AllPlayerInf allPlayerInf;
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InstantiatePlayer();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void InstantiatePlayer()
    {
        foreach (PlayerInf playerInf in allPlayerInf.allPlayerList)
        {
            GameObject player = Instantiate(playerPrefab);
            player.GetComponent<Player>().PlayerSetting(playerInf);
        }
    }
}
