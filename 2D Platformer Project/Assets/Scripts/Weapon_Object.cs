

namespace OurVideoGame
{
    using System;
    using UnityEngine;
    class Weapon_Object : MonoBehaviour
    {
        public Transform firePoint;
        //public GameObject bulletPrefab;
        public GameObject towerPrefab;
        public float weaponDamage;

        private void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                ShootWeapon();
            }
        }

        private void ShootWeapon()
        {
            //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
