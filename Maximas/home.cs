using System.Windows.Forms;

namespace Maximas
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
            connection con = new connection();
            skin skin = new skin();
            // client data
            string queryClients = "SELECT name, industry FROM Clients";
            con.LoadData(queryClients, clientData);
            skin.style(clientData);
            // simulation data
            string queryOperation = "SELECT clientID, duration FROM operations";
            con.LoadData(queryOperation, operationData);
            skin.style(operationData);
        }
    }
}
