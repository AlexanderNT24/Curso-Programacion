//1 Brayan es un chico de la universidad privada del algún norte XD, él tiene ganas de salir a una disco con sus amigos e impresionar a Karen comprándole muchas cosas, como él vive muy lejos y la discoteca cobra entrada, todos sus planes están determinados por su capacidad monetaria.
Console.WriteLine("Ingresa respuesta:");
string respuesta=Console.ReadLine();
if (respuesta == "si") {
    Console.WriteLine("Brayan, si puedes salir");
}
else
{
    Console.WriteLine("Brayan, no puedes salir");
}
//2 A la historia de Brayan ahora se le presenta lo siguiente, si consigue 10 soles solo le alcanza para ir y regresar pero sabe que adicional a eso necesita el doble de lo que requiere para ir y regresar para que así pueda lograr su objetivo ¿Cómo lo programamos?
Console.WriteLine("¿Cuanto dinero tienes Brayan?:");
double respuesta=double.Parse(Console.ReadLine());
if (respuesta >= 30) {
    Console.WriteLine("Brayan, si puedes salir");
}
else
{
    Console.WriteLine("Brayan, no puedes salir");
}

//3 Tu madre te ha dicho que, si desapruebas el examen, no saldrás a una fiesta, simula mediante un programa su reacción en base a tus notas.
//a. Cuando la nota es igual a 20, unas felicitaciones y el permiso.
//b. Cuando la nota es menor que 20 y mayor o igual a 12, solo el permiso.
//c. Cuando la nota es menor que 12, un enojo y no el permiso.

Console.WriteLine("¿Cual es tu nota?:");
int respuesta=int.Parse(Console.ReadLine());

if (respuesta==20)
{
    Console.WriteLine("Felicidades, tienes el permiso");
}
else
{
    if (respuesta<20 && respuesta>=12)
    {
        Console.WriteLine("Tienes el permiso");
    }
    else
    {
        if (respuesta<12)
        {
            Console.WriteLine("No puedes salir!!!!!!");
        } 
    }
}

//4 Diseña un inicio de sesión para un usuario y a través de este realiza una validación de datos, donde no se podrá ingresar si se registra un usuario o contraseña incorrecta.
//Los datos del usuario y contraseña estarán en el código, asignados a una variable.

string usuario = "tunombre";
string contrasenia = "tuapellido";
Console.WriteLine("Ingrese usuario:");
string usuarioIngresado = Console.ReadLine();
Console.WriteLine("Ingrese contraseña:");
string contraseniaIngresada = Console.ReadLine();
if (usuarioIngresado == usuario)
{
    if (contraseniaIngresada==contrasenia)
    {
        Console.WriteLine("¡Ingresaste!");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
}
else
{
    Console.WriteLine("Usuario incorrecto");
}
//5 Simula un elevador haciendo uso de la sentencia switch, en base a un piso ingresado, se mostrará por consola el piso en que nos encontramos.
Console.WriteLine("Ingrese a que piso ir: ");
int piso=int.Parse(Console.ReadLine());
switch (piso)
{
    case 1:
        Console.WriteLine("Piso 1 ");
        ;break;
    case 2:
        Console.WriteLine("Piso 2");
        ;break;
    case 3:
        Console.WriteLine("Piso 3");
        ; break;
    case 4:
        Console.WriteLine("Piso 4");
        ; break;
    case 5:
        Console.WriteLine("Piso 5");
        ; break;
    default:
        Console.WriteLine("No hay más pisos");
        break;
}
//6 Crea un juego de preguntas con un menú de opciones, las preguntas son a tu criterio, usando la sentencia switch realiza una validación, si la respuesta registrada por el usuario, es correcta o no.
Console.WriteLine("¿En que año fue la independencia del Perú? ");
Console.WriteLine("a.1821");
Console.WriteLine("b.1721");
Console.WriteLine("c.1940");
Console.WriteLine("d.No me acuerdo, extraño el cole");
Console.WriteLine("Ingresa respuesta:");
string respuesta=Console.ReadLine();
switch (respuesta)
{
    case "a":
        Console.WriteLine("Correcto!!");
        ; break;
    case "b":
        Console.WriteLine("Falso, la respuesta es la a.");
        ;break;
    case "c":
        Console.WriteLine("Falso, la respuesta es la a.");
        ; break;
    case "d":
        Console.WriteLine("Falso, la respuesta es la a.");
        ; break;
    default:
        Console.WriteLine("Intenta otra vez");
        ;break;
}
//7
Console.WriteLine("Ingresa palabra:");
string palabra=Console.ReadLine();
Console.WriteLine("Empezamos el bucle");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(palabra);
}
//8 Para entender como funcionan los bucles debemos ir paso a paso, por ello crea un programa que pida al usuario una palabra y la muestre por pantalla 10 veces.
Console.WriteLine("Ingresa numero a contar:");
int numero=int.Parse(Console.ReadLine());
Console.WriteLine("Empezamos el bucle");
for (int i = 0; i < numero; i++)
{
    Console.WriteLine(i);
}
//8.1 Para entender como funcionan los bucles debemos ir paso a paso, por ello crea un programa que pida al usuario una palabra y la muestre por pantalla 10 veces.
Console.WriteLine("Ingresa numero a contar:");
int numero=int.Parse(Console.ReadLine());
Console.WriteLine("Empezamos el bucle");
for (int i = 0; i < numero; i++)
{
    Console.WriteLine(i+1);
}
//9 Luego crea un programa que sea capaz de contar hasta cierto numero 
string usuario = "1";
string contrasenia = "1";
string usuarioIngresado="";
string contraseniaIngresada="";
while (usuario != usuarioIngresado || contrasenia != contraseniaIngresada)
{
    Console.WriteLine("Ingrese usuario:");
    usuarioIngresado = Console.ReadLine();
    Console.WriteLine("Ingrese contraseña:");
    contraseniaIngresada = Console.ReadLine();
    if (usuarioIngresado == usuario)
    {
        if (contraseniaIngresada == contrasenia)
        {
            Console.WriteLine("¡Ingresaste!");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta");
        }
    }
    else
    {
        Console.WriteLine("Usuario incorrecto");
    }
}
//10 Para finalizar basándonos en los primeros ejercicios crear un inicio de sesión para un usuario y a través de este realizará una validación de datos, donde no se podrá ingresar si se registra un usuario o contraseña incorrecta.
//Hacer uso de bucles para que el programa no termine, hasta que el usuario ingrese datos correctos.

Console.WriteLine("Ingresa numero de personas: ");
int numero=int.Parse(Console.ReadLine());
for (int i = 0; i < numero; i+=2)
{
    Console.WriteLine("Persona numero " + (i + 1));
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

}
