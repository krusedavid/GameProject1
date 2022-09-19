using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    private RaycastHit result;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit result;
            bool thereWasHit = Physics.Raycast(transform.position, transform.forward, out result, Mathf.Infinity);
            
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out result, 100.0f))
            
                //Make the ray visible
            Debug.DrawRay(transform.position, transform.forward * 50f, Color.red, 0.05f);

            if (thereWasHit)
            {

                result.collider.gameObject.GetComponent<MeshRenderer>().material.color = GetRandomColor();
            }
        }
    }
       
    private Color GetRandomColor()

        {
            Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            return color;
        }
    
}
