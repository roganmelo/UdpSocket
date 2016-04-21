using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UdpSocket
{
    public class Server
    {
        private string host; // Nome do host.
        private int port; // Número da porta.
        private ServerForm serverForm; // Variável local que vai receber a instancia do ServerForm via construtor.
        private Thread thread; // Thread responsável pelo processamento do servidor.
        private UdpClient udpClient; // Classe que fornece serviços de rede no protocolo udp.
        private IPEndPoint remoteIpEndPoint; // Variável local que vai receber a instancia do 
        private byte[] receivedBytes; // Array de bytes que vai receber os dados recebidos no formato de bytes. 

        // Ctor.
        public Server(ServerForm serverForm)
        {
            this.serverForm = serverForm; // Recebendo a instancia do ServerForm via construtor.
        }

        // Método que inicia o servidor.
        public void StartServer(int port)
        {
            this.port = port; // Setando a porta na variável local.

            thread = new Thread(new ThreadStart(StartThreadServer)); // Instanciando thread que inicia o servidor.
            thread.Start(); // Iniciando o processamento da thread. 
        }

        // Método que será executado pela thread.
        private void StartThreadServer()
        {
            try
            {
                udpClient = new UdpClient(port); // Instanciando e iniciando o servidor na porta tal.

                // Loop que garante que o servidor ficará escutando.
                while (true)
                {
                    remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0); // Representa um ponto de extremidade de rede.
                    receivedBytes = udpClient.Receive(ref remoteIpEndPoint); // Recebe os bytes enviados pelo cliente.
                    serverForm.SetText(Encoding.ASCII.GetString(receivedBytes).ToString()); // Converte e joga na tela.
                }
            }
            catch { } // Tratando  exception.
        }

        // Método que para o servidor.
        public void StopServer()
        {
            udpClient.Close(); // Fecha a conexão udp.
            thread.Abort(); // Encerra a thread.
        }
    }
}
