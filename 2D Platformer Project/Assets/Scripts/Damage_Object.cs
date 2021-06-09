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
		public float projectileSpeed = 20f;
		public Rigidbody2D dmgObjRB;
		// double objDmgVal;

		private void Start()
		{
			dmgObjRB.velocity = transform.right * projectileSpeed; // + transform.up * projectileSpeed;
        }

       /* public Damage_Object(double newObjectDamageValue)
		{
			this.objDmgVal = newObjectDamageValue;
		}*/
	}
}
