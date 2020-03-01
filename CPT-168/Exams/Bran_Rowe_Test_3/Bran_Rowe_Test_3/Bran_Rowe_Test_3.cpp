//Brandon Rowe
//CPT-168-A01
//Test 3

#include <iostream>
#include <string>
using namespace std;

int main()
{
	system("color f0");
	cout<<"\t\t**********************************************"<<endl;
	cout<<"\t\t*              Brandon Rowe                  *"<<endl;
	cout<<"\t\t*              CPT-168-A01                   *"<<endl;
	cout<<"\t\t*                Test 3                      *"<<endl;
	cout<<"\t\t**********************************************"<<endl<<endl;
	
	//declate variables
   	string num [10] = {"8,9,23,29,50", "34,19,21,38,51", "20,25,28,30,49", "22,27,33,37,42", "16,18,28,34,38", "1,3,6,13,33",
	"7,21,25,28,37", "10,11,18,19,21", "31,33,35,37,38", "41,42,44,46,49"};

	string horo [10] = {"You are going to have a week full of suprises ", "you will barely escape an accident this week ", "You will receive a large amount of money this week ", 
	"This week is going to be a great week for you ", "You will get a phone call from an old friend this week ", "You will get promoted at your job this week ", 
	"You may have some type of car problem this week ", "You will hear very good news this week ", "You will be free from a long lasting problem this week",
	"An old investment will return a good reward this week "};
	
	int rndmNum = 0;

	//enter input	
		cout<<"Please enter a number from 1 - 10 or 99 to end: ";
		cin >>rndmNum;

	//do while loop
	do
	{				
		
			if(rndmNum >= 1 && rndmNum <= 10)
			{
				cout << "This week horoscope: " << horo [rndmNum-1]<<endl;
				cout <<	"Lucky Carolina5 numbers: " << num [rndmNum-1]<<endl<<endl;
				cout<<"Please enter a number from 1 - 10 or 99 to end: ";
				cin >>rndmNum;
			}
			else
			{	
				cout << "Invalid number entered."<<endl<<endl;
				cout<<"Please enter a number from 1 - 10 or 99 to end: ";
				cin >>rndmNum;
			}							
	} while (rndmNum != 99 );
		
		cout <<"\n\t\tT H A N K  Y O U\n"<<endl;
		system ("pause");
	return 0;
}