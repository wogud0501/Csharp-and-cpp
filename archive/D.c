#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main(void)
{
    int a = 0;
    scanf("%d", &a);
    for (; a <= 50; a++) {
        printf("%d\n", a);
    }
    return 0;
}