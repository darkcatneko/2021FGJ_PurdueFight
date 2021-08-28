using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    class Player
    {
        public GameObject playerObject;
        int TableCount;
        bool Ifgethit;
        bool IfEating;
        float Hunger;
        
        public void ChangeTable()
        {
            switch (TableCount)
            {
                case 1:
                    this.playerObject.transform.position = new Vector3(-4.2f, 3.5f, 0f);
                    break;
                case 2:
                    this.playerObject.transform.position = new Vector3(-4.2f, -1.2f, 0f);
                    break;
                case 3:
                    this.playerObject.transform.position = new Vector3(4.2f, -1.2f, 0f);
                    break;
                case 4:
                    this.playerObject.transform.position = new Vector3(4.2f, 3.5f, 0f);
                    break;
            }

        }
    }
    [SerializeField] GameObject Player1; int TableCount = 1;
    void Start()
    {
        Player player1 = new Player();
        player1.playerObject = Player1;
    }
    
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            TableCount++;
            if (TableCount>4)
            {
                TableCount = 1;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            TableCount--;
            if (TableCount<1)
            {
                TableCount = 4;
            }
            
        }
    }
    
}
