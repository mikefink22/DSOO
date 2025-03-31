// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Se solicita al usuario ingresar un número del 1 al 7 para representar un día de la semana. El programa mostrará en la consola el día correspondiente al número ingresado.  

(1 = domingo; 2 = lunes; 3 = martes, etc)

En caso que el número no sea válido, se mostrará el mensaje 'Número inválido'. 

 */


//const int LUNES = 1, MARTES = 2, MIERCOLES = 3, JUEVES = 4, VIERNES = 5, SABADO = 6, DOMINGO = 7;

//int numDia
// Eliminé línea de constantes LUNES=1... ETC

string numDia;
string diaSemana;

Console.WriteLine("Ingrese el numero del dia");
numDia = Console.ReadLine();

switch (numDia)
{
    case "7"://DOMINGO:
        diaSemana = "DOMINGO";
        break;
    case "1"://LUNES:
        diaSemana = "LUNES";
        break;
    case "2"://MARTES:
        diaSemana = "MARTES";
        break;
    case "3"://MIERCOLES:
        diaSemana = "MIERCOLES";
        break;
    case "4"://JUEVES:
        diaSemana = "JUEVES";
        break;
    case "5"://VIERNES:
        diaSemana = "VIERNES";
        break;
    case "6"://SABADO:
        diaSemana = "SABADO";
        break;
    default:
        diaSemana = "Número inválido";
        break;
}

Console.WriteLine(diaSemana);
