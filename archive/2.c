#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main(void)
{
	long long int a, b, c;
	scanf("%lld %lld %lld", &a, &b, &c);

	for (int j = 1; j < c; j++) {
		a *= b;
	}
	printf("%lld", a);
	return 0;
}