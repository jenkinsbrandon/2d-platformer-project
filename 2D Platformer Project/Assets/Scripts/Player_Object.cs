namespace OurVideoGame
{
	using System;
    using UnityEngine;

    public class Player_Object : Unit_Object
	{
		double movespeedModifier;
		Weapon_Object = currentWeapon;

		public Player_Object(double newAttackDamage, double newMaxHealth) : base(newAttackDamage, newMaxHealth)
		{
			// Means a unit will move at 100% of the base normal speed.
			this.movespeedModifier = 1;
		}

		public double MovespeedModifier
		{
			get => this.movespeedModifier;

			set => this.movespeedModifier = value;
		}

        private void Update()
        {
            if (Input.GetKeyDown("space"))
            {
				Unit_Attack();
            }
        }

        public override void Unit_Attack()
        {

        }
	}
}