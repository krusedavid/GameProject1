using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    private static PickUpManager instance;
    [SerializeField] GameObject pickupPrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public static PickUpManager GetInstance()
    {
        return instance;
    }

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.LeftShift))
        {

        }

       
    }
}
