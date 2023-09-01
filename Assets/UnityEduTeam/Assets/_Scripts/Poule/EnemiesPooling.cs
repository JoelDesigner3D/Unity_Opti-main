using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;


public class EnemiesPooling : MonoBehaviour
{

    [SerializeField] NewFactory enemiesFactory;

    private IObjectPool<Transform> enemies;

    // Start is called before the first frame update
    void Start()
    {
       // enemies = new ObjectPool<Transform>(CreateNewSphere, OnGettingSphere, OnReleasingSphere, OnDestroyingSphere);
    }

   

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
