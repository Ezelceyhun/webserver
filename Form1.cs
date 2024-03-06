using System.Text.Json;

namespace Webserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServerRootRespons serverRootRespons = new ServerRootRespons();
        private async void Form1_Load(object sender, EventArgs e)
        {
            //ServerRootRespons class'ý çaðýrma          
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://9fa4da70-7dca-4859-be70-bddd4820b8c3.mock.pstmn.io/");
            HttpResponseMessage data = await client.GetAsync("api/webuser");
            string result = await data.Content.ReadAsStringAsync();

            //webserver içeriði result deðiþkenine çektikten sonra ServerRootRespons class'ýna atma
            serverRootRespons = JsonSerializer.Deserialize<ServerRootRespons>(result);
            if (serverRootRespons.returnCode == 0)
            {
                //istenilen veriyi döngü ile çek
                foreach (var i in serverRootRespons.data)
                {
                    dataGridView1.Rows.Add(i.id.ToString());
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //string b = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(a.ToString());
        }
    }
}
