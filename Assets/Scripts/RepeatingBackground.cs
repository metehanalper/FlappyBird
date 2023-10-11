using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D groundCollider;
    private float groundLength;

    // Start is called before the first frame update
    void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundLength = groundCollider.size.x; // 20,48

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundLength)
        {
            Vector2 offset = new Vector2(2 * groundLength, 0);
            transform.position = (Vector2) transform.position + offset;

        }
    }
}
