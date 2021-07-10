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
    /// ���ӳ���ķ�����
    /// </summary>
    public void  AddCarriage()
    {
        Debug.Log("���� �˸��µĳ���");
    }

    /// <summary>
    /// ����Ѫ���ķ���
    /// </summary>
    public void AddHeart()
    {
        m_CurrentHeart += 1;
    }

}
