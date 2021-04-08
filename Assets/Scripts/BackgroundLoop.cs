using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private float width;
    void Awake()
    {
        BoxCollider2d backgroundCollider = GetCompenent<BoxCollider2d>();
        width = backgroundCollider.size.x; //2,48
    }

    
    void Update()
    {
        if(transform.posittion.x <= -width)
    }
}
    private void Reposittion()
    {
    Vector2 offset = new Vector2(width * 2f, 0);
    transform.posittion = (vector2)transform.posittion + offset;
    }
}