using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject GameStoreUI;
    public GameObject GameInformationUI;
    public GameObject PauseUI;
    public GameObject GameWinUI;
    public Text moneyTxt;
    public Text scoreTxt;
    public Text stationname;
    public Image[] LifeUI = new Image[10];
    public Sprite FullLife, EmptyLife;

    private void Start()
    {

    }



    public void MoneyUICtr(int money)//调用以更新金币数量的UI显示
    {
        moneyTxt.text = ""+money;
    }
    public void ScoreTxt(int score)//调用以显示得分UI
    {
        scoreTxt.text = "你运载了" + score + "个乘客！";
    }
    public void LifeUICtr(int currentlife,int maxlife,int toplife)//调用以更新生命值的UI显示，currentlife为当前生命值。maxlife为当前生命值上限。toplife为游戏最大生命值上限，不要设置超过10。
    {
        for(int i=0;i+1<=toplife;i++)
        {
            if(i+1<=currentlife)
            {
                LifeUI[i].sprite = FullLife;
                LifeUI[i].color = Color.white;
            }
            if(i+1>currentlife&&i+1<=maxlife)
            {
                LifeUI[i].sprite = EmptyLife;
                LifeUI[i].color = Color.white;
            }
            if(i+1>maxlife)
            {
                LifeUI[i].color = Color.clear;
            }
        }
    }
    public void GameWinUICtr(string name)//调用以显示到达车站的UI，并在3秒后自动消失
    {
        GameWinUI.SetActive(true);
        stationname.text = "恭喜你到达了" + name + "车站";
        StartCoroutine(CountDown());
    }
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(3f);
        GameWinUI.SetActive(false);
        StopAllCoroutines();
        
    }










    public void StoreClose()//关闭商店窗口UI
    {
        GameStoreUI.SetActive(false);
    }
    public void PauseOpen()//暂停游戏并显示暂停UI
    {
        Time.timeScale = 0;
        PauseUI.SetActive(true);
    }
    public void PauseOff()//取消暂停游戏并关闭暂停UI
    {
        Time.timeScale = 1;
        PauseUI.SetActive(false);
    }

    public void InformationUIOpen()// 打开人员信息窗口
    {
        GameInformationUI.SetActive(true);
    }
    public void InformationUIClose()//关闭人员信息窗口
    {
        GameInformationUI.SetActive(false);
    }
    public void GameEnd()//游戏结束
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#else

     Application.Quit();

#endif

    }






    
    public void StoreOpen()//打开商店界面
    {
        GameStoreUI.SetActive(true);
    }
    public void AddLife()
    {

    }
    public void AddTrain()
    {

    }
    public void GameStart()//主菜单开始游戏
    {

    }
    public void BackToMainMenu()//返回主菜单
    {

    }
    public void Replay()//重玩游戏
    {

    }
}
