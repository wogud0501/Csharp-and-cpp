#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )
int main(void)

{
	int a, b, temp;
	scanf("%d %d", &a, &b);

	if (a > b) {
		temp = a;
		a = b;
		b = temp;
	}

	for (int i = a; i <= b; i++) {
		printf("%d", i);
	}

	return 0;
}