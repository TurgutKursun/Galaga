using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlaneSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyPlanes());
    }

    IEnumerator SpawnEnemyPlanes()
    {
        while (true)
        {
            Instantiate(prefabs[0], new Vector3(Random.Range(-17, 25), 15, 0), Quaternion.Euler(0, 180, 0));
            float waitTime = Random.Range(1, 4);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
