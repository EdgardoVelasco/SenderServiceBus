using System;
using System.Collections.Generic;
using System.Text;
using Azure.Messaging.ServiceBus;


namespace SenderServiceBus.bus
{
    class Busclient
    {
        private static readonly string CONN_STRING = "Endpoint=sb://serviceenvf.servicebus.windows.net/;SharedAccessKeyName=Sender;SharedAccessKey=KwkaOMsG/5rNXEZTWyolBy38zgsllR5cvZPI3nQHfcY=";
        

        public static ServiceBusClient Cliente { get; private set; }

        static Busclient() { InitBus(); }

        private static void InitBus() {
            if (Cliente==null) {
                Cliente = new ServiceBusClient(CONN_STRING);
            }
        }


    }
}
