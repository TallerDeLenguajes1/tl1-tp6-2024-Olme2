using System.Runtime.Intrinsics.Arm;

string s=Console.ReadLine();
int longitud_s=s.Length;
Console.WriteLine($"La longitud de {s} es de {longitud_s} letras");
Console.WriteLine("Ingrese segunda cadena:");
string s2=Console.ReadLine();
s+=s2;
Console.WriteLine($"Cadenas concatenadas: {s}");
if(longitud_s>2){
    string subcadena=s.Substring(2,2);
    Console.WriteLine($"Subcadena de la cadena: {subcadena}");
}else{
    string subcadena=s.Substring(2,1);
    Console.WriteLine($"Subcadena de la cadena: {subcadena}");
}
int hacer=1;
while(hacer==1){
Console.WriteLine("CALCULADORA\n ELIJA UNA OPERACION\n1:SUMA\n2:RESTA\n3:MULTIPLICACION:\n4:DIVISION");
int opcion=int.Parse(Console.ReadLine());
while(opcion<1 || opcion>4){
    Console.WriteLine("Elija una opcion correcta");
    opcion=int.Parse(Console.ReadLine());
}
Console.WriteLine("Escriba los dos numeros para operar");
float a;
float b;
if(opcion==4){
    a=float.Parse(Console.ReadLine());
    b=float.Parse(Console.ReadLine());
    while(b==0){
        Console.WriteLine("El segundo numero debe ser distinto de cero, reescribalo");
        b=float.Parse(Console.ReadLine());
    }
}else{
    a=float.Parse(Console.ReadLine());
    b=float.Parse(Console.ReadLine());
}
    switch (opcion){
        case 1:
            Console.WriteLine($"La suma de {a} y de {b} es igual a:{(a+b)}");
        break;
        case 2:
            Console.WriteLine($"La resta de {a} y de {b} es igual a {(a-b)}");
        break;
        case 3:
            Console.WriteLine($"La multiplicacion de {a} por {b} es igual a {(a*b)}");
        break;
        case 4:
            Console.WriteLine($"La division de {a} por {b} es igual a {(a/b)}");
        break;
    }
    Console.WriteLine("¿Desea hacer otra operacion?\n1: SI\n2: NO");
    hacer=int.Parse(Console.ReadLine());
}
Console.WriteLine($"Cadena {s} recorrida por foreach:\n");
foreach(char caracter in s){
    Console.WriteLine(caracter);
}
Console.WriteLine("Escriba un hola mundo:");
string holaMundo=Console.ReadLine();
string ocurrencia="mundo";
int posicion = holaMundo.IndexOf(ocurrencia);
if (posicion != -1)
{
    Console.WriteLine($"La palabra '{ocurrencia}' se encuentra en la posición {posicion}.");
}
else
{
    Console.WriteLine($"La palabra '{ocurrencia}' no se encuentra en el mensaje.");
}
s=s.ToUpper();
Console.WriteLine($"Cadena convertida a mayusculas: {s}");
s=s.ToLower();
Console.WriteLine($"Cadena convertida a minusculas: {s}");
Console.WriteLine("Ingrese una cadena nueva con palabras separadas por puntos: ");
s=Console.ReadLine();
string[] cadena_separada=s.Split('.');
foreach (string palabras in cadena_separada){
    Console.WriteLine($"<{palabras}>");
}
Console.WriteLine("Ingrese una suma escrita con simbolo (ej: 5+8)");
string suma=Console.ReadLine();
string[] sumandos=suma.Split('+');
Console.WriteLine($"La suma entre {sumandos[0]} y {sumandos[1]} es {int.Parse(sumandos[0])+int.Parse(sumandos[1])}");
