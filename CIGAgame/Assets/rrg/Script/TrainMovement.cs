using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float trainSpeed;
    public GameObject railway;
    public Vector2 fowardDirection;
    public Vector2 circleDirection;

    private bool moveAround;
    private Vector2 fowardDirectionBefore;
    private float Clockwise;

    void Start()
    {
        moveAround = true;
        Clockwise = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveAround = false;
        }

        if (moveAround) { 
            transform.RotateAround(railway.transform.position, new Vector3(0, 0, -1* Clockwise), trainSpeed *20* Time.deltaTime);

            circleDirection = (Vector2)railway.transform.position - (Vector2)transform.position;
            fowardDirection = Vector2.Perpendicular(circleDirection) * Clockwise;
            Debug.DrawRay(transform.position, circleDirection, Color.red);
            Debug.DrawRay(transform.position, fowardDirection, Color.cyan);
            Debug.DrawRay(transform.position, fowardDirectionBefore, Color.green);
        }
        else {
            transform.Translate(fowardDirection * trainSpeed * Time.deltaTime, Space.World);
        }
    }
    public void ChangeRailway(GameObject collision)
    {
        railway = collision.gameObject;
        moveAround = true;
        fowardDirectionBefore = fowardDirection;

        Vector2 circleDirectionTemp = (Vector2)railway.transform.position - (Vector2)transform.position;
        Vector2 fowardDirectionTemp = Vector2.Perpendicular(circleDirection);

        float angle = Mathf.Abs(Vector3.Angle(fowardDirectionBefore, fowardDirection));
        if (angle > 90)
        {
            Clockwise = -1;
        }
        else
        {
            Clockwise = 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("WallX"))
        {
            fowardDirection = new Vector2(fowardDirection.x, -1*fowardDirection.y);
        } else if(collision.gameObject.tag.Equals("WallY"))
        {
            fowardDirection = new Vector2(-1 * fowardDirection.x, fowardDirection.y);
        }
    }
}
