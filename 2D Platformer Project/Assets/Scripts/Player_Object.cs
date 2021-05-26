public class Player_Object : Unit_Object
{
	using System;

	double movespeedModifier;

	public Player_Object() : base()
	{
		// Means a unit will move at 100% of the base normal speed.
		this.movespeedModifier = 100.0;	
	}

	public double MovespeedModifier
    {
		get => this.movespeedModifier;

		set => this.movespeedModifier = value;
    }
}