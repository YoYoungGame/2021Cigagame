using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passenger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Train"))
        {
            GameManager.Instance.ChangePassengerNumber(1);
            Destroy(gameObject);
        }
    }
}
