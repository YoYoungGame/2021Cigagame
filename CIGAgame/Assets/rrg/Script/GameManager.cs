using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int passengerNumber;
    public void ChangePassengerNumber(int number)
    {
        passengerNumber = number;
    }


    public int MeetTrainStation()
    {
        int returnNum = passengerNumber;
        passengerNumber = 0;
        return returnNum;

    }

    public int m_CurrentMoneyNum = 0;

    public void AddMoreMoney( int num)
    {
        m_CurrentMoneyNum += num;
    }
}
