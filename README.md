FizzBuzz MVC Web API
===================

Overview
-------
This is an API created with the .NET framework that allows the user to choose a range (start and end numbers) and will output 
a FizzBuzz series of the numbers in the range with the following rules:

*	If no rule matches then output the input number
*	If the input number is a multiple of 3 then output “fizz”
*	If the input number is a multiple of 5 then output “buzz”
*	If the input number is a multiple of 3 and 5 then output “fizzbuzz”

It will also output the number of times fizz, buzz, fizzbuzz or an integer is in the output

## Installation

* [Download](https://github.com/giusepped/FizzBuzzMVCApi/archive/master.zip) a zipped version of the repo or clone it
* Open the Project in Visual Studio
* Build the solution
* Run the project
* Append the desired range values to the address, e.g. `http://localhost:50789/api/FizzBuzz/GetFizzBuzz/?start=2&end=25`
* Unit tests can be run from Visual Studio

## Output example

![](https://github.com/giusepped/FizzBuzzMVCApi/blob/master/images/Screenshot%202016-03-12%2017.34.23.png)



