using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Xml.Serialization;
using UnityEngine;

public class CamBob : MonoBehaviour
{
    public Animator cameraAnim;
    public bool walking;
    private void Update()
    {
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {
            walking = true;
            cameraAnim.ResetTrigger("idle");
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.SetTrigger("walk");
            if (walking == true)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    cameraAnim.ResetTrigger("walk");
                    cameraAnim.ResetTrigger("idle");
                    cameraAnim.SetTrigger("sprint");
                }
            }
        }
        else
        {
            cameraAnim.ResetTrigger("walk");
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.SetTrigger("idle");
            walking = false;
        }
    }
}
