using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewPlatform : MonoBehaviour
{
    public GameObject[] platforms;
    public float ySpace, zSpace;
    bool isSpawned = false;
    float destroyTime = 30f;
    Score score;
    private void Start()
    {
        score = FindAnyObjectByType<Score>(); 
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && !isSpawned)
        {
            isSpawned = true;
            Transform parent = gameObject.transform.parent;
            Destroy(gameObject, destroyTime);
            int randomPlatform = Random.Range(0, platforms.Length);
            Instantiate(platforms[randomPlatform], new Vector3(transform.position.x, transform.position.y - ySpace, transform.position.z + zSpace), Quaternion.identity);
        }
    }
}
