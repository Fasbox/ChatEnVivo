// See https://aka.ms/new-console-template for more information
/// <summary>
/// Programa de consola par iniciar el servidor remoto y poder conectar los clientes
/// </summary>
Console.WriteLine("Proyecto iniciado");
Console.WriteLine("Es este el servidor? ingrese 1 para afirmar");
string respuesta = Console.ReadLine();
if (respuesta == "1")
{while (true)
    {
        try
        {
            Console.WriteLine("Ingrese la Ip: ");
            string ip = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese el puerto: ");
                    int port = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Ingreso erroneo, el valor para el puerto deben ser solo numeros.");
                    Console.ReadLine();
                    Console.Clear();
                }
                
            }
            var servidor = new ServerProgram(ip, port);
            break;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al tratar de crear el servidor, verifique que su ip sea correcto o el puerto este disponible.");
            Console.ReadLine();
            Console.Clear();
        }
    }
   
}