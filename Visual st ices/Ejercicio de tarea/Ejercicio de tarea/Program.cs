// See https://aka.ms/new-console-template for more information

// DO WHILE
/*
 * Console.WriteLine("Ingresa la clave: ");
string? clave;

do
{
    clave = Console.ReadLine();

} while (clave != "667788");

Console.WriteLine("bien pibe! ");
*/



/*
 * Console.WriteLine("Usuario y calve: ");
string? clave = Console.ReadLine();

while (clave != "667788")
{
    Console.WriteLine("Flaco, esa no es la clave. proba de nuevo");
    clave = Console.ReadLine();
}
*/

/*
Console.WriteLine("Ingresar un número: ");
string? num;
int num_int;

do
{
    num = Console.ReadLine();
    num_int = int.Parse(num);
} while (num_int <= 0);
 


Console.WriteLine("ingresaste un positivo");
*/

/*
Console.WriteLine("Inserte un numero positivo");
string? num;
double num_double;
double suma_negs = 0;
int cant_negs = 0;
do
{
    num = Console.ReadLine();
    num_double = double.Parse(num);
    if (num_double < 0)
    {
        suma_negs += num_double;
        cant_negs++;
    }
} while (num_double <= 0);
Console.WriteLine("Correcto, ingreso un positivo");
double promedio = suma_negs / cant_negs;
Console.WriteLine("El promedio de los numeros negativos ingresados es de: " + promedio);
*/

/* 
 * Console.WriteLine("Ingresar numeros");
string? numero;
int numero_entero;
do
{
    numero = Console.ReadLine();
    numero_entero = int.Parse(numero);

} while (numero_entero < 1000);

Console.WriteLine("correcto");
*/

/* Siguiendo con el ejercicio anterior, al ingresar uno mayor o menor a 3 cifras se mostrará el promedio de los ingresados
 * 
Console.WriteLine("Ingrese un numero con mas de 3 cifras:");
string? num;
double num_double;
double suma = 0;
int cant_ingresados = 0;
double promedio = 0;
do
{
    num = Console.ReadLine();
    num_double = double.Parse(num);
    suma += num_double;
    cant_ingresados++;
    promedio = suma / cant_ingresados;
    if (num_double < 100)
    {
        Console.WriteLine($"El promedio es de {promedio}:");
    }
} while (num_double < 1000);
Console.WriteLine("Perfecto, ingresaste un numero de 4 cifras o mas");
*/

/*
Console.WriteLine("Cuantos productos compró?");
string? cant_prod = Console.ReadLine();
int cant_prod_int = int.Parse(cant_prod);
double suma = 0;
for (int i = 1; i <= cant_prod_int; i++)
{
    Console.WriteLine("Costo unitario del producto:");
    string? costo_prod = Console.ReadLine();
    double costo_prod_double = double.Parse(costo_prod); // por lo que entendi, el enunciado pide que consultemos este dato, pero luego no debe ser utilizado en ningun momento
    Console.WriteLine("Total gastado en este producto:");
    string? total_prod = Console.ReadLine();
    double total_prod_double = double.Parse(total_prod);
    suma += total_prod_double;
}
Console.WriteLine("El total adeudado es de " + suma + ", mientras que la cantidad de productos comprados es de " + cant_prod_int);
*/

// FOR:

/* 1- El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5
 * 
Console.WriteLine("A continuacion se le pediran 5 numeros enteros, para ser sumados posteriormente");
int suma = 0;
string? num;
int num_int;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese un numero entero:");
    num = Console.ReadLine();
    num_int = int.Parse(num);
    suma += num_int;
}
Console.WriteLine("La suma total de los 5 numeros es: " + suma);
*/

/* 2- Se necesita calcular el promedio de 8 números ingresados por el usuario
 * 
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Se le pediran 8 numeros para luego sacar un promedio");
int suma = 0;
string? num;
int num_int;
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Ingrese un numero: ");
    num = Console.ReadLine();
    num_int = int.Parse(num);
    suma += num_int;
}
int promedio = suma / 8;
Console.WriteLine("El promedio es de: " + promedio);
*/

/* 3- Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total ; de unas 5 compras; informar el total adeudado
 * 
double suma = 0;
string? costo;
double costo_double;
string? total;
double total_double;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese el costo unitario del producto: ");
    costo = Console.ReadLine();
    costo_double = double.Parse(costo);
    Console.WriteLine("Ingrese el total gastado en este producto: ");
    total = Console.ReadLine();
    total_double = double.Parse(total);
    suma += total_double;
}
Console.WriteLine("El total adeudado es de: " + suma);
*/

/* 4- De una lista de 8 números indicar cual es el mayor (este lo hice sin crear listas porque no sabia como)
 * 
int mayor = 0;
string? num;
int num_int;
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Ingrese un numero");
    num = Console.ReadLine();
    num_int = int.Parse(num);
    if (num_int > mayor)
    {
        mayor = num_int;
    }
}
Console.WriteLine("El mayor es: " + mayor);
*/

/* (este es el mismo 4 pero hecho con listas)
Console.WriteLine("Se le pediran 8 numeros enteros para conformar una lista y al final se devolvera el mayor");
List<int> numeros = new List<int>();
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Ingrese un numero entero:");
    int numero = int.Parse(Console.ReadLine());
    numeros.Add(numero);
}
int mayor = numeros.Max();
Console.WriteLine("El mayor es: " + mayor);
*/

/* 5- El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más
 * 
Dictionary<string, double> datos = new Dictionary<string, double>();
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese su nombre:");
    string? nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el total gastado:");
    double total = double.Parse(Console.ReadLine());
    datos.Add(nombre, total);
}
double mayor_valor = 0;
string? nombre_del_mayor = null;
foreach (KeyValuePair<string, double> par in datos)
{
    if (par.Value > mayor_valor)
    {
        mayor_valor = par.Value;
        nombre_del_mayor = par.Key;
    }
}
Console.WriteLine("Quien mas gasto es " + nombre_del_mayor + ", con un total gastado de " + mayor_valor);
*/

/* 1 y 2-
Console.WriteLine("Inserte los valores de sus ventas, cuando esten todos los valores ingresados, ponga 0 o un numero menor: ");
string valor = Console.ReadLine();
double valor_double = double.Parse(valor);
double suma = 0;
int cantidad_numeros = 0;
while (valor_double > 0)
{
    suma += valor_double;
    Console.WriteLine("La suma hasta el momento es de: " + suma);
    Console.WriteLine("Ingresar valor: ");
    valor = Console.ReadLine();
    valor_double = double.Parse(valor);
    cantidad_numeros++;
}
Console.WriteLine("La suma final es de: " + suma);
double promedio = suma / cantidad_numeros;
Console.WriteLine("El promedio es de: " + promedio);
*/

/* 3- El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos; el sistema informará cuántos nombres se han ingresado.
Console.WriteLine("Ingrese nombres que se guardaran en una lista, cuando haya finalizado, ingrese un dato vacio");
List<string> nombres = new List<string>();
string nombre = Console.ReadLine();
int cantidad_nombres = 0;
nombres.Add(nombre);
while (nombre != "")
{
    Console.WriteLine("Ingrese un nombre:");
    nombre = Console.ReadLine();
    nombres.Add(nombre);
    cantidad_nombres++;
}
Console.WriteLine("La cantidad de nombres ingresados es: " + cantidad_nombres);
*/

/* 4- Para calcular el total de una factura, el usuario ingresará pares de datos Costo y Total ; cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.
Console.WriteLine("Se le pediran pares de datos costo y total, acordes a los datos de su factura. Cuando haya finalizado, ingrese 0 en una peticion de costo");
Dictionary<double, double> costos_totales = new Dictionary<double, double>();
Console.WriteLine("Ingrese el costo:");
double costo = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el total:");
double total = double.Parse(Console.ReadLine());
costos_totales.Add(costo, total);
double total_adeudado = total;
while (costo != 0)
{
    Console.WriteLine("Ingrese el costo:");
    costo = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el total:");
    total = double.Parse(Console.ReadLine());
    costos_totales.Add(costo, total);
    total_adeudado += total;
}
Console.WriteLine("El total adeudado es: " + total_adeudado);
*/

/* 5- Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró; luego el sistema solicitará que ingrese el total y costo de cada uno de esos productos consumidos; al terminar informará el total adeudado por el cliente. 
Console.WriteLine("Cuantos productos compró?");
string? cant_prod = Console.ReadLine();
int cant_prod_int = int.Parse(cant_prod);
double suma = 0;
for (int i = 1; i <= cant_prod_int; i++)
{
    Console.WriteLine("Costo unitario del producto:");
    string? costo_prod = Console.ReadLine();
    double costo_prod_double = double.Parse(costo_prod); // por lo que entendi, el enunciado pide que consultemos este dato, pero luego no debe ser utilizado en ningun momento
    Console.WriteLine("Total gastado en este producto:");
    string? total_prod = Console.ReadLine();
    double total_prod_double = double.Parse(total_prod);
    suma += total_prod_double;
}
Console.WriteLine("El total adeudado es de " + suma + ", mientras que la cantidad de productos comprados es de " + cant_prod_int);
*/
