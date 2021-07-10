using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int passengerNumber;
    public int trainHealth;

    private void Start()
    {
        passengerNumber = 0;
        trainHealth = 3;
    }
    public void ChangePassengerNumber(int number)
    {
        passengerNumber = passengerNumber+number;
    }
    public void TrainHealthPlus(int health)
    {
        trainHealth = trainHealth+health;
    }
    public void TrainHealthMinus(int health)
    {
        trainHealth = trainHealth - health;
    }
}
