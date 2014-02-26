using UnityEngine;
using System.Collections;

public class DestroyProjectile : MonoBehaviour {
	float lifeSpan = 10;

	void Update ()
	{
		lifeSpan -= Time.deltaTime * 1;

		if (lifeSpan <= 0) {
			Destroy(gameObject);
				}
	}

	void OnCollisionEnter ()
	{
		Destroy(gameObject);
	}
}
