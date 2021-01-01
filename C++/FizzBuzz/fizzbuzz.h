#include<iostream>
#include<string>

using namespace std;

string fizzbuzz(int number) {
	if (number % 15 == 0)
		return "FizzBuzz";

	if (number % 3 == 0)
		return "Fizz";

	if (number % 5 == 0)
		return "Buzz";

	return to_string(number);
}
