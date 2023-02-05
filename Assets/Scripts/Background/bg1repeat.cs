using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg1repeat : MonoBehaviour
{

    Vector3 strarPosition;
    float width;
    // Start is called before the first frame update
    void Start()
    {
        strarPosition = transform.position;
        width = GetComponent<BoxCollider2D>().size.x /2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < strarPosition.x - width) {
            transform.position = strarPosition;
        }
    }
}
