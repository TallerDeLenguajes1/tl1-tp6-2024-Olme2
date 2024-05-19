Console.WriteLine("Escriba un numero para invertir");
int cifras=0;
int num = int.Parse(Console.ReadLine());
if(num>=0){
    int aux=num;
    while(aux>0){
        aux/=10;
        cifras++;
    }
    int aux1;
    int num2=0;
    while(num>0){
        aux1=num%10;
        num2+=aux1*(int)(Math.Pow(10.0,cifras-1));
        cifras--;
        num/=10;
    }
    num=num2;
    Console.WriteLine("El numero invertido es: "+num);
}else{
    Console.WriteLine("El numero no es valido, es menor a 0");
}