using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    
    public Vector3 offset;


    public void targetPlayer(Transform target)
    {
        transform.parent = target;
        transform.localPosition = offset;
    }
}
