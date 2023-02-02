using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelForward : MonoBehaviour
{
    private float speed = 5;

    // Update is called once per frame
    void Update()
    {
        float x = 1;
        Vector3 movement = new Vector3(x, 0, 0); //only moves x-axis
        transform.Translate(movement * speed * Time.deltaTime);
        
        Debug.Log("some log");
        if (transform.position.x < -10)
        {
            Debug.Log("destroying");
            Destroy(gameObject);
        }
    }
}
