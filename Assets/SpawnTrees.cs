using UnityEngine;
using System.Collections;

public class SpawnTrees : MonoBehaviour {
	public Transform tree;
	public int spawnsLeft = 10;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnsLeft >= 1) {
						spawnTrees ();

				}
	}

	void spawnTrees () {
		Vector3 position = new Vector3(Random.Range(25.0F, -25.0F), 1, Random.Range(25.0F, -25.0F));
		Instantiate (tree, position, Quaternion.identity);
		spawnsLeft -= 1;

		if (spawnsLeft >= 1) {
			spawnTrees();
				}
	}
}
