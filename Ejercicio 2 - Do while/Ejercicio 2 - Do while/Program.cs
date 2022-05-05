//Ejercicio 2 - Do while

//Escribe un programa que realice estos pasos:

//Reciba al menos un número por consola

//Determine si el número es positivo o negativo

//Presente un contador para cada tipo (positivo y negativo).

//Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.

int positivo = 0;
int negativo = 0;
char condicion;
do
{
    Console.WriteLine("Ingrese un numero positivo o negativo");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero < 0)
    {
        negativo++;
    }
    else if (numero > 0)
    {
        positivo++;
    }
    Console.WriteLine("Desea continuar? s/n");
     condicion = Convert.ToChar(Console.ReadLine());  

} while (condicion == 's');
Console.WriteLine("Positivos: " + positivo + " negativos: " + negativo);