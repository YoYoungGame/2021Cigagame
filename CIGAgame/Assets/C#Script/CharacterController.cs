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
        //���뷽��ʶ��
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
            //���뷽��Ϊ��ʱ���ж��Ƿ�����ƶ�
            if (CanMoveToDir(moveDir))
            {
                //�ƶ�
                Move(moveDir);
            }
        }

        //�ƶ�֮�������
        moveDir = Vector2.zero;

        //���߿��ӻ�
        Debug.DrawRay(transform.position, Vector2.right, Color.red);
        Debug.DrawRay(transform.position, Vector2.left, Color.red);
        Debug.DrawRay(transform.position, Vector2.up, Color.red);
        Debug.DrawRay(transform.position, Vector2.down, Color.red);
    }

    bool CanMoveToDir(Vector2 dir)
    {
        //���߼��
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 1f, detectLayer);

        if (!hit)
            return true;
        else
        {
            //�ƶ��������赲ʱ�ж��Ƿ�������
            if (hit.collider.GetComponent<Box>() != null)
                //�赲��Ϊ����ʱ��ִ�����ӵ����߼��
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
