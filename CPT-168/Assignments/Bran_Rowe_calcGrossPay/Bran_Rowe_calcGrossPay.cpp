// Brandon Rowe
// CPT-168-A01
// Calculate Gross Pay

#include <iostream>
using namespace std;

int main()
{
	//display your information
	system ("color f0");
	cout<<"\t\t**********************************************"<<endl;
	cout<<"\t\t*              Brandon Rowe                  *"<<endl;
	cout<<"\t\t*              CPT-168-A01                   *"<<endl;
	cout<<"\t\t*          Calculate Gross Pay               *"<<endl;
	cout<<"\t\t**********************************************"<<endl<<endl;
	
	double numHours    = 0.0;
	double hourRate    = 0.0;
	double grossPay    = 0.0;
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
			grossPay = (40 * hourRate) + (numHours - 40) * (hourRate * 1.5);
		else
			grossPay = numHours * hourRate;
		cout << "Your gross pay is: $" << endl << endl;

		if (yearsWorked <= 0)
			cout << "Invalid number entered. " << endl;
		else if	(yearsWorked >= 1 && yearsWorked <= 5)
			bonusAmount = grossPay * 0.05;
		else if (yearsWorked >= 6 && yearsWorked <= 9)
			bonusAmount = grossPay * 0.10;
		else if (yearsWorked == 10)
			bonusAmount = grossPay * 0.15;
		else if (yearsWorked > 10)
			bonusAmount = grossPay * 0.20;
		cout << "Enter nuber of years worked or (Negatives, 0, or more than 99 to exit)";
		cin >> yearsWorked;
	}
	cout << endl;
	cout << "THANK YOU" << endl <<endl;









	/*//declare variables
	double numHours    = 0.0;
	double hourRate    = 0.0;
	int stdHours       = 40;
	double grossPay    = 0.0;
	double grossPayDef = 0.0;
	double overTime    = 0.0;
	double overTimePay = 0.0;
	int yearsWorked    = 0;
	double bonusAmount = 0.0;
	
	//input 
	cout << "Enter Hours Worked: ";
	cin >> numHours;
	cout << "Enter Hourly Rate: ";
	cin >> hourRate;
	
	//calculate grossPay
	if (numHours <= 40)
	{	
		grossPay = numHours * hourRate;
		cout << "Your Gross Pay is: $" <<
		grossPay << endl;
	}
	else 
	{
		grossPayDef = stdHours * hourRate;
		overTime = (numHours - stdHours) * hourRate;
		overTimePay = overTime * 1.5;
		grossPay = overTimePay + grossPayDef;
		cout << "Your Gross Pay is: $" << 
		grossPay <<endl;		
	}

	//input yearsWorked
	cout << "Enter Number of Years Worked: ";
	cin >> yearsWorked;
	
	//calculate bonusAmount
	if (yearsWorked == 0)
		cout << "You are not eligible for bonus at this time." <<endl;
	else if (yearsWorked >= 1 && yearsWorked <= 5)
		bonusAmount = grossPay * 0.05;
	else if (yearsWorked >=6 && yearsWorked <=9)
		bonusAmount = grossPay * 0.10;
	else if (yearsWorked == 10)
		bonusAmount = grossPay * 0.15;
	else 
		bonusAmount = grossPay * 0.20;

	//output bonusAmount
	cout << "Your Bonus is: $" << bonusAmount << endl;*/
	
	system("pause");
	return 0;
} 
