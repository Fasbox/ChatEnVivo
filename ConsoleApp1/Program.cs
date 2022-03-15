// See https://aka.ms/new-console-template for more information
using ServidorConsola.Model;

Console.WriteLine("Proyecto iniciado");
Console.WriteLine("Es este el servidor? ingrese 1 para afirmar");
string respuesta = Console.ReadLine();
if (respuesta == "1")
{
    Console.WriteLine("Ingrese la Ip: ");
    string ip = Console.ReadLine();
    Console.WriteLine("Ingrese el puerto: ");
    int port = Int32.Parse(Console.ReadLine());
    var servidor = new ServerProgram(ip, port);
}
