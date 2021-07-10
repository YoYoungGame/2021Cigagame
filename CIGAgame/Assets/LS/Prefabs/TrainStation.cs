using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainStation : MonoBehaviour
{

    public GameManager m_GameManager;

    public GameObject m_StoreUI;

    private void Awake()
    {
        m_GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
        m_GameManager.AddMoreMoney(m_GameManager.MeetTrainStation() * m_MoneyRatio);
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

    public void BuyCarriage()
    {
        
    }

    public void BuyHeart()
    {
        
    }


}
