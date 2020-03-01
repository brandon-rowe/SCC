//Brandon Rowe
//CPT-168-A01
//Square, Cube Assignment

#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	system("color F0");

	double var = 0.0;
	double x   =0.0;
	char response= 'Y';

	while (response =='Y'||response =='y')
		{
	
			cout<<"\t************************************************"<<endl;
			cout<<"\t*                  Brandon Rowe                *"<<endl;
			cout<<"\t*                   CPT-168-A01                *"<<endl;
			cout<<"\t*             Square-Cube Assignement          *"<<endl;
			cout<<"\t************************************************"<<endl<<endl;


			cout<<endl<<"Please enter a number to Square, Cube, and raise to the 4th power: ";
			cin>>var;
			cout<<endl;
			cout<<"\tNumber\tSquare\tCube\t4th power"<<endl<<endl;
			cout<<"\t------\t------\t------\t-------"<<endl;
			x=var+50;

			while(var<x)
				{	
					cout<<"\t"<<var<<"\t"<<pow(var,2)<<"\t"<<pow(var,3)<<"\t"<<pow(var,4)<<endl;
					var=var+5;
				}

			cout<<"Would you like to continue?"<<endl;
			cin>>response;
			
			 system("cls");
		}

return 0;

}