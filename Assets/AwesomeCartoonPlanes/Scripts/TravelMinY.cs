using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelMinY : MonoBehaviour
{
    private float speed = 10;

    // Update is called once per frame
    void Update()
    {
        float minY = -1;
        Vector3 movement = new Vector3(0, minY, 0); //only moves y-axis
        transform.Translate(movement * speed * Time.deltaTime);

        if (transform.position.y < -50)
        {
            Destroy(gameObject);
        }
    }
}
