// Brandon Weather.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	system("color f0");
	cout<<"\t\t**********************************************"<<endl;
	cout<<"\t\t*              Brandon Rowe                  *"<<endl;
	cout<<"\t\t**********************************************"<<endl<<endl;
	
	//declare variables
	string forecast [7] = {"very cold today! Bundle up! ", "cold today, wear a heavy jacket, long sleeves, and pants. ",
		"cool today, wear a jacket and pants. ", "nice all day. Not too cold but not too warm, dress moderate. ", 
		"warm today, wear shorts and a t-shirt. ", "hot today, wear light shorts and shirts. ", 
		"very hot today! Wear light, breathable clothes. " };
	
	int weatherDegrees = 0, i =0;

	//enter output and obtain weatherDegrees input

	//do while loop
	do
	{				
		
		cout<<"Please enter the weather in degrees from 1 - 120 or 999 to end: ";
		cin >>weatherDegrees;
		if (weatherDegrees != 999)
		{
		if(weatherDegrees >=1 && weatherDegrees < 35)
				i = 0;		
			else if(weatherDegrees >= 35 && weatherDegrees <= 45)
				i = 1;		
			else if(weatherDegrees >= 46 && weatherDegrees <= 55)
				i = 2;		
			else if(weatherDegrees >= 56 && weatherDegrees <= 65)
				i = 3;		
			else if(weatherDegrees >= 66 && weatherDegrees <= 75)
				i = 4;		
			else if(weatherDegrees >= 76 && weatherDegrees <= 85)
				i = 5;		
			else if(weatherDegrees > 85 && weatherDegrees <=120)
				i = 6;					
			else
				cout << "Invalid number entered."<<endl<<endl;
		if (i >=0 && i <=6)
		{
			cout<<"\nIt's going to be "<<forecast[i]<<"\n"<<endl;			
		}
		}
	} while (weatherDegrees != 999 );
		
		cout <<"\n\t\tT H A N K  Y O U\n"<<endl;
		system ("pause");
	return 0;
}

