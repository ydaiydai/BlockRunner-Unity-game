using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.position + offset;

        //For fixed camera, follows player but not on x
        transform.position = new Vector3(0, player.position.y, player.position.z) + offset;
    }
}
