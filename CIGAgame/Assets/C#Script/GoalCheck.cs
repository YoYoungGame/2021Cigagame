using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Goal"))
        {
            GameObject.FindGameObjectWithTag("MenuUI").GetComponent<MenuUIInGame>().GamePass();
        }
    }
}
