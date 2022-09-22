using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit result;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            bool thereWasHit = Physics.Raycast(ray, out result, 100.0f);


            //Vector3 start = transform.position;
            //Vector3 end = transform.forward * 50f;
            //lineRenderer.SetPosition(0, start);
            //lineRenderer.SetPosition(1, end);
            //Make the ray visible - the debug tool doesn't work unless it has parameters which can't be provided by the current Raycast
            //Debug.DrawRay(transform.position, transform.forward * 50f, Color.red, 0.05f);

            
            if (thereWasHit)
            {

                if (result.collider.gameObject.CompareTag("player"))
                {
                    result.collider.gameObject.GetComponent<Health>().TakeDamage(1);
                }
                //result.collider.gameObject.GetComponent<MeshRenderer>().material.color = GetRandomColor();
              
            }
        }
    }
       
    private Color GetRandomColor()

        {
            Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            return color;
        }
    
}
