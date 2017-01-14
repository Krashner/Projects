/*******************************************************
Find PI to the Nth Digit
By Justin Buttrey
Program to find PI to a specified decimal place
********************************************************/

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;

int main()
{
	//store user input of how many decimals places
	int decimalPlaces = 0;	
	//calculates pi as a long double for more precision
	long double pi=acosl(-1.0L);

	while(true)
	{
		cout<<"Enter how many decimal places of PI you would like to see (limited by processor):" 
		    << endl << endl << "Decimal places: ";

		//get user input
		cin>>decimalPlaces;

		 //must be number that is greater or equal to 0, or input is not int
		if(!cin || decimalPlaces < 0 || decimalPlaces - floor(decimalPlaces) != 0 )
		{
			//display error
			cout << endl << "Not a valid number." << endl << endl;
		}else{
			//display pi
			cout << endl << "Pi to '" << decimalPlaces << "' decimal places is " 
			     << fixed << setprecision(decimalPlaces) << pi << endl << endl;
		}

		cout <<"---------------------------------------------------------------------------------" << endl << endl;

		//clear all input
		cin.clear(); 
		cin.ignore(numeric_limits<streamsize>::max(), '\n'); //skip bad input
	}

	return 0;
}

