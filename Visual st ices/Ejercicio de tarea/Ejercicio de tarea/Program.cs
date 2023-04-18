// See https://aka.ms/new-console-template for more information

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

/* Console.WriteLine("Ingresar numeros");
string? numero;
int numero_entero;
do
{
    numero = Console.ReadLine();
    numero_entero = int.Parse(numero);

} while (numero_entero < 1000);

Console.WriteLine("correcto");
*/

/*
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

List<string> ListaString = new List<string>();
ListaString.Add("Alan");

  