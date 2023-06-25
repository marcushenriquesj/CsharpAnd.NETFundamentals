bool enabled = false;
Console.WriteLine($"bool: {enabled}");

enabled = true;
Console.WriteLine($"bool: {enabled}");

char c1 = 'a';
Console.WriteLine($"char: {c1}");

int a = 0;
int b = 5;
int c = -7;
Console.WriteLine($"a: {a} b: {b} c: {c}");

int multiply = b * c;
int divide = c / b;
int add = a + b;
int sub = a - b;

float f = 3.5f;
double g = 7.8d;
decimal dec = 7.15m;

int a1 = 7;
int a2 = a1;
//a2 remains 7
a1 = 5;
