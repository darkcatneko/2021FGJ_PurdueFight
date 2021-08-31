using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] GameObject pic10;
    [SerializeField] GameObject pic9;[SerializeField] GameObject pic8;[SerializeField] GameObject pic7;
    [SerializeField] GameObject pic6;[SerializeField] GameObject pic5;[SerializeField] GameObject pic4;
    [SerializeField] GameObject pic3;[SerializeField] GameObject pic2;[SerializeField] GameObject pic1;
    public int tableID;
    public float FoodCount = 70;
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
            pic10.SetActive(false);
        }
        else if (FoodCount<8)
        {
            pic9.SetActive(false);
        }
        else if (FoodCount<15)
        {
            pic8.SetActive(false);
        }
        else if (FoodCount < 22)
        {
            pic7.SetActive(false);
        }
        else if (FoodCount < 29)
        {
            pic6.SetActive(false);
        }
        else if (FoodCount < 36)
        {
            pic5.SetActive(false);
        }
        else if (FoodCount < 43)
        {
            pic4.SetActive(false);
        }
        else if (FoodCount < 50)
        {
            pic3.SetActive(false);
        }
        else if (FoodCount < 57)
        {
            pic2.SetActive(false);
        }
        else if (FoodCount < 64)
        {
            pic1.SetActive(false);
        }

    }
    void Update()
    {
        LessBurger();
    }
}
