#include "Student.h"
#include<iostream>

Student::Student()
{

}

void Student::SayHello()

{
	std::cout << "hello i'm a student";
}

double Student::Add(double a, double b)
{
	return a + b;
}