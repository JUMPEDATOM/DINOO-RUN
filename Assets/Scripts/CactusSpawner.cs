using System.Collections;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public GameObject[] cactusPreFabs;
    public float spawnWait;
    public float spawnMostWait = 2f;
    public float spawnLeastWait = 0.5f;
    public int startWait = 1;

    void Start ()
    {
        StartCoroutine(Spawner());
    }
    void Update ()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

        if (Ground.golobalSpeed > 10 && Ground.golobalSpeed < 15)
        {
            spawnMostWait = 1.5f;
        }
        else if (Ground.golobalSpeed > 15 && Ground.golobalSpeed < 20)
        {
            spawnMostWait = 1f;
        }
        else if (Ground.golobalSpeed > 20)
        {
            spawnWait = 0.5f;
            spawnLeastWait = 0f;
        }
    }

    IEnumerator Spawner ()
    {
        yield return new WaitForSeconds(startWait);
        
        while (true)
        {
            int randCactus = Random.Range(0, cactusPreFabs.Length);
            Instantiate(cactusPreFabs[randCactus], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
