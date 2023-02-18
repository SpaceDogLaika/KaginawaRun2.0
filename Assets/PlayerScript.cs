using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float moveForce;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnJump()
    {
        Debug.Log("OnJump triggered");
        rb.AddForce(new Vector2(0, jumpForce));
    }
    // Start is called before the first frame update
    void Start()
    {
        //TODO
        // Listen for events (distance, powerup, score) and add more constant force
        // This will speed up the game over time
    }

    // Update is called once per frame
    void Update()
    {
    }
}
