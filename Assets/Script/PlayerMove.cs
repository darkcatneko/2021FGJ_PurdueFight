using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] GameObject Player1;
    int TableCount = 1;
    void Start()
    {
        
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
            ChangeTable();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            TableCount--;
            if (TableCount<1)
            {
                TableCount = 4;
            }
            ChangeTable();
        }
    }
    void ChangeTable()
    {
        switch (TableCount) 
        {  case 1:
                Player1.transform.position = new Vector3(-4.2f, 3.5f, 0f);
            break;
            case 2:
                Player1.transform.position = new Vector3(-4.2f, -1.2f, 0f);
                break;
            case 3:
                Player1.transform.position = new Vector3(4.2f, -1.2f, 0f);
                break;
            case 4:
                Player1.transform.position = new Vector3(4.2f, 3.5f, 0f);
                break;
        }
           
    }
}
