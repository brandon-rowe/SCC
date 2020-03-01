// Brandon Rowe
// CPT-168-A01
// Calculate Gross Pay with Loop

#include <iostream>
using namespace std;

int main()
{
	//display your information
	system ("color f0");
	cout<<"\t\t**********************************************"<<endl;
	cout<<"\t\t*              Brandon Rowe                  *"<<endl;
	cout<<"\t\t*              CPT-168-A01                   *"<<endl;
	cout<<"\t\t*      Calculate Gross Pay with Loop         *"<<endl;
	cout<<"\t\t**********************************************"<<endl<<endl;
	
	

	
	//declare variables
	double numHours    = 0.0;
	double hourRate    = 0.0;
	int stdHours       = 40;
	double grossPay    = 0.0;
	double grossPayDef = 0.0;
	double overTime    = 0.0;
	double overTimePay = 0.0;
	int yearsWorked    = 0;
	double bonusAmount = 0.0;

	cout << "Enter Number of Years Worked or (0, 99 or higher, negative number) to exit: ";
	cin >> yearsWorked;
	while (yearsWorked > 0 && yearsWorked < 99)
	{
		cout << "Enter Hours Worked: ";
		cin >> numHours;
		cout << "Enter Hourly Rate: ";
		cin >> hourRate;

		if (numHours > 40)
		{
			grossPayDef = stdHours * hourRate;
			overTime = (numHours - stdHours) * hourRate;
			overTimePay = overTime * 1.5;
			grossPay = overTimePay + grossPayDef;
			cout << "Your Gross Pay is: $" << 
			grossPay <<endl;
		}
		else
		{
			grossPay = numHours * hourRate;
			cout << "Your Gross Pay is: $" <<
			grossPay << endl;
		}

		if (yearsWorked >= 1 && yearsWorked <= 5)
			bonusAmount = grossPay * 0.05;
		else if (yearsWorked >=6 && yearsWorked <=9)
			bonusAmount = grossPay * 0.10;
		else if (yearsWorked == 10)
			bonusAmount = grossPay * 0.15;
		else 
			bonusAmount = grossPay * 0.20;

		cout << "Your Bonus is: $" << bonusAmount << endl;
		cout << "Enter Number of Years Worked or (0, 99 or higher, negative number) to exit: ";
		cin >> yearsWorked;
	}
	
		cout << "T H A N K Y O U" <<endl;


	system("pause");
	return 0;
} 
	