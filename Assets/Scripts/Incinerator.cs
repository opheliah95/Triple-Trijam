using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incinerator : MonoBehaviour
{
    public AudioClip burningSound;
    float minWaitTime = 1f, maxWaitTime = 3f;
    [SerializeField]
    float m_RandomValue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Book")
        {
            Destroy(other.gameObject);
            FindObjectOfType<AudioManager>().PlaySound(burningSound);
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
