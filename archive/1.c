#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main(void)
{
	int a, b, c;
	scanf("%d %d %d", &a, &b, &c);

	for (int j = 1; j < c; j++) {
		a = b;
	}
	printf("%d", a);
	return 0;
}