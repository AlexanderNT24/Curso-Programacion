//1.° Haciendo uso de funciones crea un programa con un metódo llamado saludar() el cual escriba por consola un saludo.
void saludar() {
    Console.WriteLine("Hola a todos!");
}
saludar();
//2.° Basándonos en el ejercicio anterior ahora has que la función reciba por parámetros un nombre y realice un saludo personalizado.
void saludar(string nombre) {
    Console.WriteLine("Hola "+nombre);
}
saludar("Alex");
//3.° Haciendo uso de funciones, crea un programa con un método llamado sumar(), que reciba como parámetros dos números y retorne el resultado de la suma de ambos.
int sumar(int a, int b)
{
    return a + b;
}
int suma= sumar(1, 2);
Console.WriteLine(suma);