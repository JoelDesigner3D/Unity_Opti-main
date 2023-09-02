using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : NewPool

{
    [SerializeField] NewFactory enemiesGenerator;

    private List<GameObject> enemiesReferences;

    private void Start()
    {
        enemiesReferences = new List<GameObject>();
    }

    public override GameObject Get(Vector3 position)
    {
        // V?rifier si une sph?re est disponible
        foreach (GameObject go in enemiesReferences)
        {
            if (!go.activeInHierarchy)
            {
                go.SetActive(true);
                go.transform.position = position;
                go.GetComponent<Rigidbody>().velocity = Vector3.zero;
                return go;
            }
        }

        // Si aucune n'est disponible, on doit en g?n?rer une nouvelle

        GameObject newEnemy = enemiesGenerator.Generate(position, Quaternion.identity);
        enemiesReferences.Add(newEnemy);
        return newEnemy;
    }

    public override void Release(GameObject element)
    {
        element.gameObject.SetActive(false);
    }
}