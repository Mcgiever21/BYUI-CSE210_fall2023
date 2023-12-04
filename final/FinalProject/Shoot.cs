using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GaussLaw
{
class Shoot
{

	public (int, double) Single(int sc, double charge,int ammoType)
	{
		double cc = getShotCost(ammoType);
		Ammo1 ammo1=new();
		Ammo2 ammo2=new();
		Ammo3 ammo3= new();
		Ammo4 ammo4= new();
		do{
			string input = Console.ReadLine();
			if (input == " ")
			{
				if(sc >=1 && charge>=cc)
					{
						Repository repo = new();
						Console.WriteLine("bang\n");
						sc = sc-1;
						switch(ammoType){case 1:/*Ammo1 ammo1=new();*/repo.FSW(ammo1.FireStaging());break; case 2:/*Ammo2 ammo2=new();*/repo.FSW(ammo2.FireStaging());break;case 3:/*Ammo3 ammo3= new();*/repo.FSW(ammo3.FireStaging());break;case 4:/*Ammo4 ammo4= new();*/repo.FSW(ammo4.FireStaging());break;}
						charge = charge-cc;
						Console.WriteLine(charge);
						Console.WriteLine(sc);
						if (sc==0){Console.WriteLine("Out of ammunition\n"); /*Program.Menu();*/return(sc,charge);}
						if (charge<cc){Console.WriteLine("battery is dead\n"); return(sc,charge);}
					}
			}
			else{return(sc,charge);}
		}while(charge>cc);
		return(sc,charge);
	}
		
	public (int, double) Burst(int sc, double charge,int ammoType)
	{
		Repository repo = new();
		double cc = 1;
		Ammo1 ammo1=new();
		Ammo2 ammo2=new();
		Ammo3 ammo3= new();
		Ammo4 ammo4= new();
		switch(ammoType){case 1:/*Ammo1 ammo1=new();*/cc = ammo1.GetChargeCost();break; case 2:/*Ammo2 ammo2=new();*/ammo2.GetChargeCost();break;case 3:/*Ammo3 ammo3= new();*/ammo3.GetChargeCost();break;case 4:/*Ammo4 ammo4= new();*/ammo4.GetChargeCost();break;}
		
		do
		{
			string input = Console.ReadLine();
			if (input == " ")
			{
				if (charge!<cc){Console.WriteLine("battery needs charged\n"); return(sc,charge);}
				if(sc>=3 && charge>=cc*3)
				{
					Console.WriteLine("bang\nbang\nbang\n");
					sc = sc-3;
					charge = charge-cc*3;
					Console.WriteLine(charge);
					switch(ammoType){case 1:/*Ammo1 ammo1=new();*/repo.FSW(ammo1.FireStaging());break; case 2:/*Ammo2 ammo2=new();*/repo.FSW(ammo2.FireStaging());break;case 3:/*Ammo3 ammo3= new();*/repo.FSW(ammo3.FireStaging());break;case 4:/*Ammo4 ammo4= new();*/repo.FSW(ammo4.FireStaging());break;}
					switch(ammoType){case 1:/*Ammo1 ammo1=new();*/repo.FSW(ammo1.FireStaging());break; case 2:/*Ammo2 ammo2=new();*/repo.FSW(ammo2.FireStaging());break;case 3:/*Ammo3 ammo3= new();*/repo.FSW(ammo3.FireStaging());break;case 4:/*Ammo4 ammo4= new();*/repo.FSW(ammo4.FireStaging());break;}
					switch(ammoType){case 1:/*Ammo1 ammo1=new();*/repo.FSW(ammo1.FireStaging());break; case 2:/*Ammo2 ammo2=new();*/repo.FSW(ammo2.FireStaging());break;case 3:/*Ammo3 ammo3= new();*/repo.FSW(ammo3.FireStaging());break;case 4:/*Ammo4 ammo4= new();*/repo.FSW(ammo4.FireStaging());break;}
					if (sc ==0){Console.WriteLine("Out of ammunition"); return(sc,charge);}
					Console.Write(sc);
				}
				else if(sc == 2 && charge>=cc*2)
				{
					Console.WriteLine("bang\nbang\nout of ammunition\n");
					sc = sc-2;
					charge = charge-cc*2;
					switch(ammoType){case 1:/*Ammo1 ammo1=new();*/repo.FSW(ammo1.FireStaging());break; case 2:/*Ammo2 ammo2=new();*/repo.FSW(ammo2.FireStaging());break;case 3:/*Ammo3 ammo3= new();*/repo.FSW(ammo3.FireStaging());break;case 4:/*Ammo4 ammo4= new();*/repo.FSW(ammo4.FireStaging());break;}
					switch(ammoType){case 1:/*Ammo1 ammo1=new();*/repo.FSW(ammo1.FireStaging());break; case 2:/*Ammo2 ammo2=new();*/repo.FSW(ammo2.FireStaging());break;case 3:/*Ammo3 ammo3= new();*/repo.FSW(ammo3.FireStaging());break;case 4:/*Ammo4 ammo4= new();*/repo.FSW(ammo4.FireStaging());break;}
					return(sc,charge);
				}
				else if(sc ==1 && charge>=cc*1)
				{
					Console.WriteLine("bang\nout of ammunition\n");
					sc = sc-1;
					charge = charge-cc;
					switch(ammoType){case 1:/*Ammo1 ammo1=new();*/repo.FSW(ammo1.FireStaging());break; case 2:/*Ammo2 ammo2=new();*/repo.FSW(ammo2.FireStaging());break;case 3:/*Ammo3 ammo3= new();*/repo.FSW(ammo3.FireStaging());break;case 4:/*Ammo4 ammo4= new();*/repo.FSW(ammo4.FireStaging());break;}
					return(sc,charge);
				}
			}
			else {return(sc,charge);}
		}while(charge>cc);
		return(sc,charge);
	}

	double getShotCost(int ammoType)
	{
		double cc = 0;
		switch (ammoType)
		{
			case 1:
				Ammo1 a = new();
				cc = a.GetChargeCost();
				break;
			case 2:
				Ammo2 b = new();
				cc = b.GetChargeCost();
				break;
			case 3:
				Ammo3 c = new();
				cc = c.GetChargeCost();
				break;
			case 4:
				Ammo4 d = new();
				cc = d.GetChargeCost();
				break;
		}
		return cc;
	}
}
}
