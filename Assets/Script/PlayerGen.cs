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

        Food Set1 = Instantiate(Resources.Load<Food>("Foods"));
        Set1.SetID(5);
        Food Set2 = Instantiate(Resources.Load<Food>("Foods1"));
        Set2.SetID(9);
        Food Set3 = Instantiate(Resources.Load<Food>("Foods2"));
        Set3.SetID(6);
        Food Set4 = Instantiate(Resources.Load<Food>("Foods3"));
        Set4.SetID(10);
    }

    
    void Update()
    {
        
    }
}
