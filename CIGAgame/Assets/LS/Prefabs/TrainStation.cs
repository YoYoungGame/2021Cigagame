using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainStation : MonoBehaviour
{



    public GameObject m_StoreUI;

    private void Awake()
    {
        m_StoreUI = transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (m_IsTrainstationOn)
        {
            if (collision.tag == "Train")
            {
                GameLevelWin();
                CloseTrainStation();
                OpenCloseUI();
            }
        }

    }



    public int m_MoneyRatio = 100;

    public void GameLevelWin()
    {
        GameManager.Instance.AddMoreMoney(GameManager.Instance.MeetTrainStation() * m_MoneyRatio);
    }



    public bool m_IsTrainstationOn = true;

    public void CloseTrainStation()
    {
        m_IsTrainstationOn = false;
        GetComponent<SpriteRenderer>().color = Color.gray;
    }



    public void OpenCloseUI()
    {
        Time.timeScale = 0;
        m_StoreUI.SetActive(true);
    }

    public void UICloseStoreUI()
    {
        Time.timeScale = 1f;
        m_StoreUI.SetActive(false);
    }

    public int m_CarriageCost = 100;
    public int m_heartCost= 100;


    public void BuyCarriage()
    {
        if (GameManager.Instance.CostMoney(m_CarriageCost))
        {
            GameManager.Instance.AddCarriage();
            Debug.Log("购买了个火车车厢");
        }
        else
        {
            Debug.Log("没钱");

        }
    }

    public void BuyHeart()
    {
        if (GameManager.Instance.CostMoney(m_CarriageCost))
        {
            GameManager.Instance.AddHeart();
            Debug.Log("购买了个一条命");

        }
        else
        {
            Debug.Log("没钱");

        }
    }


}
