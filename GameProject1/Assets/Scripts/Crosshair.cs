using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Input.mousePosition;
    }
}
