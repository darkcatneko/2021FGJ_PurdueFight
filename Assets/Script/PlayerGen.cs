using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGen : MonoBehaviour
{
    
    void Start()
    {
        Player one =  Instantiate(Resources.Load<Player>("Player"));
        one.SetPlayer(1);
    }

    
    void Update()
    {
        
    }
}
