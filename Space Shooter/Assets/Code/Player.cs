using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Player : MonoBehaviour
{
    public int points;

    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
