using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] platfPrefabs;
    [SerializeField] private int startPlatf;
    [SerializeField] private Transform player;
    private List<GameObject> existingPlatf = new List<GameObject>();
    private float spawnPoint = 0f;
    private float platfLength = 50f;
    
    private void Start()
    {
        StartsSpawn();
    }
    private void Update()
    {
        TrackingPlayer();
    }

    private void TrackingPlayer()
    {
        if (player.position.z - platfLength * 2f > spawnPoint - (startPlatf * platfLength))
        {
            SpawnPlatforms(Random.Range(0, platfPrefabs.Length));
            SpawnPlatforms(Random.Range(0, platfPrefabs.Length));
            DeleteTile();
            DeleteTile();
        }
    }

    private void StartsSpawn()
    {
        for (int i = 0; i < startPlatf; i++)
        {
            SpawnPlatforms(Random.Range(0, platfPrefabs.Length));
        }
    }



    private void SpawnPlatforms(int indexPlatform)
    {
        GameObject nextPlatf = Instantiate(platfPrefabs[indexPlatform], transform.forward * spawnPoint, transform.rotation);
        existingPlatf.Add(nextPlatf);
        spawnPoint += platfLength;
    }
    private void DeleteTile()
    {
        Destroy(existingPlatf[0]);
        existingPlatf.RemoveAt(0);
    }
}
