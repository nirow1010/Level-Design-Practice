using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class MoveLeft : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 initPos;

    public float horVel = -5;
    private bool canMove = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initPos = transform.position;
    }

    void Update()
    {
        if (canMove)
        {
            transform.position += new Vector3(horVel * Time.deltaTime, 0, 0);

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left);

            if (hit && hit.transform.gameObject.layer != 13 && hit.distance < 1f)
            {
                canMove = false;
            }
        }
    }

    public void ResetPosition()
    {
        StartCoroutine(DelayedResetPosition());
    }

    private IEnumerator DelayedResetPosition()
    {
        transform.position = initPos;
        canMove = false;
        yield return new WaitForSeconds(0.25f);
        canMove = true;
    }
}
