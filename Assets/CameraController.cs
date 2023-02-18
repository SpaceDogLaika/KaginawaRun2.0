using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerScript thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMoveX;
    private float distanceToMoveY;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerScript>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMoveX = thePlayer.transform.position.x - lastPlayerPosition.x;
        distanceToMoveY = thePlayer.transform.position.y - lastPlayerPosition.y;

        transform.position = new Vector3(transform.position.x + distanceToMoveX, transform.position.y, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;

    }
}
