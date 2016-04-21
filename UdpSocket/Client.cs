using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UdpSocket
{
    public class Client
    {
        private UdpClient udpClient; // Classe que fornece serviços de rede no protocolo udp.
        private byte[] sendBytes; // Array de bytes que vai receber os dados convertidos em bytes.

        // Ctor.
        public Client()
        {
            udpClient = new UdpClient(); // Instanciando UdpClient.
        }

        // Método para conectar e enviar menssagens que recebe o host, a porta, o nome do usuário e a mensagem.
        public void SendMessage(string hostName, string port, string name, string message)
        {
            udpClient.Connect(hostName, int.Parse(port)); // Conectando ao servidor na porta tal do host tal.
            sendBytes = Encoding.ASCII.GetBytes(name + ": " + message); // Conversão da mensagem em bytes.
            udpClient.Send(sendBytes, sendBytes.Length); // Enviando a mensagem no formato de bytes.
        }
    }
}
