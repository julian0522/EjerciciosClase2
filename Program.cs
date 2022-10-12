
//Ejercicio 1: escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje.

Console.WriteLine("Digite su nombre");
String nombre = Console.ReadLine();

Console.WriteLine("Digite su apellido");
String apellido = Console.ReadLine();

Console.WriteLine("Digite su edad");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Si sabe programar digite la letra S y si no sabe la letra N");
char sabeProgramar = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Digite el nombre de la ciudad en donde reside");
String ciudad = Console.ReadLine();

Console.WriteLine("Digite el monto de su salario este mes");
double salario = Convert.ToDouble(Console.ReadLine());

String mensaje = "Nombre: " + nombre
                 + "\nApellido: " + apellido
                 + "\nEdad:" + edad
                 + "\nSabe programar?: " + sabeProgramar
                 + "\nCiudad: " + ciudad
                 + "\nSalario: " + salario;

Console.WriteLine(mensaje);


