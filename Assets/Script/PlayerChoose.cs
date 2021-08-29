using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChoose : MonoBehaviour
{
    public static int[] playerchoose = new int[4];
    [SerializeField] GameObject player1On;[SerializeField] GameObject player1Off;
    [SerializeField] GameObject player2On;[SerializeField] GameObject player2Off;
    [SerializeField] GameObject player3On;[SerializeField] GameObject player3Off;
    [SerializeField] GameObject player4On;[SerializeField] GameObject player4Off;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            playerchoose[0] = 1;
            player1On.SetActive(true);
            player1Off.SetActive(false);
        }
        else
        {
            player1Off.SetActive(true);
            player1On.SetActive(false);
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            playerchoose[1] = 2;
            player2On.SetActive(true);
            player2Off.SetActive(false);
        }
        else
        {
            player2Off.SetActive(true);
            player2On.SetActive(false);
        }
        if (Input.GetKey(KeyCode.O))
        {
            playerchoose[2] = 3;
            player3On.SetActive(true);
            player3Off.SetActive(false);
        }
        else
        {
            player3Off.SetActive(true);
            player3On.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            playerchoose[3] = 4;
            player4On.SetActive(true);
            player4Off.SetActive(false);
        }
        else
        {
            player4Off.SetActive(true);
            player4On.SetActive(false);
        }

    }
}
