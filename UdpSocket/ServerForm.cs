using System.Threading;
using System.Windows.Forms;

namespace UdpSocket
{
    public partial class ServerForm : Form
    {
        private Server server; // Variável local que vai receber uma instancia da classe Server.

        // Ctor.
        public ServerForm()
        {
            server = new Server(this); // Instanciando Server e passando a própria classe como argumento.
            InitializeComponent(); // Inicializando Form.
        }

        // Evento de load do Form.
        private void ServerForm_Load(object sender, System.EventArgs e)
        {
            new Thread(new ThreadStart(() => new ClientForm().ShowDialog())).Start(); // Instanciando e iniciando thread que cuida do ClientForm.
        }

        // Evento de clique no botão de start do servidor.
        private void BtnStartServer_Click(object sender, System.EventArgs e)
        {
            BtnStartServer.Enabled = false; // Desabilitando botão de start.
            BtnStopServer.Enabled = true; // Habiitando botão de stop.

            server.StartServer(int.Parse(textBoxPort.Text)); // Iniciando servidor com host e porta.

            SetText("Server started..."); // Setando mensagem que confirma o start do servidor.
        }
        
        // Evento de clique no botão de stop do servidor.
        private void BtnStopServer_Click(object sender, System.EventArgs e)
        {
            BtnStartServer.Enabled = true; // Habiitando botão de start.
            BtnStopServer.Enabled = false; // Desabilitando botão de stop.

            server.StopServer(); // Parando o servidor.

            SetText("Server stopped..."); // Setando mensagem que confirma o stop do servidor.
        }

        delegate void SetTextCallback(string text); // Delegando a execução do método que seta a mensagem.
        // Método que seta a mensagem.
        public void SetText(string text)
        {
            if (ListServerInformations.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                ListServerInformations.Items.Add(text);
            }
        }
    }
}
