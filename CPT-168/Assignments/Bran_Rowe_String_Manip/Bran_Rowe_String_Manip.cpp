//Brandon Rowe
//CPT-168-A01
//String Manipulation

#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	

	char ans= ' ';
	string fullName=" ";
	string firstName=" ";
	string lastName=" ";
	string ssn=" ";
	string phoneNum=" ";
	int i=0;
	system("cls");
	system ("color f0");
	
		cout<<"\t\t**********************************************"<<endl;
		cout<<"\t\t*              Brandon Rowe                  *"<<endl;
		cout<<"\t\t*              CPT-168-A01                   *"<<endl;
		cout<<"\t\t*           String Manipulation              *"<<endl;
		cout<<"\t\t**********************************************"<<endl<<endl;

	do 
	{					
		cout<<"Enter your first name: ";
		cin>>firstName;
		cout<<"Enter your last name: ";
		cin>>lastName;
	do
	{
		cout<<"Enter 10 digit phone number (with no dashes or parenthesis): ";
		cin>>phoneNum;
	}
	while(phoneNum.length() !=10);

	do
	{
		cout<<"Enter 9 digit SSN (with no dashes): ";
		cin>>ssn;
	}
	while(ssn.length() !=9);
	phoneNum.insert(0,1,'-(');
	phoneNum.insert(4,1,')');
	phoneNum.insert(8,1,'-');
	ssn.insert(3,1, '-');
	ssn.insert(6,1, '-');
	fullName=firstName+" "+lastName;

	cout<<"\nYour Phone number: "<<phoneNum<<endl;
	cout<<"Your Social Security Number: "<<ssn;
	cout<<"\nYour full name is: "<<fullName<<"\nYour reversed full name is: ";
	for (int i= fullName.length(); i>=0; i--)
		cout<<fullName.substr(i,1);
		cout<<"\n\nWould you like to try another set of phone and ssn? ";
		cin>>ans;
		cout<<"\n";
	}
	while (toupper(ans) =='Y');
	cout<<"\n\t\tT H A N K Y O U\n\n";
	system("pause");
	return 0;


}