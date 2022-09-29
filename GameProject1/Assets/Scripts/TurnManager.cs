using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnManager : MonoBehaviour
{

    private static TurnManager instance;
    public int currentPlayerIndex;
    public GameObject[] players;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
        }
        Camera.main.GetComponent<FollowCamera>().targetPlayer(players[0].transform);
    }

    public bool IsItPlayerTurn(int index)
    {
        return index == currentPlayerIndex;
    }

    public static TurnManager GetInstance()
    {
        return instance;
    }

    public void ChangeTurn()
    {
        if (currentPlayerIndex == 1)
        {
            currentPlayerIndex = 2;
        }
        else if (currentPlayerIndex == 2)
        {
            currentPlayerIndex = 1;
        }

        if (players[currentPlayerIndex - 1].GetComponent<Health>().isAlive == false)
        {
            SceneManager.LoadScene("Level1");
        }
        Camera.main.GetComponent<FollowCamera>().targetPlayer(players[currentPlayerIndex -1].transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ChangeTurn();
        }
    }
}
