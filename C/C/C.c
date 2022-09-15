#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main() {
    int a;
    scanf("%X", &a);
    for (int i = 1; i <= 15; i++) {
        printf("%X*%X=%X\n", a, i, (i * a));
    }
    return 0;
}