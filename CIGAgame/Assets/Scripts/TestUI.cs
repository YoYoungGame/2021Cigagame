using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI : MonoBehaviour
{
    public MenuUIInGame MenuUI;
    // Start is called before the first frame update
    void Start()
    {
        MenuUI = GameObject.FindGameObjectWithTag("MenuUI").GetComponent<MenuUIInGame>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            MenuUI.GamePass();
        if (Input.GetKeyDown(KeyCode.Escape))
            MenuUI.GamePause();
    }
}
