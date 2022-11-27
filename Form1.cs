using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace databases_project
{
    public partial class Form1 : Form
    {
        // database path
        string path = "BoardGameStore.db";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // show Games table data
        private void show_games_Click(object sender, EventArgs e)
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

        private void show_customers_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=" + path);

            // command object
            string query = "SELECT * FROM Customers";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            // datatable
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            // insert data into dataGrid
            dataGridView1.DataSource = dt;
        }

        private void show_sales_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=" + path);

            // command object
            string query = "SELECT * FROM Sales";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            // datatable
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            // insert data into dataGrid
            dataGridView1.DataSource = dt;
        }

        private void show_employees_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=" + path);

            // command object
            string query = "SELECT * FROM Employees";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            // datatable
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            // insert data into dataGrid
            dataGridView1.DataSource = dt;
        }

        private void games_join_sales_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=" + path);

            // command object
            string query = "SELECT S.ID AS saleID, G.ID AS gameID, G.game, G.price, S.custEmail, S.empEmail, S.date FROM Games G INNER JOIN Sales S ON G.ID = S.gameID";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            // datatable
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            // insert data into dataGrid
            dataGridView1.DataSource = dt;
        }

        private void customers_join_sales_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=" + path);

            // command object
            string query = "SELECT S.ID, C.email AS custEmail, C.lastName AS custLast, C.firstName AS custFirst, C.phone AS custPhone, S.empEmail, S.date FROM Customers C INNER JOIN Sales S ON C.email = S.custEmail";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            // datatable
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            // insert data into dataGrid
            dataGridView1.DataSource = dt;
        }

        private void employees_join_sales_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=" + path);

            // command object
            string query = "SELECT S.ID, S.gameID, S.custEmail, S.empEmail, E.lastName AS empLast, E.firstName AS empFirst, E.phone AS empPhone, S.date FROM Employees E INNER JOIN Sales S ON E.Email = S.empEmail";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            // datatable
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            // insert data into dataGrid
            dataGridView1.DataSource = dt;
        }

        private void join_all_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source=" + path);

            // command object
            string query = "SELECT S.ID AS saleID, G.game, G.price, S.custEmail, C.lastName AS custLast, C.firstName AS custFirst, C.phone AS custPhone, S.empEmail, E.lastName AS empLast, E.firstName AS empFirst, E.phone AS empPhone, S.date FROM Games G INNER JOIN Sales S ON G.ID = S.gameID INNER JOIN Customers C ON C.email = S.custEmail INNER JOIN Employees E ON E.email = S.empEmail";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            // datatable
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            // insert data into dataGrid
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}