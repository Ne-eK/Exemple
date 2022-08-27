int Max (int a, int b, int c) {
    int result = a;
    if ( result < b ) result = b;
    if ( result < c ) result = c;
    return result;
}

int n1 = 1, n2 = 2, n3 = 3, n4 = 4, n5 = 5, n6 = 6, n7 = 7, n8 = 8, n9 = 9;

int max1 = Max (n1, n2, n3);
int max2 = Max (n4, n5, n6);
int max3 = Max (n7, n8, n9);
int max = Max (max1, max2, max3);

Console.WriteLine(max);
