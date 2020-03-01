//Brandon Rowe
//C{T-168-A01
//Payroll Sequential File


#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>
using namespace std;

int main()
{
	system ("color f0");
	cout<<"\t\t**********************************************"<<endl;
	cout<<"\t\t*              Brandon Rowe                  *"<<endl;
	cout<<"\t\t*              CPT-168-A01                   *"<<endl;
	cout<<"\t\t*          Payroll Sequential File           *"<<endl;
	cout<<"\t\t**********************************************"<<endl<<endl;
	cout<<fixed<<setprecision(2);

	int counter = 0;
	string fname= " ";
	string lname= " ";
	string ssn= " ";
	double hrsWorked= 0.0;
	double hrlyRate= 0.0;
	double grossPay= 0.0;
	double deduction= 0.0;
	double netPay= 0.0;
	ifstream Pyrll;
	Pyrll.open("Payroll.txt");

	cout<<"   SSN	Name	\tHours\tRate\tGross\tDeductions\tNetPay"<<endl;
	cout<<"   ___	_____________\t_____\t____\t_____\t__________\t______"<<endl;
	Pyrll>>fname>>lname>>ssn>>hrsWorked>>hrlyRate;

	while (Pyrll.eof() == false)
	{
		if (hrsWorked >= 40)
			grossPay = hrlyRate * 40 + (hrsWorked -40) * (hrlyRate * 1.5);

		else
			grossPay = hrsWorked * hrlyRate;
		
		deduction = grossPay * .10;
		netPay = grossPay * deduction;

		cout<<"  "<<ssn.substr(7,4)<<"\t"<<fname.substr(0,1)<<". "<<lname
			<<"  \t"<<hrsWorked<<"\t"<<hrlyRate<<"\t"<<grossPay<<"\t"<<deduction
			<<"\t\t"<<netPay<<endl;
		Pyrll>>fname>>lname>>ssn>>hrsWorked>>hrlyRate;
		counter++;
	}

	cout<<"\n\n\tNumber of records: "<<counter<<endl;
	cout <<"\n\t\tT H A N K  Y O U\n\n"<<endl;
	Pyrll.close();
	system("pause");
	return 0;

}