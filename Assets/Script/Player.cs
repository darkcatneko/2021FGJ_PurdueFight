using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [System.Flags]
    enum Dir 
    {
    Up =1,
    Down = 2,
    Left = 4,
    Right = 8,

    }

    Dir dir = (Dir.Up | Dir.Left);
        public int PlayerID;
        public int TableCount;
        bool Ifgethit;
        bool IfEating;
        float Hunger;
        
        public void SetPlayer(int Id)
        {
        PlayerID = Id;
        }
    public void ChangeTable()
    {
        //Debug.Log((int)dir);
        if (InputButtonDown.Up(PlayerID))
        {
            dir = (dir | Dir.Up) ^ Dir.Down;
        }
        else if (InputButtonDown.Down(PlayerID))
        {
            dir = (dir | Dir.Down) ^ Dir.Up;
        }
        if (InputButtonDown.Left(PlayerID))
        {
            dir = (dir | Dir.Left) ^ Dir.Right;
        }
        else if (InputButtonDown.Right(PlayerID))
        {
            dir = (dir | Dir.Right) ^ Dir.Left;
        }

        if (Dir.Up == (dir & Dir.Up))
        {
            transform.SetLocalPositioinY(3.5f);
        }
        else
        {
            transform.SetLocalPositioinY(-1.2f);
        }
        if (Dir.Right == (dir & Dir.Right))
        {
            transform.SetLocalPositioinX(4.2f);
        }
        else
        {
            transform.SetLocalPositioinX(-4.2f);
        }
        //Debug.Log((int)dir);
    }

    void EatFood()
    {
        GameObject[] myObjArray;
        myObjArray = GameObject.FindGameObjectsWithTag("Food");
        if (InputButtonDown.Act(PlayerID))
        {
            foreach (var item in myObjArray)
            {
                if ((int)dir == item.GetComponent<Food>().tableID)
                {
                    item.GetComponent<Food>().BeenEaten();
                }
            }
        }
    }
    private void Update()
    {
        ChangeTable();
        EatFood();
    }
}

