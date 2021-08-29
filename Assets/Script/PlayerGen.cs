using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGen : MonoBehaviour
{
    
    void Start()
    {
        Player one =  Instantiate(Resources.Load<Player>("Player1"));
        one.SetPlayer(1);
        Player two = Instantiate(Resources.Load<Player>("Player2"));
        two.SetPlayer(2);
        Player three = Instantiate(Resources.Load<Player>("Player3"));
        three.SetPlayer(3);
        Player four = Instantiate(Resources.Load<Player>("Player4"));
        four.SetPlayer(4);
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
