using UnityEngine;

public abstract class NewFactory : MonoBehaviour
{
    public abstract GameObject Generate(Vector3 position, Quaternion rotation);
}
