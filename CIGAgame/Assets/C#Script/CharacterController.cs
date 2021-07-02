using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Vector2 moveDir;
    public LayerMask detectLayer;

    // Update is called once per frame
    void Update()
    {
        //输入方向识别
        if (Input.GetKeyDown(KeyCode.RightArrow))
            moveDir = Vector2.right;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            moveDir = Vector2.left;

        if (Input.GetKeyDown(KeyCode.UpArrow))
            moveDir = Vector2.up;

        if (Input.GetKeyDown(KeyCode.DownArrow))
            moveDir = Vector2.down;

        if(moveDir != Vector2.zero)
        {
            //输入方向不为空时，判断是否可以移动
            if (CanMoveToDir(moveDir))
            {
                //移动
                Move(moveDir);
            }
        }

        //移动之后方向归零
        moveDir = Vector2.zero;

        //射线可视化
        Debug.DrawRay(transform.position, Vector2.right, Color.red);
        Debug.DrawRay(transform.position, Vector2.left, Color.red);
        Debug.DrawRay(transform.position, Vector2.up, Color.red);
        Debug.DrawRay(transform.position, Vector2.down, Color.red);
    }

    bool CanMoveToDir(Vector2 dir)
    {
        //射线检测
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 1f, detectLayer);

        if (!hit)
            return true;
        else
        {
            //移动方向有阻挡时判断是否是箱子
            if (hit.collider.GetComponent<Box>() != null)
                //阻挡物为箱子时，执行箱子的射线检测
                return hit.collider.GetComponent<Box>().CanMoveToDir(dir);
            else
                return false;
        }

    }

    private void Move(Vector2 dir)
    {
        transform.Translate(dir);
    }
}
