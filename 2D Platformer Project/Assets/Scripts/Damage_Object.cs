/// <summary>
/// This class handles damage objects (example projectiles)
/// </summary>

namespace OurVideoGame 
{
	using System;
	using System.Collections;
	using UnityEngine;

	public class Damage_Object : MonoBehaviour
	{
		double objDmgVal;
		private float projectileSpeed = 20f;
		private Rigidbody2D dmgObjRB;

        private void Start()
		{
			dmgObjRB.velocity = transform.right * projectileSpeed + transform.up * projectileSpeed;
        }

        private void OnTriggerEnter2D(Collider2D hitInfo)
        {
			Debug.Log(hitInfo.name);
			Destroy(gameObject);
        }

        public Damage_Object(double newObjectDamageValue)
		{
			this.objDmgVal = newObjectDamageValue;
		}
	}
}
