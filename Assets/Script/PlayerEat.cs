using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEat : MonoBehaviour
{
    [SerializeField] float FoodAmount1;
    void Start()
    {
        
    }    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            FoodAmount1 = FoodAmount1 - Time.deltaTime;
        }
    }
}
