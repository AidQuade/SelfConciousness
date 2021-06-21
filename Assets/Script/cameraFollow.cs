using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    GameObject player;

    private bool following = true;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (following == true)
        {
            canFollow();
        }  
    }

    public void setFollow(bool val)
    {
        following = val;
    }

    void canFollow()
    {
        Vector3 newPos = new Vector3(player.transform.position.x, player.transform.position.y,
            this.transform.position.z);
        this.transform.position = newPos;
    }
}
