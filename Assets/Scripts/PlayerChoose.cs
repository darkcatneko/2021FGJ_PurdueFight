using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChoose : MonoBehaviour
{
    public static int[] playerchoose = new int[4];
    [SerializeField] GameObject player1On;[SerializeField] GameObject player1Off;
    [SerializeField] GameObject player2On;[SerializeField] GameObject player2Off;
    [SerializeField] GameObject player3On;[SerializeField] GameObject player3Off;
    [SerializeField] GameObject player4On;[SerializeField] GameObject player4Off;
    [SerializeField] Button fightButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (playerchoose[0] == 0) {
                playerchoose[0] = 1;
                player1On.SetActive(true);
                player1Off.SetActive(false);
            } else  {
                playerchoose[0] = 0;
                player1Off.SetActive(true);
                player1On.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            if (playerchoose[1] == 0) {
                playerchoose[1] = 2;
                player2On.SetActive(true);
                player2Off.SetActive(false);
            } else {
                playerchoose[1] = 0;
                player2Off.SetActive(true);
                player2On.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.O)) {
            if (playerchoose[2] == 0) {
                playerchoose[2] = 3;
                player3On.SetActive(true);
                player3Off.SetActive(false);
            } else {
                playerchoose[2] = 0;
                player3Off.SetActive(true);
                player3On.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            if (playerchoose[3] == 0) {
                playerchoose[3] = 4;
                player4On.SetActive(true);
                player4Off.SetActive(false);
            } else {
                playerchoose[3] = 0;
                player4Off.SetActive(true);
                player4On.SetActive(false);
            }
        }

        int chooseCount = 0;
        for (int i = 0; i < 4; i++) {
            chooseCount += playerchoose[i];
        }
        fightButton.interactable = (chooseCount == 0) ? false : true;
    }
}
