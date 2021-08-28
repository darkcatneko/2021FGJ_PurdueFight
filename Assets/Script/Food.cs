using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] GameObject pic3;[SerializeField] GameObject pic2;[SerializeField] GameObject pic1;
    public int tableID;
    public float FoodCount = 60;
    public void SetID(int id)
    {
        tableID = id;
    }
    public void BeenEaten()
    {
        FoodCount -= Time.deltaTime;
    }
    public void LessBurger()
    {
        
        if (FoodCount<0)
        {
            pic3.SetActive(false);
        }
        else if (FoodCount<20)
        {
            pic2.SetActive(false);
        }
        else if (FoodCount<40)
        {
            pic1.SetActive(false);
        }

    }
    void Update()
    {
        LessBurger();
    }
}
