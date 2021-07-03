using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIInGame : MonoBehaviour
{
    public GameObject PauseUI;
    public GameObject PassUI;

    public void GamePause()//调用以切换游戏暂停UI的显示状态
    {
        if (PauseUI.activeInHierarchy || PassUI.activeInHierarchy)
            PauseUI.SetActive(false);
        else
            PauseUI.SetActive(true);
    }
    public void GamePass()//调用以切换游戏过关后UI的显示状态
    {
        if (PassUI.activeInHierarchy || PauseUI.activeInHierarchy)
            PassUI.SetActive(false);
        else
            PassUI.SetActive(true);
    }
    public void BackToMainMenu()
    {

    }
    public void RePlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLeavel()
    {

    }
}
