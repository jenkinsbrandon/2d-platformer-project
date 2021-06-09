/// <summary>
/// The superclass object that units (such as the player, enemies, and towers) will inherit.
/// </summary>

namespace OurVideoGame
{
	using System;
	using UnityEngine;

	public class TowerObject : Unit_Object
    {
        double movespeedModifier;
        private Vector3 towerProjectileStart;
        public ProjectileFireTest testPFT;
        private double minimumTowerProximity;
        public Vector3 spawnPosition;

        public GameObject towerPrefab;

        public TowerObject(double newAttackDamage, double newMaxHealth, double pminimumTowerProximity, GameObject ptowerPrefab) : base(newAttackDamage, newMaxHealth)
        {
            this.movespeedModifier = 0;
            this.minimumTowerProximity = pminimumTowerProximity;
            this.towerPrefab = ptowerPrefab;
        }

        public double MinimumTowerProximity
		{
			get => this.minimumTowerProximity;
			set => this.minimumTowerProximity = value;
		}

        public void SpawnTower( Vector3 pspawnPosition )
        {
            Instantiate(towerPrefab, pspawnPosition, Quaternion.identity);
            spawnPosition = pspawnPosition;
        }

        public override void Unit_Attack()
        {

        }

    }

    

}