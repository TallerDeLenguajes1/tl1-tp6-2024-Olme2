// See https://aka.ms/new-console-template for more information
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
            Console.WriteLine("El resultado de su suma es:"+(a+b));
        break;
        case 2:
            Console.WriteLine("El resultado de su resta es:"+(a-b));
        break;
        case 3:
            Console.WriteLine("El resultado de su multiplicacion es:"+(a*b));
        break;
        case 4:
            Console.WriteLine("El resultado de su division es:"+(a/b));
        break;
    }
    Console.WriteLine("¿Desea hacer otra operacion?\n1: SI\n2: NO");
    hacer=int.Parse(Console.ReadLine());
}
