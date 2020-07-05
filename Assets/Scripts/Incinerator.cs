using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incinerator : MonoBehaviour
{
    float minWaitTime = 0.2f, maxWaitTime = 0.8f;
    [SerializeField]
    float m_RandomValue;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something there");
        if (other.gameObject.tag == "Book")
        {
            Destroy(other.gameObject);
            m_RandomValue = Random.Range(minWaitTime, maxWaitTime);
            StartCoroutine(TriggerRespawn());
        }

    }

    IEnumerator TriggerRespawn()
    {
        yield return new WaitForSeconds(m_RandomValue);
        FindObjectOfType<SpawnManager>().spawnBooks();
    }
}
