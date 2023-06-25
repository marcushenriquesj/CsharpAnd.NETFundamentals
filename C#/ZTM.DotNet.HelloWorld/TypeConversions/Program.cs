//Implicit conversion
//no data can be lost

//Explicit conversions
//require casting -- info can be lost

int age = 31;
float weight = 78.7f;

//implicit
long myAge = age;

//explicit
int lessweight = (int)weight; // precision lost
int notMyAge = (int)myAge; // no precision lostt


long bignum = 1111111111111;
int smallerType = (int)bignum;


