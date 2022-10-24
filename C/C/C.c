#include <stdio.h>
#pragma warning(disable : 4996)
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4474 )

int main() {
	int i = 0;
	char d[21];
	scanf("%s", d);
	for (i = 0; d[i] != '\0'; i++)
	{
		printf("\'%c\'\n", d[i]);
	}
}