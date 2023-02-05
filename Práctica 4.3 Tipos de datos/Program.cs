int num1, num2;

Console.WriteLine("Introduce el primer número entero:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduce el segundo número entero:");
num2 = int.Parse(Console.ReadLine());

int suma = num1 + num2;
int resta = num1 - num2;
int producto = num1 * num2;
int cociente = num1 / num2;
int residuo = num1 % num2;

Console.WriteLine("Primer número: " + num1);
Console.WriteLine("Segundo número: " + num2);
Console.WriteLine("La suma es: " + suma);
Console.WriteLine("La resta es: " + num1 + " - " + num2 + " = " + resta);
Console.WriteLine("La multiplicación es: " + producto);
Console.WriteLine("La división es: " + cociente);
Console.WriteLine("El residuo es: " + residuo);

Console.WriteLine("Pulse una tecla para continuar.");
Console.ReadLine();
