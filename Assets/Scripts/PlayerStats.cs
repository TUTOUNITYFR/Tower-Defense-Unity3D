using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int money;
    public int startMoney = 400;

    public static int lives;
    public int startLives = 20;

    public static int rounds;

    public void Start()
    {
        rounds = 0;
        money = startMoney;
        lives = startLives;
    }

}
