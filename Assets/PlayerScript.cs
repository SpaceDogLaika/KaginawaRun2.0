using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float moveForce;

    private Rigidbody2D rb;

    [SerializeField]
    private Sprite[] playerSprites;

    [SerializeField]
    private Animator animator;

    public GameObject shadowEffect;
    private bool shadowEffectIsActive = false;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnJump()
    {
        Debug.Log("OnJump triggered");
        rb.AddForce(new Vector2(0, jumpForce));
    }

    void OnGrapple()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        //TODO
        // Listen for events (distance, powerup, score) and add more constant force
        // This will speed up the game over time

        if (!shadowEffect.activeSelf)
            shadowEffect.SetActive(true);

        shadowEffect.GetComponent<Animator>().keepAnimatorControllerStateOnDisable = true; //  Controls the behaviour of the Animator component when a GameObject is disabled but unsupported by older than 2018.1 versions of unity. 
        shadowEffect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
