using UnityEngine;
using System.Collections;

public class Turbine_Spinn : MonoBehaviour {
	public int timeSpeed = 5;

	// Update is called once per frame
	void Update () {
	
		transform.Rotate (Vector3.up * timeSpeed * Time.deltaTime);
	}
}
