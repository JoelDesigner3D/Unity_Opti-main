using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeSpawner : MonoBehaviour {

    public List<GameObject> Modules = new List<GameObject>();  // prefabs

    private List<GameObject> SpawnPoints = new List<GameObject>(); // GO

    private List<GameObject> MazeModules = new List<GameObject>(); // instances

	// Use this for initialization
	void Start () {
        
        SpawnPoints.AddRange(GameObject.FindGameObjectsWithTag("ModuleLoc"));

        foreach (GameObject SpawnPoint in SpawnPoints)
        {
            MazeModules.Add(Instantiate(Modules[Random.Range(0, Modules.Count)], SpawnPoint.transform.position, Quaternion.identity));
        }
	}
}
