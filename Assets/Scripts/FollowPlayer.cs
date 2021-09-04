using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0f, 3.6f, -8.9f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Transform camera's postion
        //Add an offset to move the camera behind the player
        transform.position = player.transform.position + offset;
        
    }
}
