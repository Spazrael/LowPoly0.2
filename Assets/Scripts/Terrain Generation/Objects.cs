using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{   
    
    private IEnumerator coroutine;
    void Start()
    {
        coroutine = checkCollide(0.5f);
        StartCoroutine(coroutine);
    }
    IEnumerator checkCollide(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        float objectY = Random.Range(50,99);
        RaycastHit hit;
        // if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, Mathf.Infinity))
        if (Physics.Raycast(transform.position, -Vector3.up, out hit, Mathf.Infinity) && !(Physics.Raycast(transform.position, -Vector3.up, out hit, 48.0f)))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * 1000, Color.green,100);
            
            // Debug.Log("Did Hit " + transform.position);
        }
		else{
            Destroy(transform.gameObject);
			// Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * 1000, Color.red,100);
			// Debug.Log("Didnt Hit " + transform.position);
		}

    }
}