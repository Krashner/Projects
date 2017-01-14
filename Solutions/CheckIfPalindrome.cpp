/*******************************************************
Check if string is Palindrome
By Justin Buttrey
Program to check if the string entered by the user is a palindrome.
That is that it reads the same forwards as backwards like “racecar”
********************************************************/

#include "stdafx.h"
#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	//the user's input
	string userInput;

	while(true)
	{
		cout <<"---------------------------------------------------------------------------------" << endl << endl;

		cout<<"Please enter word to check if it's a plaindrome" 
			<< endl << endl << "Input: ";

		//get user input
		getline (cin,userInput);

		//clear spaces from input
		userInput.erase(remove_if(userInput.begin(), userInput.end(), isspace), userInput.end());

		//check to see if there was input
		if(userInput == ""){
			cout << endl << "Please enter a valid input." << endl << endl;
			continue;
		}

		//checks if input is palindrome by reversing the string and comparing
		if(userInput == string ( userInput.rbegin(), userInput.rend() ))
			cout << endl << userInput + " is a palindrome." << endl << endl;
		else
			cout << endl << userInput + " is not a palindrome." << endl << endl;

		cin.clear(); 
	}

	return 0;
}
