using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
        {
	// Hero Information:
			String heroName = Batman;
			int  heroSuperPower = 1000;

	//Villain Information:
			String villainName = Joker;
			int vililanHeight = 180;
			int villainSuperPower =950;

			//for function SetSpeed:
			float playerSpeed = 1.5f;


	//Compare btween the Hreo and the villain Names...
			if (heroName == villainName)
            {
				Console.WriteLine("the Hero and the Villain has the same name ...");
			}
			else 
			{
				Console.WriteLine("the Hero and the Villain Dont have the same name ...");
			}

	//Compare btween the Hreo and the villain Power...
			if (heroSuperPower == villainSuperPower)
			{
				Console.WriteLine("the Hero and the Villain has the same Power ...");
			}
			else if (heroSuperPower > villainSuperPower)
			{
				Console.WriteLine("the Hero has higher power than the Villain ...");
			}

			else
			{
				Console.WriteLine("the Villain has higher power than the Hero ...");

			}
	//print the old value of the player speed :
			Console.WriteLine("\n the old value of the player Speed  =  " + playerSpeed);
	//Call Functions:
			SetSpeed(2.5);

	//Function (SetSpeed )
			void SetSpeed(playerSpeed)
            {
				Console.WriteLine("\n the new value of the player Speed  =  " + playerSpeed);

			}
	// Function(CompareSpeed )
			void CompareSpeed( heroSuperPower ,  villainSuperPower)
			{
				//Compare btween the Hreo and the villain Power...
				if (heroSuperPower == villainSuperPower)
				{
					Console.WriteLine("the Hero and the Villain has the same Power ...");
				}
				else if (heroSuperPower > villainSuperPower)
				{
					Console.WriteLine("the Hero has higher power than the Villain ...");
				}

				else
				{
					Console.WriteLine("the Villain has higher power than the Hero ...");

				}
				

			}


		}
	}
}
