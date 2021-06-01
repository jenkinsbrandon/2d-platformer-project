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
		Rigidbody2D objRigidbody;
		private Sprite dmgObjSprite;

        private void Start()
		{ 
			dmgObjSprite = Resources.Load("Assets/Materials/DamageObjectSprite") as Sprite;
        }

        private void Update()
        {
			objRigidbody.AddForce(Vector3.up * 10 * Time.deltaTime);
        }

        public Damage_Object(double newObjectDamageValue)
		{
			this.objDmgVal = newObjectDamageValue;
		}
	}
}
