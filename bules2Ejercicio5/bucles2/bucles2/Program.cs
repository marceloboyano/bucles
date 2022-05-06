//Ejercicio 1 - If

//Escribe un programa que:

//Pida datos a un cliente: Nombre, email, cupón

//Determine si un cliente tiene un cupon descuento

//Muestre un precio rebajado en función del descuento

//Muestre el precio de un producto sin descuento si no hay cupón

//Nota: puedes poner un precio fijo de un producto o uno variable.

//Console.Write("Ingrese Nombre:");
//string nombre = Console.ReadLine();
//Console.Write("Ingrese email:");
//string email = Console.ReadLine();
//Console.Write("Tiene cupon de descuento s/n:");
//char cupon = Convert.ToChar(Console.ReadLine());

//if (cupon == 's')
//{
//    Console.WriteLine("Cliente:{0} - email: {1} - el prcio con el descuento del cupon sería: 2000$", nombre, email);
//}
//else
//{
//    Console.WriteLine("Cliente:{0} - email: {1} - el prcio sin descuentos sería: 5000$", nombre, email);
//}
//Ejercicio 2 - Switch

//Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

//Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.

Console.Write("Ingrese un lenguaje de programacion: 1-C#  2-Java. 3-C++. 4-Node JS ");
string condicion =Console.ReadLine();

switch (condicion)
{
    case "1":
        Console.WriteLine("El lenguaje ingresado es: C#");
        break;
    case "2":
        Console.WriteLine("El lenguaje ingresado es: Java");
        break;
    case "3":
        Console.WriteLine("El lenguaje ingresado es: C++");
        break;
    case "4":
        Console.WriteLine("El lenguaje ingresado es: Node JS");
        break;
    default:
        Console.WriteLine("El lenguaje ingresado no corresponde a un lenguaje conocido o utilizado");
        break;
}
