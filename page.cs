using System.Text.Json;
using System.Windows.Forms;
namespace Webserver
{
    public partial class page : Form
    {
        public page()
        {
            InitializeComponent();
        }

        ServerRootRespons serverRootRespons = new ServerRootRespons();
        private async void Form1_Load(object sender, EventArgs e)
        {
            //ServerRootRespons class'ý çaðýrma          
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://457490d5-321d-438d-b2cb-d6f0f1c98403.mock.pstmn.io/");
            HttpResponseMessage data = await client.GetAsync("api/webuser");
            string result = await data.Content.ReadAsStringAsync();

            //webserver içeriði result deðiþkenine çektikten sonra ServerRootRespons class'ýna atma
            serverRootRespons = JsonSerializer.Deserialize<ServerRootRespons>(result);
            if (serverRootRespons.returnCode == 0)
            {
                //istenilen veriyi döngü ile çek
                foreach (var i in serverRootRespons.data)
                {
                    dataGridView1.Rows.Add(i.id,i.webUserID,i.name,i.authType,i.email,i.password,i.readOnlyAccess,i.readWriteAccess,i.isActive);
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        veriler ver = new veriler();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
             ver.read = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
             ver.write = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            
            MessageBox.Show("read= " + ver.read+  " write= " + ver.write.ToString());

            UserForm UserFormGecis = new UserForm();
            
            UserFormGecis.Show();           
        }
    }
}
