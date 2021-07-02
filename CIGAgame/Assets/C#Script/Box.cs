using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public LayerMask detectLayer;
    void Update()
    {
        Debug.DrawRay(transform.position + (Vector3)Vector2.right * 0.3f, Vector2.right*0.5f, Color.red);
        Debug.DrawRay(transform.position + (Vector3)Vector2.left * 0.3f, Vector2.left * 0.5f, Color.red);
        Debug.DrawRay(transform.position + (Vector3)Vector2.up * 0.3f, Vector2.up * 0.5f, Color.red);
        Debug.DrawRay(transform.position + (Vector3)Vector2.down * 0.3f, Vector2.down * 0.5f, Color.red);
    }
    public bool CanMoveToDir(Vector2 dir)
    {
        //箱子的射线检测
        RaycastHit2D hit = Physics2D.Raycast(transform.position + (Vector3)dir * 0.3f, dir, 0.5f, detectLayer);
        if (!hit)
        {
            //无阻挡时移动，并返回true
            transform.Translate(dir);
            return true;
        }
        else
            return false;
    }
}
