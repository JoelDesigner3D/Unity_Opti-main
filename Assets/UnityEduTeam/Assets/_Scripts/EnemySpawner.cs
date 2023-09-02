using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   // [SerializeField] List<GameObject> EnemyPrefabs;
    [SerializeField] List<GameObject> EnemySpawnPoint;
   // [SerializeField] EnemiesGenerator enemiesGenerator;
    [SerializeField] EnemyPooling enemyPooling;


    void Start()
    {
 
        for(int i=0; i < EnemySpawnPoint.Count; i++)
        {
           int RandomNumber = Random.Range(0, EnemySpawnPoint.Count);

            //enemiesGenerator.Generate(EnemySpawnPoint[RandomNumber].transform.position, Quaternion.identity);
            enemyPooling.Get(EnemySpawnPoint[RandomNumber].transform.position);

        }
        
    }

    /**

    // Update is called once per frame
    void Update()
    {
        // vérification si un enemy est mort et le cas échéant en faire spawn un nouveau à une position aléatoire
        // pour cela on compare le nombre théorique d'enemy avec le nombre actuel
        
        while (EnemySpawnPoint.Count > GameObject.FindGameObjectsWithTag("Enemy").Length)
        {
            int RandomNumber = Random.Range(0, EnemySpawnPoint.Count);
            Instantiate(EnemyPrefabs[Random.Range(0, EnemyPrefabs.Count)],
                EnemySpawnPoint[RandomNumber].transform.position,
                EnemySpawnPoint[RandomNumber].transform.rotation);
        }
        
    }

    */
    
}
