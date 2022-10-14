#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main(){
    
    long long int a,m,d,n;
    scanf("%lld %lld %lld %lld",&a,&m,&d,&n);
    
    for(int j = 1; j <n; j++){
        
        a *= m;
        a += d;
        
    }
    printf("%lld",a);
    
    
    return 0;
}