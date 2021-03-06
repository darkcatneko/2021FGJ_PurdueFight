using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int PlayerID;
    public int TableCount;
    public bool isGetHit;
    public bool isEatting;
    public float Hunger;

    Animator animator;
    Dir dir = (Dir.Up | Dir.Left);

    public void SetPlayer(int Id)
    {
        PlayerID = Id;

        animator = GetComponent<Animator>();
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
            transform.SetLocalPositioinX(1.8f+0.7f*PlayerID);
        }
        else
        {
            transform.SetLocalPositioinX(-6.4f+0.7f*PlayerID);
        }
        //Debug.Log((int)dir);
    }

    void EatFood()
    {
        GameObject[] myObjArray;
        myObjArray = GameObject.FindGameObjectsWithTag("Food");
        if (InputButtonDown.Act(PlayerID))
        {
            isEatting = true;
            animator.SetBool("Eating", true);
            Hunger += Time.deltaTime;
            foreach (var item in myObjArray)
            {
                if ((int)dir == item.GetComponent<Food>().tableID)
                {
                    item.GetComponent<Food>().BeenEaten();
                }
            }
        }
        else
        {
            animator.SetBool("Eating", false);
            isEatting = false;
        }
    }
   
    void gameCheck()
    {
        if (isGetHit == true)
        {
            animator.SetTrigger("Damage");
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (Hunger>60)
        {
            PlayerChoose.playerchoose = new int[4];
            SceneManager.LoadScene("Ghost Win");
        }
    }    

    void Update()
    {
        ChangeTable();
        EatFood();
        gameCheck();
    }
}

