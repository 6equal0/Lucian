using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAim : MonoBehaviour
{
    private Vector2 minPos;
    private Vector2 maxPos;

    private float x;
    private float y;
    
    [SerializeField] float speed=8;

    private void Start()
    {
        minPos = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        maxPos = Camera.main.ViewportToWorldPoint(new Vector2(0.5f, 1));
    }
    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y, 0).normalized * speed * Time.deltaTime;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPos.x, maxPos.x),
            Mathf.Clamp(transform.position.y, minPos.y, maxPos.y), 0);
    }
}
