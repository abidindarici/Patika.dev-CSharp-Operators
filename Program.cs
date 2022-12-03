

// Atama ve işlemleri atama
System.Console.WriteLine("***** atama ve işlemleri atama *****");

int x = 3;
int y = 3;

y = y+2;
System.Console.WriteLine(y);

y += 2;
System.Console.WriteLine(y);

y/=1;
System.Console.WriteLine(y);

x*=2;
System.Console.WriteLine(x);

//Mantıksal Operatörler
// ||, &&, !
System.Console.WriteLine("***** Mantıksal Operatörler *****");

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted)
Console.WriteLine("Perfect!");

if(isSuccess || isCompleted)
Console.WriteLine("Great!");

if(isSuccess && !isCompleted)
Console.WriteLine("Fine!");

//İlişkisel Operatörler
// <, >, <=, >=, ==, !=
System.Console.WriteLine("***** İliskisel Operatörler *****");


int a = 3;
int b = 4;
bool sonuc = a<b;

Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);


//Aritmetik Operatörler
// /, *, +, -
System.Console.WriteLine("***** İliskisel Operatörler *****");

int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1/sayi2;
System.Console.WriteLine(sonuc1);
sonuc1= sayi1*sayi2;
System.Console.WriteLine(sonuc1);
sonuc1= sayi1+sayi2;
System.Console.WriteLine(sonuc1);
sonuc1= sayi1-3;
System.Console.WriteLine(sonuc1);

// % : mod alır

int sonuc2 = 20%3;
System.Console.WriteLine(sonuc2);







