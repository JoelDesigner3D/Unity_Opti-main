using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    public abstract Transform Generate(Vector3 position);
}
