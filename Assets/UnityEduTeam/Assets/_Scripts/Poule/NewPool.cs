using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NewPool : MonoBehaviour
{
    public abstract GameObject Get(Vector3 position);
    public abstract void Release(GameObject gameObject);
}
