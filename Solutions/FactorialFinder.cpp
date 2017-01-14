/*******************************************************
Factorial Finder
By Justin Buttrey
Program that finds the factorial of user input
********************************************************/
#include "stdafx.h"
#include <iostream>

using namespace std;

//function prototype
int factorialRecursion(int);

int main()
{
	int userInput = 0, factorial = 1;

	cout << "Enter a number to find factorial: ";

	//validate input
	while(!(cin >> userInput)){
		cin.clear();
		cin.ignore(numeric_limits<streamsize>::max(), '\n');
		cout << "Invalid input. Try again: ";
	}

	if(userInput > 0){

		//finds factorial using a loop
		for(int n = 1; n <= userInput; n++){
			factorial *=n; 
		}

		cout << "The factorial using a loop is: " << factorial << endl <<
				"The factorial using recursion is: " << factorialRecursion(userInput) << endl;
	}
	return 0;
}

//gets factorial using recursion
int factorialRecursion(int n) {
	if(n == 0) 
		return 1;
	else
		return n * factorialRecursion(n - 1);
}
