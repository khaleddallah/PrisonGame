using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 40.0f;
    
    Vector2 moveVelocity;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        rb=GetComponent<Rigidbody2D>();
        cam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        moveVelocity = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
        // moveVelocity = cam.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));

    }


    void FixedUpdate() {
        rb.MovePosition(moveVelocity);
    }



}
