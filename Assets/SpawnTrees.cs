using UnityEngine;
using System.Collections;

public class SpawnTrees : MonoBehaviour {
	public Transform tree;
	public int spawnsLeft;
	public int mapHeight;
	public int mapWidth;
	public float heightOfset;

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
		Vector3 position = new Vector3(Random.Range(mapWidth*3, -mapWidth*3 ), heightOfset, Random.Range(mapHeight*3, -mapHeight*3 ));
		Instantiate (tree, position, Quaternion.identity);
		spawnsLeft -= 1;

		if (spawnsLeft >= 1) {
			spawnTrees();
				}
	}
}
