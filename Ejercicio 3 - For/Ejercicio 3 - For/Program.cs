//Ejercicio 3 - For

//Escribe un programa que realice estos pasos:

//Reciba 3 datos:

//ancho

//alto

//relleno o no

//Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

//En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

//Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla.Ejemplos:

//Input: 2,2,2, relleno = true

//Output:

//** **

//** **

//Input: 3, 4, 1, relleno = false

//Output:

//***

//* *

//* *

//***

Console.WriteLine("Ingrese un ancho");
int ancho=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el alto");
int alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Relleno s/n");
char relleno = Convert.ToChar(Console.ReadLine());

for(int i =0; i <= ancho; i++)
{
    if (relleno == 's')
    {
        Console.Write("*");
        i++;
    }
    else
    {
        Console.Write("* ");
        i++;
    }
}
Console.WriteLine();
for (int j = 0; j <= alto; j++)
{
   
    if (relleno == 's')
    {
        Console.Write("*");
        j++;
    }
    else
    {
        Console.Write("* ");
        j++;
    }
}
