using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class Shooting : MonoBehaviour
{
    public GameObject[] prefabs;
    public AudioSource shotAudio;

    private void Start()
    {
        StartCoroutine(ShootLoop());
    }

    IEnumerator ShootLoop()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                shotAudio.Play();
                Instantiate(prefabs[0], gameObject.transform.position, Quaternion.identity);
            }

            yield return new WaitForSeconds(0.2f);
        }
        
    }
}
