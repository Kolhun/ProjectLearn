using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraInStep : MonoBehaviour
{
    
    public static CameraInStep main = new CameraInStep();
    public Rigidbody rig;
    public int speed = 4;

    void Awake()
    {
        main = this;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 vec = new Vector3(horizontal, 0, vertical);

        rig.MovePosition(rig.position + vec * speed * Time.deltaTime);

    }


}
