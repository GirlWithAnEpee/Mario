using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // стрелка вверх или w - прыжок
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode2D.Impulse);
        } else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            Vector3 scale = transform.localScale;
            Debug.Log("1 left" + scale.x);
            if (scale.x > 0)
            {
                scale.x = -scale.x;
                transform.localScale = scale;
            }
            Debug.Log("2 left" + scale.x);
            transform.position = transform.position - new Vector3(2.0f, 0, 0);
        } else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Vector3 scale = transform.localScale;
            Debug.Log("1 right" + scale.x);
            if (scale.x < 0)
            {
                scale.x = -scale.x;
                transform.localScale = scale;
            }
            Debug.Log("2 right" + scale.x);
            transform.position = transform.position + new Vector3(2.0f, 0, 0);
        }
    }
}
