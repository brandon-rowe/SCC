// Brandon Rowe
// CPT-168-A01
// Calculate Gross Pay

#include <iostream>
using namespace std;

int main()
{
	system ("color f0");
	cout<<"\t\t**********************************************"<<endl;
	cout<<"\t\t*              Brandon Rowe                  *"<<endl;
	cout<<"\t\t*              CPT-168-A01                   *"<<endl;
	cout<<"\t\t*          Calculate Gross Pay               *"<<endl;
	cout<<"\t\t**********************************************"<<endl<<endl;

	double numHours    = 0.0;
	double hourRate    = 0.0;
	double stdHours    = 40;
	double grossPay    = 0.0;
	double grossPayOT  = 0.0;
	double overTimePay = 0.0;
			
	cout << "Enter Hours Worked: ";
	cin >> numHours;
	cout << "Enter Hourly Rate: ";
	cin >> hourRate;
		
	if (numHours <= 40)
	{	
		grossPay = numHours * hourRate;
		cout << "Your Gross Pay is: $" <<
		grossPay << endl;
	}
	else 
	{
		grossPay = stdHours * hourRate;
		overTimePay = (numHours - stdHours) * 1.5;
		grossPayOT = overTimePay + grossPay;
		cout << "Your Gross Pay is: $" << 
		grossPayOT <<endl;		
	}

		
	system("pause");
	return 0;
}
