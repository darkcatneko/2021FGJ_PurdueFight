using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGen : MonoBehaviour
{
    const int PLAYER_NUM = 4;

    public Player[] players = new Player[PLAYER_NUM];

    void Start()
    {
        for (int i = 0; i < PLAYER_NUM; i++) {
            players[i] = Instantiate(Resources.Load<Player>("Player"));
            players[i].SetPlayer(i + 1);
        }

        Food Ham1 = Instantiate(Resources.Load<Food>("Bigmac"));
        Ham1.SetID(5);


    }

    
    void Update()
    {
        
    }
}
