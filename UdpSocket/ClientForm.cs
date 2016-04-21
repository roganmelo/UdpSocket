using System.Windows.Forms;

namespace UdpSocket
{
    public partial class ClientForm : Form
    {
        private Client client; // Variável local que vai receber uma instancia da classe Cliente.

        // Ctor.
        public ClientForm()
        {
            client = new Client(); // Instanciando Client.
            InitializeComponent(); // Inicializando Form.
        }

        // Evento de clique no botão de enviar mensagem.
        private void BtnSendMessage_Click(object sender, System.EventArgs e)
        {
            // Chamando o método de enviar mensagem passando o host, a porta, o nome do usuário e a mensagem.
            client.SendMessage(TextBoxHostName.Text, TextBoxPort.Text, TextBoxName.Text, TextBoxMessage.Text);
        }
    }
}
