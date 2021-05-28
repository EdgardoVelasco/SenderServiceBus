using System;
using Azure.Messaging.ServiceBus;
using SenderServiceBus.bus;
namespace SenderServiceBus
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = Busclient.Cliente;
            Console.WriteLine("-.-.-.Sender de mensajes-.-.");
            Console.WriteLine("mensaje a enviar: ");
            var mensaje = Console.ReadLine();
            SendMessage(cliente, mensaje);

            Console.ReadLine();
            
        }

        private static async void SendMessage(ServiceBusClient cliente, string mensaje) {
            var sender = cliente.CreateSender("tienda");
            await sender.SendMessageAsync(new ServiceBusMessage(mensaje));
            Console.WriteLine("Se ha enviado el mensaje");
        }
    }
}
