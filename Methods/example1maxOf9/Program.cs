int Max (int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return  result;
}

int a = 55;
int b = 77;
int c = 99 ;
int d = 13;
int e = 57;
int f = 30;
int g = 17;
int h =133;
int i = 200;

int max = Max(Max(a,b,c),Max(d,e,f),Max(g,h,i));
Console.Write (max);