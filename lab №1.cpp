#include <iostream>
#include <bitset>
#include<ctime>
using namespace std;

bool compare(int, int);
void incr(int&);

int main()
{
	srand(time(NULL));
	int a = rand() % 10;
	int b = rand() % 10;
	bool res = compare(a, b);

	int n = rand() % 10;
	incr(n);
}

bool compare(int a, int b)
{
	bool res(true);

	if ((a ^ b) == 0) res;
	else res = false;
	return res;
}

void incr(int& n)
{
	int n1 = n;
	for (int i = 0; i < (sizeof(int)*8); i++)
	{
		n = n ^ (1 << i);
		if ((n1 & (1 << i)) == 0) break;
	}
}
