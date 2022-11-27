namespace databases_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show_games = new System.Windows.Forms.Button();
            this.show_customers = new System.Windows.Forms.Button();
            this.show_employees = new System.Windows.Forms.Button();
            this.show_sales = new System.Windows.Forms.Button();
            this.games_join_sales = new System.Windows.Forms.Button();
            this.customers_join_sales = new System.Windows.Forms.Button();
            this.employees_join_sales = new System.Windows.Forms.Button();
            this.join_all = new System.Windows.Forms.Button();
            this.Query = new System.Windows.Forms.RichTextBox();
            this.run_query = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(519, 375);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // show_games
            // 
            this.show_games.Location = new System.Drawing.Point(12, 63);
            this.show_games.Name = "show_games";
            this.show_games.Size = new System.Drawing.Size(113, 42);
            this.show_games.TabIndex = 2;
            this.show_games.Text = "Show Games";
            this.show_games.UseVisualStyleBackColor = true;
            this.show_games.Click += new System.EventHandler(this.show_games_Click);
            // 
            // show_customers
            // 
            this.show_customers.Location = new System.Drawing.Point(131, 63);
            this.show_customers.Name = "show_customers";
            this.show_customers.Size = new System.Drawing.Size(113, 42);
            this.show_customers.TabIndex = 3;
            this.show_customers.Text = "Show Customers";
            this.show_customers.UseVisualStyleBackColor = true;
            this.show_customers.Click += new System.EventHandler(this.show_customers_Click);
            // 
            // show_employees
            // 
            this.show_employees.Location = new System.Drawing.Point(12, 111);
            this.show_employees.Name = "show_employees";
            this.show_employees.Size = new System.Drawing.Size(113, 42);
            this.show_employees.TabIndex = 4;
            this.show_employees.Text = "Show Employees";
            this.show_employees.UseVisualStyleBackColor = true;
            this.show_employees.Click += new System.EventHandler(this.show_employees_Click);
            // 
            // show_sales
            // 
            this.show_sales.Location = new System.Drawing.Point(131, 111);
            this.show_sales.Name = "show_sales";
            this.show_sales.Size = new System.Drawing.Size(113, 42);
            this.show_sales.TabIndex = 5;
            this.show_sales.Text = "Show Sales";
            this.show_sales.UseVisualStyleBackColor = true;
            this.show_sales.Click += new System.EventHandler(this.show_sales_Click);
            // 
            // games_join_sales
            // 
            this.games_join_sales.Location = new System.Drawing.Point(12, 159);
            this.games_join_sales.Name = "games_join_sales";
            this.games_join_sales.Size = new System.Drawing.Size(113, 42);
            this.games_join_sales.TabIndex = 6;
            this.games_join_sales.Text = "Games join Sales";
            this.games_join_sales.UseVisualStyleBackColor = true;
            this.games_join_sales.Click += new System.EventHandler(this.games_join_sales_Click);
            // 
            // customers_join_sales
            // 
            this.customers_join_sales.Location = new System.Drawing.Point(131, 159);
            this.customers_join_sales.Name = "customers_join_sales";
            this.customers_join_sales.Size = new System.Drawing.Size(113, 42);
            this.customers_join_sales.TabIndex = 7;
            this.customers_join_sales.Text = "Customers join Sales";
            this.customers_join_sales.UseVisualStyleBackColor = true;
            this.customers_join_sales.Click += new System.EventHandler(this.customers_join_sales_Click);
            // 
            // employees_join_sales
            // 
            this.employees_join_sales.Location = new System.Drawing.Point(12, 207);
            this.employees_join_sales.Name = "employees_join_sales";
            this.employees_join_sales.Size = new System.Drawing.Size(113, 42);
            this.employees_join_sales.TabIndex = 8;
            this.employees_join_sales.Text = "Employees join Sales";
            this.employees_join_sales.UseVisualStyleBackColor = true;
            this.employees_join_sales.Click += new System.EventHandler(this.employees_join_sales_Click);
            // 
            // join_all
            // 
            this.join_all.Location = new System.Drawing.Point(131, 207);
            this.join_all.Name = "join_all";
            this.join_all.Size = new System.Drawing.Size(113, 42);
            this.join_all.TabIndex = 9;
            this.join_all.Text = "Join all tables";
            this.join_all.UseVisualStyleBackColor = true;
            this.join_all.Click += new System.EventHandler(this.join_all_Click);
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(12, 255);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(232, 135);
            this.Query.TabIndex = 10;
            this.Query.Text = "Query";
            this.Query.TextChanged += new System.EventHandler(this.Query_TextChanged);
            // 
            // run_query
            // 
            this.run_query.Location = new System.Drawing.Point(12, 396);
            this.run_query.Name = "run_query";
            this.run_query.Size = new System.Drawing.Size(232, 42);
            this.run_query.TabIndex = 11;
            this.run_query.Text = "Run Query";
            this.run_query.UseVisualStyleBackColor = true;
            this.run_query.Click += new System.EventHandler(this.run_query_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.run_query);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.join_all);
            this.Controls.Add(this.employees_join_sales);
            this.Controls.Add(this.customers_join_sales);
            this.Controls.Add(this.games_join_sales);
            this.Controls.Add(this.show_sales);
            this.Controls.Add(this.show_employees);
            this.Controls.Add(this.show_customers);
            this.Controls.Add(this.show_games);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button show_games;
        private Button show_customers;
        private Button show_employees;
        private Button show_sales;
        private Button games_join_sales;
        private Button customers_join_sales;
        private Button employees_join_sales;
        private Button join_all;
        private RichTextBox Query;
        private Button run_query;
    }
}