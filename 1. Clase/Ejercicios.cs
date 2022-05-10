//1.° Crear un programa que nos salude a todos 
Console.WriteLine("Hola mundo");

//2.° Crear un programa con un saludo personalizado con tu propio nombre dentro del codigo
string tuNombre = "Alex";
Console.WriteLine("Hola "+tuNombre);

//3.° Crear un programa con un saludo personalizado con el nombre del usuario es decir que tenga un ingreso de datos.
Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);

//4.° Con los conocimientos ya adquiridos, crear una calculadora capáz de sumar dos numeros y mostrar el resultado.
Console.WriteLine("Ingresa primer numero: ");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa segundo numero: ");
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("La suma " + numero1 + "+" + numero2 + "=" + (numero1 + numero2));

//Reto
//Con un grupo de amigos estan planeando hacer una fiesta para la universidad, pero para registrar a los invitados se necesita que todos sean mayores de edad.
//para ello necesitan crear un programa que según una fecha de nacimiento, sea capáz de saber si es o no mayor de edad.
//1. Solucion
Console.WriteLine("Ingresa año nacimiento: ");
int anio = int.Parse(Console.ReadLine());
int edad = 2022 - anio;
if (edad >= 18)
{
    Console.WriteLine("Ingresa a la fiesta");
}
else
{
    Console.WriteLine("No ingresa a la fiesta");
}
