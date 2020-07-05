using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] bookPrefabs;


    public void spawnBooks()
    {
        
        int prefabIndex = Random.Range(0, bookPrefabs.Length);
        GameObject obj = Instantiate(bookPrefabs[prefabIndex], this.transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().isKinematic = false;
        obj.transform.SetParent(transform, worldPositionStays: true);
    }
}
