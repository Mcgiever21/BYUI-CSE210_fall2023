using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace GaussLaw
{
class Program
{
	
    static void Main(string[] args)
    {
		int type = 0;
        Console.WriteLine("Hello FinalProject World!");
		Repository repo = new();
		(double charge, int shotCount) = repo.Caller();
		Battery batt = new();
		batt.ChargerSet(charge);
		int ex = 3;
		do{(ex, charge, shotCount, type) = Menu(charge, shotCount, type);}while(ex == 3);
		repo.Saver(charge, shotCount);

    }
	public static (int, double, int, int) Menu(double charge, int shotCount, int type)
	{
		Shoot sho = new();
		Repository repo = new();
		int ender = 3;
		printer($@"
		Current Charge {charge}
		Current shots available {shotCount}
		1. Load ammunition type 1 (capacity 25)
		2. Load ammunition type 2 (capacity 25)
		3. Load ammunition type 3 (capacity 25)
		4. Load ammunition type 4 (capacity 25)
		5. Load full Battery
		6. quit sim
		7. view recorded fireing time (time from trigger to end of final stage)
		8. fire burst mode
		9. fire single mode
		");
		switch(int.Parse(Console.ReadLine()))
		{
			case 1:
				type = 1;
				shotCount = 25;
				break;
			case 2:
				type = 2;
				shotCount = 25;
				break;
			case 3:
				type = 3;
				shotCount = 25;
				break;
			case 4:
				type =4;
				shotCount = 25;
				break;
			case 5:
				charge = 100;
				break;
			case 6: 
				ender = 4;
				break;
			case 7:
				repo.FSR();
				break;
			case 8:
				(shotCount, charge) = sho.Burst(shotCount, charge, type);
				break;
			case 9:
				(shotCount, charge) = sho.Single(shotCount, charge, type);
				break;
		}
		return(ender, charge, shotCount, type);

	}

	static void printer(string v)
    {
        Console.WriteLine(v);
    }
    static string Reader()
    {
        var v = Console.ReadLine();
        return v;
    }
}
}
