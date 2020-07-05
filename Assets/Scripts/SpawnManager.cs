using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] bookPrefabs;
    public AudioClip bookSpawn;

    public void spawnBooks()
    {
        FindObjectOfType<AudioManager>().PlaySound(bookSpawn);
        int prefabIndex = Random.Range(0, bookPrefabs.Length);
        GameObject obj = Instantiate(bookPrefabs[prefabIndex], this.transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().isKinematic = false;
        obj.transform.SetParent(transform, worldPositionStays: true);
    }
}
