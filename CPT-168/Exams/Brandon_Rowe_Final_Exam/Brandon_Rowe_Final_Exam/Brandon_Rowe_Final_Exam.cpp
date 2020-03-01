//Brandon Rowe
//CPT-168-A01
//Final Exam


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
	cout<<"\t\t*               CPT-168-A01                  *"<<endl;
	cout<<"\t\t*               Final Exam                   *"<<endl;
	cout<<"\t\t**********************************************"<<endl<<endl;

	int counter = 0;
	string fname= " ";
	string lname= " ";
	string ssn= " ";
	string teleNum= " ";
	string stateAbrev= " ";
	
	ifstream Custmr;
	Custmr.open("Customer.txt");

	cout<<"  Name	\tState\tSocial Security\tTelephone Number"<<endl;
	cout<<"  _________\t_____\t_______________\t_______________\n"<<endl;
	Custmr>>fname>>lname>>ssn>>teleNum>>stateAbrev;

	while (Custmr.eof() == false)
	{		
		teleNum.insert(0,1,'-(');
		teleNum.insert(4,1,')');
		teleNum.insert(8,1,'-');
		ssn.replace(0,1, "51");
		ssn.insert(3,1, '-');
		ssn.insert(6,1, '-');
		
		cout<<"  "<<lname<<" "<<fname.substr(0,1)<<". "<<" \t"<<stateAbrev<<" \t"
		<<ssn<<" \t"<<teleNum<<endl;
		
		Custmr>>fname>>lname>>ssn>>teleNum>>stateAbrev;
		counter++;
	}

	cout<<"\n\n\tNumber of records: "<<counter<<endl;
	cout <<"\n\t\tT H A N K  Y O U\n\n"<<endl;
	Custmr.close();
	system("pause");
	return 0;

}