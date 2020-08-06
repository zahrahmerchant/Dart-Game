using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraSwitch : MonoBehaviour
{
    public Camera fullViewCamera;
    public Camera dartViewCamera;

    public void ShowOverheadView()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fullViewCamera.enabled = false;
            dartViewCamera.enabled = true;
        }
        else
        {
            fullViewCamera.enabled = true;
        }
        
    }
}
