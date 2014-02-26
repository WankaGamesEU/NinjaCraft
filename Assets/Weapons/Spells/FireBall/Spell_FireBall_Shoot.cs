using UnityEngine;
using System.Collections;

public class Spell_FireBall_Shoot : MonoBehaviour {
	public Rigidbody fireBall;
	public Rigidbody fireBallHold;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Rigidbody clone;
			clone = Instantiate(fireBall, transform.position, transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection( Vector3.forward * 30);
				}
	
	}
}
