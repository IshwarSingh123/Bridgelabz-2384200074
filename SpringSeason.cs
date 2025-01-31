using System;
class SpringSeason
{
	
	public bool IsSpringSeason(int month,int day)
	{
		bool isSpring = false;
		if(month ==3 && day>=20 && day <=31 )
		{
			isSpring = true;
		}
		else if (month == 4 && day >= 1 && day <= 30)
        {
            isSpring = true;
        }
        else if (month == 5 && day >= 1 && day <= 31)
        {
            isSpring = true;
        }
        else if (month == 6 && day >= 1 && day <= 20)
        {
            isSpring = true;
        }
	return isSpring;
		
	}
	
	
	static void Main(string[] args)
	{
		if(args.Length!=2)
		{
			Console.WriteLine("Please provide exactly two arguments: month and day.");
			return;
		}
		
		int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);
		
		SpringSeason season = new SpringSeason();
		bool isSpring = season.IsSpringSeason(month,day);
		
		if(isSpring==true){
			Console.WriteLine("It's a Spring Season");
		}
		else{
			Console.WriteLine("It's not a Spring Season");
		}
		
		
	}
	
}