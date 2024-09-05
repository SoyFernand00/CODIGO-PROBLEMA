int nu1, suma=0, pro=0, to=0;
for (int f=1; f<=4; f++)
{
    Console.WriteLine("Ingresar dato: ");
    nu1=int.Parse(Console.ReadLine());
    suma = suma + nu1;
    pro=suma;
}
Console.WriteLine("La suma es: "+ suma);
pro = suma / 4;
Console.WriteLine(pro);
