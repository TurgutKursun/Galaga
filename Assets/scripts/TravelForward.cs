using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelForward : MonoBehaviour
{
    public float speed = 20;

    // Update is called once per frame
    void Update()
    {
        float y = 1;
        Vector3 movement = new Vector3(0, y, 0); //only moves y-axis
        transform.Translate(movement * speed * Time.deltaTime);

        if (transform.position.y > 20)
        {
            Destroy(gameObject);
        }
    }
}
