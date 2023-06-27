// See https://aka.ms/new-console-template for more information

Console.WriteLine("*********** Atama ve İşlemli Atama ****************");
//Atama ve İşlemli Atama

    int x=3;
    int y=3;
    
    y=y+2;
        Console.WriteLine(y);

    y+=2;
        Console.WriteLine(y);
    
    y/=1;
        Console.WriteLine(y);
    
    x*=2;
        Console.WriteLine(x);

Console.WriteLine("*********** Mantıksal Operatörler ****************");
//Mantıksal Operatörler
// || , &&, !

    bool IsSuccess =true;
    bool IsCompleted = false;

        if(IsSuccess && IsCompleted)
            Console.WriteLine("Perfect");

        if(IsSuccess || IsCompleted)
            Console.WriteLine("Great");

        if(IsSuccess && !IsCompleted)
            Console.WriteLine("Fine");

Console.WriteLine("*********** İlişkisel Operatörler ****************");
//İlişkisel Operatörler
// < , > , <= , >=, == , !=

    int a = 3;
    int b = 4;
    bool sonuc = a<b;
    Console.WriteLine(sonuc);

    sonuc=a>b;
    Console.WriteLine(sonuc);

    sonuc=a>=b;
    Console.WriteLine(sonuc);

    sonuc=a<=b;
    Console.WriteLine(sonuc);

    sonuc=a==b;
    Console.WriteLine(sonuc);

    sonuc=a!=b;
    Console.WriteLine(sonuc);


Console.WriteLine("*********** Aritmetik Operatörler ****************");
//Aritmetik Operatörler
//+, -, *, /, %, ++, --

int sayi1 = 10;
int sayi2= 5;
int sonuc1=sayi1/sayi2;
Console.WriteLine(sonuc1);

int sonuc2=sayi1*sayi2;
Console.WriteLine(sonuc2);

int sonuc3=sayi1+sayi2;
Console.WriteLine(sonuc3);

int sonuc4=sayi1 ++;
Console.WriteLine(sonuc4);

int sonuc5=sayi1%sayi2;
Console.WriteLine(sonuc5);
