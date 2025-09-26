#include<stdio.h>
typedef int (*Calc)(int a, int b);

int Add(int a, int b)
{
	int result = a + b;
	return result;
}

int Sub(int a, int b)
{
	int result = a - b;
	return	result;
}

int main()
{
	int x = 100;
	int y = 200;
	int z = 0;
	Calc funcPoint1 = &Add;
	Calc funcPoint2 = &Sub;


	z = funcPoint1(x, y);

	printf("%d+%d=%d", x, y, z);

	z = funcPoint2(x, y);

	printf("%d-%d=%d", x, y, z);

	return 0;
}
