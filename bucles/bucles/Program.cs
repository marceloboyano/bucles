//// Ejercicio 1 - While

//Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

//1 x 1 = 1
//1 x 2 = 2
//…
//1 x 10 = 10
Console.WriteLine("Ingrese el valor a multiplicar");
int numero = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= 10)
{
    Console.WriteLine(+numero + " X " + i+" = "+ numero*i);
    i++;
}