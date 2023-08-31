using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class UnitySpherePool : Pool
{
    [SerializeField] Factory spheresFactory;
    
    private IObjectPool<Transform> spheres;

    // Start is called before the first frame update
    void Start()
    {
        spheres = new ObjectPool<Transform>(CreateNewSphere, OnGettingSphere, OnReleasingSphere, OnDestroyingSphere);
    }

    private Transform CreateNewSphere()
    {
        return spheresFactory.Generate(Vector3.zero);
    }

    private void OnGettingSphere(Transform sphere)
    {
        sphere.gameObject.SetActive(true);
    }

    private void OnReleasingSphere(Transform sphere)
    {
        sphere.gameObject.SetActive(false);
    }

    private void OnDestroyingSphere(Transform sphere)
    {
        Destroy(sphere);
    }

    public override Transform Get(Vector3 position)
    {
        Transform t = spheres.Get();
        t.position = position;
        t.GetComponent<Rigidbody>().velocity = Vector3.zero;
        return t;
    }

    public override void Release(Transform element)
    {
        spheres.Release(element);
    }
}
