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
        SceneManager.LoadScene("StartMenu");

    }
    public void RePlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLeavel()
    {
        string nextLevelName = SceneManager.GetActiveScene().name;
        nextLevelName = nextLevelName.Replace(nextLevelName[nextLevelName.Length - 1], (char)(nextLevelName[nextLevelName.Length - 1] + 1));
        if (SceneManager.GetSceneByName(nextLevelName) != null)
        {
            SceneManager.LoadScene(nextLevelName);

        }
        else
        {

            Debug.LogError("还没有对应的场景");

        }
    }
}
