using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit result;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            bool thereWasHit = Physics.Raycast(ray, out result, 100.0f);



            //Make the ray visible - the debug tool doesn't work unless it has parameters which can't be provided by the current Raycast
            //Debug.DrawRay(transform.position, transform.forward * 50f, Color.red, 0.05f);

            
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
