using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;

    }

    public int passengerNumber;
    public int m_CurrentMoneyNum = 0;
    public int m_CurrentHeart = 1;



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


    public void AddMoreMoney( int num)
    {
        m_CurrentMoneyNum += num;
    }

    public bool CostMoney(int num)
    {
        if(num <= m_CurrentMoneyNum)
        {
            m_CurrentMoneyNum -= num;
            return true;

        }
        else
        {
            return false;
        }
    }


    /// <summary>
    /// 增加车厢的方法。
    /// </summary>
    public void  AddCarriage()
    {
        Debug.Log("增加 了个新的车厢");
    }

    /// <summary>
    /// 增加血量的方法
    /// </summary>
    public void AddHeart()
    {
        m_CurrentHeart += 1;
    }

}
