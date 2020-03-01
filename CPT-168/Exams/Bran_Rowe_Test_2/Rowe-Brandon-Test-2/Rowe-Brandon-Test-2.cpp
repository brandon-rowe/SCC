// Brandon Rowe
// CPT-168-A01
// Test-2

#include <iostream>
using namespace std;

int main()
{
	//display your information
	system ("color f0");
	cout<<"\t\t**********************************************"<<endl;
	cout<<"\t\t*              Brandon Rowe                  *"<<endl;
	cout<<"\t\t*              CPT-168-A01                   *"<<endl;
	cout<<"\t\t*            Test-2 Wells Fargo              *"<<endl;
	cout<<"\t\t**********************************************"<<endl<<endl;
	
	//declare variables
	double saveBal     = 0.0;
	double interestAmt = 0.0;
	//input 
	cout << "Please enter the saving balance: ";
	cin >> saveBal;
		
	//calculate bonusAmount
	if (saveBal <= 0)
		cout << "Invalid balance was entered. " <<endl;
	else if (saveBal <= 500)
		cout << "NO Interest for this balance." <<endl;
	else if (saveBal >= 501 && saveBal <= 5000)
		interestAmt = saveBal * 0.05;
	else 
		interestAmt = saveBal * 0.10;

	//output bonusAmount
	cout << "Yearly Interest: $" << interestAmt << endl;
	
	system("pause");
	return 0;
} 
