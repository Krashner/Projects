/*******************************************************
Reverse a string
By Justin Buttrey
Program that takes user input and reverses it
********************************************************/

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	//the user's input
	string userInput;

	while(true)
	{
		cout <<"---------------------------------------------------------------------------------" << endl << endl;

		cout<<"Input: ";

		//get user input
		getline (cin,userInput);

		//print the reversed input
		cout << endl << string ( userInput.rbegin(), userInput.rend() ) << endl << endl ;

		cin.clear(); 
	}

	return 0;
}
