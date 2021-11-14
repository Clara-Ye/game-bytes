using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Rigidbody2D obstacle;
    public Vector2 velocity = Vector2.down * 3;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = gameObject.GetComponent<Rigidbody2D>();
        obstacle.velocity = Vector2.down * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
