using UnityEngine;
using System.Collections;

public class character_movement : MonoBehaviour {

	//Character Movement Settings

	// Movement Variables
	public int maxNumberOfJumps = 2;
	public float characterSpeed = 5.0f;
	public float mouseSense = 5.0f;
	public float rangeUpDown = 60.0f;
	public int jumpSpeed = 10;

	//Player Stamina
	public float playerStamina = 100;



	// Script Help
	int jumps;
	float verticalRotation = 0;
	float gravity;



	void Start () {
		Screen.lockCursor = true;

	}
	

	void Update () {

		// Movement

		float ForwardSpeed = Input.GetAxis ("Vertical") * characterSpeed;
		float SideWaysSpeed = Input.GetAxis ("Horizontal") * characterSpeed;
		if (Input.GetKey (KeyCode.LeftShift)) {
						if (playerStamina >= 1) {
								if (ForwardSpeed >= 1) {
										ForwardSpeed = ForwardSpeed * 2;
										playerStamina -= Time.deltaTime * 2;
								}
						}
				}
			else {
				if (playerStamina < 100){
					playerStamina += Time.deltaTime *1;
				}
			}
		


		Vector3 speed = new Vector3 (SideWaysSpeed, gravity, ForwardSpeed);


		speed = transform.rotation * speed;

		CharacterController cc = GetComponent<CharacterController> ();
		cc.Move (speed * Time.deltaTime);


		

		// Gravity
		gravity += Physics.gravity.y * Time.deltaTime;

		// Mouse Rotation

		// Horizontal

		float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSense;
		transform.Rotate (0, rotLeftRight, 0); 


		// Vertical

		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSense;
		verticalRotation = Mathf.Clamp (verticalRotation, -rangeUpDown, rangeUpDown);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);

		//Jump
		if (cc.isGrounded) {
			jumps = maxNumberOfJumps;
				}
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (jumps >= 1){
				gravity = jumpSpeed;
				jumps --;
			}
		}
	}
}
