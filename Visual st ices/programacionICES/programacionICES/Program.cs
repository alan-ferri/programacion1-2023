// See https://aka.ms/new-console-template for more information

/* Ejercicio para ver la edad 
 * 
Console.WriteLine("Ingrese su fecha de nacimiento:");
string LoQueElTipoPuso = Console.ReadLine();
//si voy a calcukar mas o menos la edad que tiene tomadno su alo de nac.
//tendria que calcular asi: 
int ElAñoDelPibeEnInt = int.Parse(LoQueElTipoPuso);

int LaEdadDelFlaco = 2023 - ElAñoDelPibeEnInt;

Console.WriteLine("Vos tenes o vas a cumplir este año: " + LaEdadDelFlaco);

*/

/* //ejemplo del for para leer 12 valores 
string LoQueElFlacoPone;

Console.WriteLine("Hola, me das alguna cadena? ");
LoQueElFlacoPone = Console.ReadLine();

if (LoQueElFlacoPone.Length > 15)
{ 
            Console.WriteLine("Mucho texto!!");
} else
{
    Console.WriteLine("bien!! tiene pocos");
}
*/

/*
 * Console.WriteLine("Hola, te voy a ir pidiendo los valores de los 12 meses ");
//me voy a crear una variable para ir llevando la suma de los montos de cada mes
int sumita = 0; 

for (int mes = 1; mes <= 12; mes ++)
{
    Console.WriteLine("Poneme el valor del mes: " + mes);
    string valor = Console.ReadLine();
    sumita = sumita + int.Parse(valor);
}
Console.WriteLine("El valor total del año es: " + sumita);
*/



/*
 //este es un ejemplo con while hasta que ponga 0 
Console.WriteLine("Poneme las ventas y cuando no tengas mas poneme un 0 ");
Console.WriteLine("ingrese un valor: ");
int sumita = 0;

String valor = Console.ReadLine();
int valorInt = int.Parse(valor);

while (valorInt >0)
{
    sumita = sumita + valorInt;

    Console.WriteLine("Ingresa valor:  ");
    valor = Console.ReadLine();
    valorInt = int.Parse(valor);
}
Console.WriteLine("al final de todo vendiste: " + sumita);
*/




//ejercicio de class

//Ejer: Un alumno ingresará las notas de las 9 materias que tuvo durante el año, mostrar el Promedio de las mismas.

/*
 * Console.WriteLine("Ingresa tus notas:  ");

int sumita = 0;

for (int nota = 1; nota <= 9; nota++)
{
    Console.WriteLine("Ingresa la siguiente nota: " + nota);
    string valor = Console.ReadLine();
    sumita = sumita + int.Parse(valor);
}
Console.WriteLine("Nota final: " + sumita / 9 );
*/




