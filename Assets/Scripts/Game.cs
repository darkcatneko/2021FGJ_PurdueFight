using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public const int PLAYER_NUM = 4;

    public Player[] players = new Player[PLAYER_NUM];
    void Start()
        {
        for (int i = 0; i < PLAYER_NUM; i++)
        {
            if (PlayerChoose.playerchoose[i]==i+1)
            {
                players[i] = Instantiate(Resources.Load<Player>("Player" + (i + 1)));
                players[i].SetPlayer(i + 1);    
            }
                     
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
        GameObject[] myObjArray = GameObject.FindGameObjectsWithTag("Player");
        int hitCount = 0;

        for (int i = 0; i < myObjArray.Length; i++) {
            if (myObjArray[i].GetComponent<Player>().isGetHit)
                hitCount++;
        }
        if (hitCount >= myObjArray.Length) {
            PlayerChoose.playerchoose = new int[4];
            SceneManager.LoadScene("Human Win");
        }
    }
}
