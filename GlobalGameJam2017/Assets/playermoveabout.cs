using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoveabout : MonoBehaviour
{

    public float runspeed = 60000f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0, moveZ = 0;

        moveX = Input.GetAxis("Horizontal") * runspeed;
        moveZ = Input.GetAxis("Vertical") * runspeed;

        this.transform.Translate(moveX, moveZ, 0);
    }
}
