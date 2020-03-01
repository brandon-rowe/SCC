//Brandon Rowe
//CPT-168-A01
//Month Array

#include <iostream>
#include <string>
using namespace std;

int main()
{
	system("color f0");
	
   	string mnth [12] = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
	string flwr [12] = {"Carnation", "Iris", "Daffodil", "Daisy", "Lily of the Valley", "Rose", "Sunflower", "Gladiolus", "Aster", "Snapdragon", "Chrysanthemum", "Orchid"};
	int moNum = 0;
	char ans = 'y';

	do
	{	
			system("cls");
		cout<<"\t\t**********************************************"<<endl;
		cout<<"\t\t*              Brandon Rowe                  *"<<endl;
		cout<<"\t\t*              CPT-168-A01                   *"<<endl;
		cout<<"\t\t*              Month Array                   *"<<endl;
		cout<<"\t\t**********************************************"<<endl<<endl;

			cout<<"Please enter the month you were born (1-12): ";
			cin >>moNum;

			if(moNum >= 1 && moNum <= 12)
			{
				cout << "You were born on " << mnth [moNum-1]<<" and your flower is " <<flwr[moNum-1]<<endl<<endl;
			}
			else
			{	
				cout << "Invalid month entered."<<endl<<endl;
			}	
			
			cout << "Would you like to continue (Y or N)? ";
				cin >>ans;
	} 
		while (ans == 'y' || ans == 'Y');

		cout <<"\n\t\tT H A N K  Y O U\n"<<endl;
		system ("pause");
	return 0;
}

