using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> EnemyPrefabs;

    [SerializeField] List<GameObject> EnemySpawnPoint;


    void Start()
    {
        //for (int i = 0; i < GameObject.FindGameObjectsWithTag("EnemySpawnPoint").Length; i++)
        for(int i=0; i < EnemySpawnPoint.Count; i++)
        {
            Instantiate(EnemyPrefabs[Random.Range(0, EnemyPrefabs.Count)],
                EnemySpawnPoint[i].transform.position,
                EnemySpawnPoint[i].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // vérification si un enemy est mort et le cas échéant en faire spawn un nouveau à une position aléatoire
        // pour cela on compare le nombre théorique d'enemy avec le nombre actuel
        while (EnemySpawnPoint.Count >
               GameObject.FindGameObjectsWithTag("Enemy").Length)
        {
            int RandomNumber = Random.Range(0, EnemyPrefabs.Count);
            Instantiate(EnemyPrefabs[Random.Range(0, EnemyPrefabs.Count)],
                EnemySpawnPoint[RandomNumber].transform.position,
                EnemySpawnPoint[RandomNumber].transform.rotation);
        }
    }
}
