using UnityEngine;

public class EnemiesGenerator : NewFactory
{
    [SerializeField] private GameObject[] enemieTypes;

    public override Transform Generate(Vector3 position, Quaternion rotation)    
    {
        int nazard = Random.Range(0, enemieTypes.Length);
        GameObject enemyType = enemieTypes[nazard];

        GameObject enemy = Instantiate(enemyType);
        enemy.transform.position = position;
        enemy.transform.rotation = rotation;

        return enemy.transform;
    }
}