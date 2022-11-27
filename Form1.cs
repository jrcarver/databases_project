using System.Data;
using System.Data.SQLite;
using System.Security.AccessControl;

namespace databases_project
{
    public partial class Form1 : Form
    {
        // database path
        string path = "BoardGameStore.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // show Games table data
        private void button1_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=" + path);

            // command object
            string query = "SELECT * FROM Games";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            // datatable
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            // insert data into dataGrid
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}