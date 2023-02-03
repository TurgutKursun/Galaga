using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class Shooting : MonoBehaviour
{
    public GameObject[] prefabs;
    private int count = 0;

    // Update is called once per frame
    void Update()
    {
        count += 1;
        if (Input.GetKey(KeyCode.Space) && count > 250)
        {
            count = 0;
            Instantiate(prefabs[0], gameObject.transform.position, Quaternion.identity);
        }
    }
}
