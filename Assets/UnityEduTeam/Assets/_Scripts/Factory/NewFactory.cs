using UnityEngine;

public abstract class NewFactory : MonoBehaviour
{
    public abstract Transform Generate(Vector3 position, Quaternion rotation);
}
