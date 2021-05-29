/// <summary>
/// The superclass object that units (such as the player, enemies, and towers) will inherit.
/// </summary>

namespace OurVideoGame
{
	using System;
	using UnityEngine;
	public class Unit_Object : MonoBehaviour
	{
		private double unitAttackDamage;
		private double unitCurrentHealth;
		private double unitMaxHealth;

		public Unit_Object(double newAttackDamage, double newMaxHealth)
		{
			this.unitAttackDamage = newAttackDamage;
			this.unitMaxHealth = newMaxHealth;
			this.unitCurrentHealth = newMaxHealth;
		}

		public double AttackDamage
		{
			get => this.unitAttackDamage;
			set => this.unitAttackDamage = value;
		}

		public double CurrentHealth
		{
			get => this.unitCurrentHealth;
			set => this.unitCurrentHealth = value;
		}

		public double MaxHealth
		{
			get => this.unitMaxHealth;
			set => this.unitMaxHealth = value;
		}

		// Create an attack_object and throw it into the world.
		void Unit_Attack()
		{
		}
	}
}