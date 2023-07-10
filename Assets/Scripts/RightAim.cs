using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAim : MonoBehaviour
{
    private Vector2 minPos;
    private Vector2 maxPos;

    private void Start()
    {
        minPos = Camera.main.ViewportToWorldPoint(new Vector2(0.5f, 0));
        maxPos = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
    }
    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPos.x, maxPos.x),
            Mathf.Clamp(transform.position.y, minPos.y, maxPos.y), 0);
    }
}
