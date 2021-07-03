using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void LoadScene(GameObject buttonThis)
    {

        if (buttonThis.GetComponentInChildren<Text>())
        {
            string levelName = buttonThis.GetComponentInChildren<Text>().text;
            if (SceneManager.GetSceneByName(levelName)!= null)
            {
                SceneManager.LoadScene(levelName);

            }
            else
            {
                Debug.LogError("还没有对应的场景");

            }
        }
        else
        {
            Debug.LogError("按钮出错。没有对应的text组件");
        }
    }
}
