using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGen : MonoBehaviour
{
    
    void Start()
    {
        Player one =  Instantiate(Resources.Load<Player>("Player"));
        one.SetPlayer(1);
        Player two = Instantiate(Resources.Load<Player>("Player"));
        two.SetPlayer(2);
        Player three = Instantiate(Resources.Load<Player>("Player"));
        three.SetPlayer(3);
        Player four = Instantiate(Resources.Load<Player>("Player"));
        four.SetPlayer(4);
        Food Ham1 = Instantiate(Resources.Load<Food>("Bigmac"));
        Ham1.SetID(5);


    }

    
    void Update()
    {
        
    }
}
