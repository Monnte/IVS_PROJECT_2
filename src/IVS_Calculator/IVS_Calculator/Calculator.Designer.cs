namespace IVS_Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.UserInput = new System.Windows.Forms.TextBox();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_oper_root2 = new System.Windows.Forms.Button();
            this.button_oper_power2 = new System.Windows.Forms.Button();
            this.button_oper_fraction = new System.Windows.Forms.Button();
            this.button_oper_abs = new System.Windows.Forms.Button();
            this.button_oper_root = new System.Windows.Forms.Button();
            this.button_oper_power = new System.Windows.Forms.Button();
            this.button_oper_factorial = new System.Windows.Forms.Button();
            this.button_oper_del = new System.Windows.Forms.Button();
            this.button_oper_c = new System.Windows.Forms.Button();
            this.button_oper_ce = new System.Windows.Forms.Button();
            this.button_oper_percent = new System.Windows.Forms.Button();
            this.button_oper_equal = new System.Windows.Forms.Button();
            this.button_oper_dot = new System.Windows.Forms.Button();
            this.button_num_0 = new System.Windows.Forms.Button();
            this.button_oper_change = new System.Windows.Forms.Button();
            this.button_num_1 = new System.Windows.Forms.Button();
            this.button_num_4 = new System.Windows.Forms.Button();
            this.button_num_7 = new System.Windows.Forms.Button();
            this.button_num_2 = new System.Windows.Forms.Button();
            this.button_num_5 = new System.Windows.Forms.Button();
            this.button_num_8 = new System.Windows.Forms.Button();
            this.button_num_3 = new System.Windows.Forms.Button();
            this.button_num_6 = new System.Windows.Forms.Button();
            this.button_num_9 = new System.Windows.Forms.Button();
            this.button_oper_plus = new System.Windows.Forms.Button();
            this.button_oper_minus = new System.Windows.Forms.Button();
            this.button_oper_multiply = new System.Windows.Forms.Button();
            this.button_oper_division = new System.Windows.Forms.Button();
            this.MemoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.button_memory_minus = new System.Windows.Forms.Button();
            this.button_memory_plus = new System.Windows.Forms.Button();
            this.button_memory_mr = new System.Windows.Forms.Button();
            this.button_memory_mc = new System.Windows.Forms.Button();
            this.button_memory_ms = new System.Windows.Forms.Button();
            this.CalculationBox = new System.Windows.Forms.Label();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.button_pivo = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonPanel.SuspendLayout();
            this.MemoryTable.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.UserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserInput.ForeColor = System.Drawing.Color.White;
            this.UserInput.Location = new System.Drawing.Point(9, 44);
            this.UserInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserInput.Name = "UserInput";
            this.UserInput.ReadOnly = true;
            this.UserInput.Size = new System.Drawing.Size(384, 46);
            this.UserInput.TabIndex = 1;
            this.UserInput.TabStop = false;
            this.UserInput.Tag = "";
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            this.UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInput_KeyPress);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ButtonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Controls.Add(this.button_oper_root2, 2, 2);
            this.ButtonPanel.Controls.Add(this.button_oper_power2, 1, 2);
            this.ButtonPanel.Controls.Add(this.button_oper_fraction, 0, 2);
            this.ButtonPanel.Controls.Add(this.button_oper_abs, 3, 1);
            this.ButtonPanel.Controls.Add(this.button_oper_root, 2, 1);
            this.ButtonPanel.Controls.Add(this.button_oper_power, 1, 1);
            this.ButtonPanel.Controls.Add(this.button_oper_factorial, 0, 1);
            this.ButtonPanel.Controls.Add(this.button_oper_del, 3, 0);
            this.ButtonPanel.Controls.Add(this.button_oper_c, 2, 0);
            this.ButtonPanel.Controls.Add(this.button_oper_ce, 1, 0);
            this.ButtonPanel.Controls.Add(this.button_oper_percent, 0, 0);
            this.ButtonPanel.Controls.Add(this.button_oper_equal, 3, 6);
            this.ButtonPanel.Controls.Add(this.button_oper_dot, 2, 6);
            this.ButtonPanel.Controls.Add(this.button_num_0, 1, 6);
            this.ButtonPanel.Controls.Add(this.button_oper_change, 0, 6);
            this.ButtonPanel.Controls.Add(this.button_num_1, 0, 5);
            this.ButtonPanel.Controls.Add(this.button_num_4, 0, 4);
            this.ButtonPanel.Controls.Add(this.button_num_7, 0, 3);
            this.ButtonPanel.Controls.Add(this.button_num_2, 1, 5);
            this.ButtonPanel.Controls.Add(this.button_num_5, 1, 4);
            this.ButtonPanel.Controls.Add(this.button_num_8, 1, 3);
            this.ButtonPanel.Controls.Add(this.button_num_3, 2, 5);
            this.ButtonPanel.Controls.Add(this.button_num_6, 2, 4);
            this.ButtonPanel.Controls.Add(this.button_num_9, 2, 3);
            this.ButtonPanel.Controls.Add(this.button_oper_plus, 3, 5);
            this.ButtonPanel.Controls.Add(this.button_oper_minus, 3, 4);
            this.ButtonPanel.Controls.Add(this.button_oper_multiply, 3, 3);
            this.ButtonPanel.Controls.Add(this.button_oper_division, 3, 2);
            this.ButtonPanel.Location = new System.Drawing.Point(0, 130);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 7;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.ButtonPanel.Size = new System.Drawing.Size(403, 388);
            this.ButtonPanel.TabIndex = 2;
            // 
            // button_oper_root2
            // 
            this.button_oper_root2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_root2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_root2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_root2.FlatAppearance.BorderSize = 0;
            this.button_oper_root2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_root2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_root2.ForeColor = System.Drawing.Color.White;
            this.button_oper_root2.Location = new System.Drawing.Point(202, 112);
            this.button_oper_root2.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_root2.Name = "button_oper_root2";
            this.button_oper_root2.Size = new System.Drawing.Size(96, 51);
            this.button_oper_root2.TabIndex = 28;
            this.button_oper_root2.Text = "²√x";
            this.button_oper_root2.UseCompatibleTextRendering = true;
            this.button_oper_root2.UseVisualStyleBackColor = false;
            this.button_oper_root2.Click += new System.EventHandler(this.OperationsOnClick);
            this.button_oper_root2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_power2
            // 
            this.button_oper_power2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_power2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_power2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_power2.FlatAppearance.BorderSize = 0;
            this.button_oper_power2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_power2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_power2.ForeColor = System.Drawing.Color.White;
            this.button_oper_power2.Location = new System.Drawing.Point(102, 112);
            this.button_oper_power2.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_power2.Name = "button_oper_power2";
            this.button_oper_power2.Size = new System.Drawing.Size(96, 51);
            this.button_oper_power2.TabIndex = 27;
            this.button_oper_power2.Text = "x²";
            this.button_oper_power2.UseCompatibleTextRendering = true;
            this.button_oper_power2.UseVisualStyleBackColor = false;
            this.button_oper_power2.Click += new System.EventHandler(this.OperationsOnClick);
            this.button_oper_power2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_fraction
            // 
            this.button_oper_fraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_fraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_fraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_fraction.FlatAppearance.BorderSize = 0;
            this.button_oper_fraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_fraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_fraction.ForeColor = System.Drawing.Color.White;
            this.button_oper_fraction.Location = new System.Drawing.Point(2, 112);
            this.button_oper_fraction.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_fraction.Name = "button_oper_fraction";
            this.button_oper_fraction.Size = new System.Drawing.Size(96, 51);
            this.button_oper_fraction.TabIndex = 26;
            this.button_oper_fraction.Text = "1/x";
            this.button_oper_fraction.UseCompatibleTextRendering = true;
            this.button_oper_fraction.UseVisualStyleBackColor = false;
            this.button_oper_fraction.Click += new System.EventHandler(this.OperationsOnClick);
            this.button_oper_fraction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_abs
            // 
            this.button_oper_abs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_abs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_abs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_abs.FlatAppearance.BorderSize = 0;
            this.button_oper_abs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_abs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_abs.ForeColor = System.Drawing.Color.White;
            this.button_oper_abs.Location = new System.Drawing.Point(302, 57);
            this.button_oper_abs.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_abs.Name = "button_oper_abs";
            this.button_oper_abs.Size = new System.Drawing.Size(99, 51);
            this.button_oper_abs.TabIndex = 25;
            this.button_oper_abs.Text = "|x|";
            this.button_oper_abs.UseCompatibleTextRendering = true;
            this.button_oper_abs.UseVisualStyleBackColor = false;
            this.button_oper_abs.Click += new System.EventHandler(this.OperationsOnClick);
            // 
            // button_oper_root
            // 
            this.button_oper_root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_root.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_root.FlatAppearance.BorderSize = 0;
            this.button_oper_root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_root.ForeColor = System.Drawing.Color.White;
            this.button_oper_root.Location = new System.Drawing.Point(202, 57);
            this.button_oper_root.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_root.Name = "button_oper_root";
            this.button_oper_root.Size = new System.Drawing.Size(96, 51);
            this.button_oper_root.TabIndex = 6;
            this.button_oper_root.Text = "ⁿ√x";
            this.button_oper_root.UseCompatibleTextRendering = true;
            this.button_oper_root.UseVisualStyleBackColor = false;
            this.button_oper_root.Click += new System.EventHandler(this.ButtonRoot_Click);
            this.button_oper_root.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_power
            // 
            this.button_oper_power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_power.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_power.FlatAppearance.BorderSize = 0;
            this.button_oper_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_power.ForeColor = System.Drawing.Color.White;
            this.button_oper_power.Location = new System.Drawing.Point(102, 57);
            this.button_oper_power.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_power.Name = "button_oper_power";
            this.button_oper_power.Size = new System.Drawing.Size(96, 51);
            this.button_oper_power.TabIndex = 5;
            this.button_oper_power.Text = "xⁿ";
            this.button_oper_power.UseCompatibleTextRendering = true;
            this.button_oper_power.UseVisualStyleBackColor = false;
            this.button_oper_power.Click += new System.EventHandler(this.ButtonPower_Click);
            this.button_oper_power.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_factorial
            // 
            this.button_oper_factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_factorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_factorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_factorial.FlatAppearance.BorderSize = 0;
            this.button_oper_factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_factorial.ForeColor = System.Drawing.Color.White;
            this.button_oper_factorial.Location = new System.Drawing.Point(2, 57);
            this.button_oper_factorial.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_factorial.Name = "button_oper_factorial";
            this.button_oper_factorial.Size = new System.Drawing.Size(96, 51);
            this.button_oper_factorial.TabIndex = 4;
            this.button_oper_factorial.Text = "x!";
            this.button_oper_factorial.UseCompatibleTextRendering = true;
            this.button_oper_factorial.UseVisualStyleBackColor = false;
            this.button_oper_factorial.Click += new System.EventHandler(this.OperationsOnClick);
            this.button_oper_factorial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_del
            // 
            this.button_oper_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_del.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_del.FlatAppearance.BorderSize = 0;
            this.button_oper_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_del.ForeColor = System.Drawing.Color.White;
            this.button_oper_del.Location = new System.Drawing.Point(302, 2);
            this.button_oper_del.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_del.Name = "button_oper_del";
            this.button_oper_del.Size = new System.Drawing.Size(99, 51);
            this.button_oper_del.TabIndex = 3;
            this.button_oper_del.Text = "DEL";
            this.button_oper_del.UseCompatibleTextRendering = true;
            this.button_oper_del.UseVisualStyleBackColor = false;
            this.button_oper_del.Click += new System.EventHandler(this.ButtonDel_Click);
            this.button_oper_del.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_c
            // 
            this.button_oper_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_c.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_c.FlatAppearance.BorderSize = 0;
            this.button_oper_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_c.ForeColor = System.Drawing.Color.White;
            this.button_oper_c.Location = new System.Drawing.Point(202, 2);
            this.button_oper_c.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_c.Name = "button_oper_c";
            this.button_oper_c.Size = new System.Drawing.Size(96, 51);
            this.button_oper_c.TabIndex = 2;
            this.button_oper_c.Text = "C";
            this.button_oper_c.UseCompatibleTextRendering = true;
            this.button_oper_c.UseVisualStyleBackColor = false;
            this.button_oper_c.Click += new System.EventHandler(this.ButtonC_Click);
            this.button_oper_c.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_ce
            // 
            this.button_oper_ce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_ce.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_oper_ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_ce.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_ce.FlatAppearance.BorderSize = 0;
            this.button_oper_ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_ce.ForeColor = System.Drawing.Color.White;
            this.button_oper_ce.Location = new System.Drawing.Point(102, 2);
            this.button_oper_ce.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_ce.Name = "button_oper_ce";
            this.button_oper_ce.Size = new System.Drawing.Size(96, 51);
            this.button_oper_ce.TabIndex = 1;
            this.button_oper_ce.Text = "CE";
            this.button_oper_ce.UseCompatibleTextRendering = true;
            this.button_oper_ce.UseVisualStyleBackColor = false;
            this.button_oper_ce.Click += new System.EventHandler(this.ButtonCE_Click);
            this.button_oper_ce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_percent
            // 
            this.button_oper_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_percent.FlatAppearance.BorderSize = 0;
            this.button_oper_percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_percent.ForeColor = System.Drawing.Color.White;
            this.button_oper_percent.Location = new System.Drawing.Point(2, 2);
            this.button_oper_percent.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_percent.Name = "button_oper_percent";
            this.button_oper_percent.Size = new System.Drawing.Size(96, 51);
            this.button_oper_percent.TabIndex = 0;
            this.button_oper_percent.Text = "%";
            this.button_oper_percent.UseVisualStyleBackColor = false;
            this.button_oper_percent.Click += new System.EventHandler(this.ButtonPercent_Click);
            this.button_oper_percent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_equal
            // 
            this.button_oper_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.button_oper_equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_equal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_equal.FlatAppearance.BorderSize = 0;
            this.button_oper_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_equal.ForeColor = System.Drawing.Color.White;
            this.button_oper_equal.Location = new System.Drawing.Point(302, 332);
            this.button_oper_equal.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_equal.Name = "button_oper_equal";
            this.button_oper_equal.Size = new System.Drawing.Size(99, 54);
            this.button_oper_equal.TabIndex = 23;
            this.button_oper_equal.Text = "=";
            this.button_oper_equal.UseCompatibleTextRendering = true;
            this.button_oper_equal.UseVisualStyleBackColor = false;
            this.button_oper_equal.Click += new System.EventHandler(this.ButtonEqual_Click);
            this.button_oper_equal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_dot
            // 
            this.button_oper_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_dot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_dot.FlatAppearance.BorderSize = 0;
            this.button_oper_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_dot.ForeColor = System.Drawing.Color.White;
            this.button_oper_dot.Location = new System.Drawing.Point(202, 332);
            this.button_oper_dot.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_dot.Name = "button_oper_dot";
            this.button_oper_dot.Size = new System.Drawing.Size(96, 54);
            this.button_oper_dot.TabIndex = 22;
            this.button_oper_dot.Text = ".";
            this.button_oper_dot.UseCompatibleTextRendering = true;
            this.button_oper_dot.UseVisualStyleBackColor = false;
            this.button_oper_dot.Click += new System.EventHandler(this.ButtonDot_Click);
            this.button_oper_dot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_0
            // 
            this.button_num_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_0.FlatAppearance.BorderSize = 0;
            this.button_num_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_0.ForeColor = System.Drawing.Color.White;
            this.button_num_0.Location = new System.Drawing.Point(102, 332);
            this.button_num_0.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_0.Name = "button_num_0";
            this.button_num_0.Size = new System.Drawing.Size(96, 54);
            this.button_num_0.TabIndex = 21;
            this.button_num_0.Text = "0";
            this.button_num_0.UseCompatibleTextRendering = true;
            this.button_num_0.UseVisualStyleBackColor = false;
            this.button_num_0.Click += new System.EventHandler(this.Button0_Click);
            this.button_num_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_change
            // 
            this.button_oper_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_change.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_change.FlatAppearance.BorderSize = 0;
            this.button_oper_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_change.ForeColor = System.Drawing.Color.White;
            this.button_oper_change.Location = new System.Drawing.Point(2, 332);
            this.button_oper_change.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_change.Name = "button_oper_change";
            this.button_oper_change.Size = new System.Drawing.Size(96, 54);
            this.button_oper_change.TabIndex = 20;
            this.button_oper_change.Text = "ᐩ/₋";
            this.button_oper_change.UseCompatibleTextRendering = true;
            this.button_oper_change.UseVisualStyleBackColor = false;
            this.button_oper_change.Click += new System.EventHandler(this.ButtonChange_Click);
            this.button_oper_change.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_1
            // 
            this.button_num_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_1.FlatAppearance.BorderSize = 0;
            this.button_num_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_1.ForeColor = System.Drawing.Color.White;
            this.button_num_1.Location = new System.Drawing.Point(2, 277);
            this.button_num_1.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_1.Name = "button_num_1";
            this.button_num_1.Size = new System.Drawing.Size(96, 51);
            this.button_num_1.TabIndex = 16;
            this.button_num_1.Text = "1";
            this.button_num_1.UseCompatibleTextRendering = true;
            this.button_num_1.UseVisualStyleBackColor = false;
            this.button_num_1.Click += new System.EventHandler(this.Button1_Click);
            this.button_num_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_4
            // 
            this.button_num_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_4.FlatAppearance.BorderSize = 0;
            this.button_num_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_4.ForeColor = System.Drawing.Color.White;
            this.button_num_4.Location = new System.Drawing.Point(2, 222);
            this.button_num_4.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_4.Name = "button_num_4";
            this.button_num_4.Size = new System.Drawing.Size(96, 51);
            this.button_num_4.TabIndex = 12;
            this.button_num_4.Text = "4";
            this.button_num_4.UseCompatibleTextRendering = true;
            this.button_num_4.UseVisualStyleBackColor = false;
            this.button_num_4.Click += new System.EventHandler(this.Button4_Click);
            this.button_num_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_7
            // 
            this.button_num_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_7.FlatAppearance.BorderSize = 0;
            this.button_num_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_7.ForeColor = System.Drawing.Color.White;
            this.button_num_7.Location = new System.Drawing.Point(2, 167);
            this.button_num_7.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_7.Name = "button_num_7";
            this.button_num_7.Size = new System.Drawing.Size(96, 51);
            this.button_num_7.TabIndex = 8;
            this.button_num_7.Text = "7";
            this.button_num_7.UseCompatibleTextRendering = true;
            this.button_num_7.UseVisualStyleBackColor = false;
            this.button_num_7.Click += new System.EventHandler(this.Button7_Click);
            this.button_num_7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_2
            // 
            this.button_num_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_2.FlatAppearance.BorderSize = 0;
            this.button_num_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_2.ForeColor = System.Drawing.Color.White;
            this.button_num_2.Location = new System.Drawing.Point(102, 277);
            this.button_num_2.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_2.Name = "button_num_2";
            this.button_num_2.Size = new System.Drawing.Size(96, 51);
            this.button_num_2.TabIndex = 24;
            this.button_num_2.Text = "2";
            this.button_num_2.UseCompatibleTextRendering = true;
            this.button_num_2.UseVisualStyleBackColor = false;
            this.button_num_2.Click += new System.EventHandler(this.Button2_Click);
            this.button_num_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_5
            // 
            this.button_num_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_5.FlatAppearance.BorderSize = 0;
            this.button_num_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_5.ForeColor = System.Drawing.Color.White;
            this.button_num_5.Location = new System.Drawing.Point(102, 222);
            this.button_num_5.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_5.Name = "button_num_5";
            this.button_num_5.Size = new System.Drawing.Size(96, 51);
            this.button_num_5.TabIndex = 13;
            this.button_num_5.Text = "5";
            this.button_num_5.UseCompatibleTextRendering = true;
            this.button_num_5.UseVisualStyleBackColor = false;
            this.button_num_5.Click += new System.EventHandler(this.Button5_Click);
            this.button_num_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_8
            // 
            this.button_num_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_8.FlatAppearance.BorderSize = 0;
            this.button_num_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_8.ForeColor = System.Drawing.Color.White;
            this.button_num_8.Location = new System.Drawing.Point(102, 167);
            this.button_num_8.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_8.Name = "button_num_8";
            this.button_num_8.Size = new System.Drawing.Size(96, 51);
            this.button_num_8.TabIndex = 9;
            this.button_num_8.Text = "8";
            this.button_num_8.UseCompatibleTextRendering = true;
            this.button_num_8.UseVisualStyleBackColor = false;
            this.button_num_8.Click += new System.EventHandler(this.Button8_Click);
            this.button_num_8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_3
            // 
            this.button_num_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_3.FlatAppearance.BorderSize = 0;
            this.button_num_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_3.ForeColor = System.Drawing.Color.White;
            this.button_num_3.Location = new System.Drawing.Point(202, 277);
            this.button_num_3.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_3.Name = "button_num_3";
            this.button_num_3.Size = new System.Drawing.Size(96, 51);
            this.button_num_3.TabIndex = 18;
            this.button_num_3.Text = "3";
            this.button_num_3.UseCompatibleTextRendering = true;
            this.button_num_3.UseVisualStyleBackColor = false;
            this.button_num_3.Click += new System.EventHandler(this.Button3_Click);
            this.button_num_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_6
            // 
            this.button_num_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_6.FlatAppearance.BorderSize = 0;
            this.button_num_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_6.ForeColor = System.Drawing.Color.White;
            this.button_num_6.Location = new System.Drawing.Point(202, 222);
            this.button_num_6.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_6.Name = "button_num_6";
            this.button_num_6.Size = new System.Drawing.Size(96, 51);
            this.button_num_6.TabIndex = 14;
            this.button_num_6.Text = "6";
            this.button_num_6.UseCompatibleTextRendering = true;
            this.button_num_6.UseVisualStyleBackColor = false;
            this.button_num_6.Click += new System.EventHandler(this.Button6_Click);
            this.button_num_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_num_9
            // 
            this.button_num_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_num_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_num_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num_9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_num_9.FlatAppearance.BorderSize = 0;
            this.button_num_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_num_9.ForeColor = System.Drawing.Color.Transparent;
            this.button_num_9.Location = new System.Drawing.Point(202, 167);
            this.button_num_9.Margin = new System.Windows.Forms.Padding(2);
            this.button_num_9.Name = "button_num_9";
            this.button_num_9.Size = new System.Drawing.Size(96, 51);
            this.button_num_9.TabIndex = 10;
            this.button_num_9.Text = "9";
            this.button_num_9.UseCompatibleTextRendering = true;
            this.button_num_9.UseVisualStyleBackColor = false;
            this.button_num_9.Click += new System.EventHandler(this.Button9_Click);
            this.button_num_9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_plus
            // 
            this.button_oper_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_plus.FlatAppearance.BorderSize = 0;
            this.button_oper_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_plus.ForeColor = System.Drawing.Color.White;
            this.button_oper_plus.Location = new System.Drawing.Point(302, 277);
            this.button_oper_plus.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_plus.Name = "button_oper_plus";
            this.button_oper_plus.Size = new System.Drawing.Size(99, 51);
            this.button_oper_plus.TabIndex = 19;
            this.button_oper_plus.Text = "+";
            this.button_oper_plus.UseCompatibleTextRendering = true;
            this.button_oper_plus.UseVisualStyleBackColor = false;
            this.button_oper_plus.Click += new System.EventHandler(this.OperationsOnClick);
            this.button_oper_plus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_minus
            // 
            this.button_oper_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_minus.FlatAppearance.BorderSize = 0;
            this.button_oper_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_minus.ForeColor = System.Drawing.Color.White;
            this.button_oper_minus.Location = new System.Drawing.Point(302, 222);
            this.button_oper_minus.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_minus.Name = "button_oper_minus";
            this.button_oper_minus.Size = new System.Drawing.Size(99, 51);
            this.button_oper_minus.TabIndex = 15;
            this.button_oper_minus.Text = "—";
            this.button_oper_minus.UseCompatibleTextRendering = true;
            this.button_oper_minus.UseVisualStyleBackColor = false;
            this.button_oper_minus.Click += new System.EventHandler(this.OperationsOnClick);
            this.button_oper_minus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_multiply
            // 
            this.button_oper_multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_multiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_multiply.FlatAppearance.BorderSize = 0;
            this.button_oper_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_multiply.ForeColor = System.Drawing.Color.White;
            this.button_oper_multiply.Location = new System.Drawing.Point(302, 167);
            this.button_oper_multiply.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_multiply.Name = "button_oper_multiply";
            this.button_oper_multiply.Size = new System.Drawing.Size(99, 51);
            this.button_oper_multiply.TabIndex = 11;
            this.button_oper_multiply.Text = "×";
            this.button_oper_multiply.UseCompatibleTextRendering = true;
            this.button_oper_multiply.UseVisualStyleBackColor = false;
            this.button_oper_multiply.Click += new System.EventHandler(this.OperationsOnClick);
            this.button_oper_multiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_oper_division
            // 
            this.button_oper_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_oper_division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_oper_division.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_oper_division.FlatAppearance.BorderSize = 0;
            this.button_oper_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oper_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oper_division.ForeColor = System.Drawing.Color.White;
            this.button_oper_division.Location = new System.Drawing.Point(302, 112);
            this.button_oper_division.Margin = new System.Windows.Forms.Padding(2);
            this.button_oper_division.Name = "button_oper_division";
            this.button_oper_division.Size = new System.Drawing.Size(99, 51);
            this.button_oper_division.TabIndex = 7;
            this.button_oper_division.Text = "÷";
            this.button_oper_division.UseCompatibleTextRendering = true;
            this.button_oper_division.UseVisualStyleBackColor = false;
            this.button_oper_division.Click += new System.EventHandler(this.OperationsOnClick);
            this.button_oper_division.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // MemoryTable
            // 
            this.MemoryTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.MemoryTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MemoryTable.ColumnCount = 5;
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MemoryTable.Controls.Add(this.button_memory_minus, 3, 0);
            this.MemoryTable.Controls.Add(this.button_memory_plus, 2, 0);
            this.MemoryTable.Controls.Add(this.button_memory_mr, 1, 0);
            this.MemoryTable.Controls.Add(this.button_memory_mc, 0, 0);
            this.MemoryTable.Controls.Add(this.button_memory_ms, 4, 0);
            this.MemoryTable.Location = new System.Drawing.Point(5, 98);
            this.MemoryTable.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryTable.Name = "MemoryTable";
            this.MemoryTable.RowCount = 1;
            this.MemoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MemoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.MemoryTable.Size = new System.Drawing.Size(391, 32);
            this.MemoryTable.TabIndex = 4;
            // 
            // button_memory_minus
            // 
            this.button_memory_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_memory_minus.FlatAppearance.BorderSize = 0;
            this.button_memory_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_memory_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_memory_minus.ForeColor = System.Drawing.Color.White;
            this.button_memory_minus.Location = new System.Drawing.Point(238, 4);
            this.button_memory_minus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_memory_minus.Name = "button_memory_minus";
            this.button_memory_minus.Size = new System.Drawing.Size(70, 24);
            this.button_memory_minus.TabIndex = 3;
            this.button_memory_minus.Text = "M-";
            this.button_memory_minus.UseCompatibleTextRendering = true;
            this.button_memory_minus.UseVisualStyleBackColor = true;
            this.button_memory_minus.Click += new System.EventHandler(this.ButtonMemoryminus_Click);
            this.button_memory_minus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_memory_plus
            // 
            this.button_memory_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.button_memory_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_memory_plus.FlatAppearance.BorderSize = 0;
            this.button_memory_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_memory_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_memory_plus.ForeColor = System.Drawing.Color.White;
            this.button_memory_plus.Location = new System.Drawing.Point(160, 4);
            this.button_memory_plus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_memory_plus.Name = "button_memory_plus";
            this.button_memory_plus.Size = new System.Drawing.Size(70, 24);
            this.button_memory_plus.TabIndex = 2;
            this.button_memory_plus.Text = "M+";
            this.button_memory_plus.UseCompatibleTextRendering = true;
            this.button_memory_plus.UseVisualStyleBackColor = false;
            this.button_memory_plus.Click += new System.EventHandler(this.ButtonMemoryPlus_Click);
            this.button_memory_plus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_memory_mr
            // 
            this.button_memory_mr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_memory_mr.FlatAppearance.BorderSize = 0;
            this.button_memory_mr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_memory_mr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_memory_mr.ForeColor = System.Drawing.Color.White;
            this.button_memory_mr.Location = new System.Drawing.Point(82, 4);
            this.button_memory_mr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_memory_mr.Name = "button_memory_mr";
            this.button_memory_mr.Size = new System.Drawing.Size(70, 24);
            this.button_memory_mr.TabIndex = 1;
            this.button_memory_mr.Text = "MR";
            this.button_memory_mr.UseCompatibleTextRendering = true;
            this.button_memory_mr.UseVisualStyleBackColor = true;
            this.button_memory_mr.Click += new System.EventHandler(this.ButtonMR_Click);
            this.button_memory_mr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button_memory_mc
            // 
            this.button_memory_mc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_memory_mc.FlatAppearance.BorderSize = 0;
            this.button_memory_mc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_memory_mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_memory_mc.ForeColor = System.Drawing.SystemColors.Window;
            this.button_memory_mc.Location = new System.Drawing.Point(4, 4);
            this.button_memory_mc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_memory_mc.Name = "button_memory_mc";
            this.button_memory_mc.Size = new System.Drawing.Size(70, 24);
            this.button_memory_mc.TabIndex = 0;
            this.button_memory_mc.Text = "MC";
            this.button_memory_mc.UseCompatibleTextRendering = true;
            this.button_memory_mc.UseVisualStyleBackColor = true;
            this.button_memory_mc.Click += new System.EventHandler(this.ButtonMC_Click);
            // 
            // button_memory_ms
            // 
            this.button_memory_ms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_memory_ms.FlatAppearance.BorderSize = 0;
            this.button_memory_ms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_memory_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_memory_ms.ForeColor = System.Drawing.Color.White;
            this.button_memory_ms.Location = new System.Drawing.Point(316, 4);
            this.button_memory_ms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_memory_ms.Name = "button_memory_ms";
            this.button_memory_ms.Size = new System.Drawing.Size(71, 24);
            this.button_memory_ms.TabIndex = 4;
            this.button_memory_ms.Text = "MS";
            this.button_memory_ms.UseCompatibleTextRendering = true;
            this.button_memory_ms.UseVisualStyleBackColor = true;
            this.button_memory_ms.Click += new System.EventHandler(this.ButtonMS_Click);
            this.button_memory_ms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // CalculationBox
            // 
            this.CalculationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalculationBox.ForeColor = System.Drawing.Color.Coral;
            this.CalculationBox.Location = new System.Drawing.Point(101, 21);
            this.CalculationBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CalculationBox.Name = "CalculationBox";
            this.CalculationBox.Size = new System.Drawing.Size(295, 20);
            this.CalculationBox.TabIndex = 6;
            this.CalculationBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.TopMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TopMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_pivo});
            this.TopMenu.Location = new System.Drawing.Point(3, 4);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.TopMenu.Size = new System.Drawing.Size(43, 34);
            this.TopMenu.TabIndex = 12;
            // 
            // button_pivo
            // 
            this.button_pivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.button_pivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.coloursToolStripMenuItem,
            this.toolStripMenuItem1,
            this.HelpToolStripMenuItem});
            this.button_pivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pivo.ForeColor = System.Drawing.Color.White;
            this.button_pivo.Image = ((System.Drawing.Image)(resources.GetObject("button_pivo.Image")));
            this.button_pivo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.button_pivo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button_pivo.Name = "button_pivo";
            this.button_pivo.Size = new System.Drawing.Size(36, 26);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // coloursToolStripMenuItem
            // 
            this.coloursToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.coloursToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coloursToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.coloursToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
            this.coloursToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.coloursToolStripMenuItem.Text = "Colours";
            this.coloursToolStripMenuItem.Click += new System.EventHandler(this.coloursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 28);
            this.toolStripMenuItem1.Text = "Manual";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.HelpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // Calculator
            // 
            this.AcceptButton = this.button_oper_plus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CancelButton = this.button_oper_ce;
            this.ClientSize = new System.Drawing.Size(403, 518);
            this.Controls.Add(this.TopMenu);
            this.Controls.Add(this.CalculationBox);
            this.Controls.Add(this.MemoryTable);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.UserInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(415, 515);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulačka v1.0";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.ButtonPanel.ResumeLayout(false);
            this.MemoryTable.ResumeLayout(false);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.TableLayoutPanel MemoryTable;
        private System.Windows.Forms.Button button_memory_ms;
        private System.Windows.Forms.Button button_memory_minus;
        private System.Windows.Forms.Button button_memory_plus;
        private System.Windows.Forms.Button button_memory_mr;
        private System.Windows.Forms.Button button_memory_mc;
        private System.Windows.Forms.Button button_num_2;
        private System.Windows.Forms.Button button_oper_equal;
        private System.Windows.Forms.Button button_oper_dot;
        private System.Windows.Forms.Button button_num_0;
        private System.Windows.Forms.Button button_oper_change;
        private System.Windows.Forms.Button button_oper_plus;
        private System.Windows.Forms.Button button_num_3;
        private System.Windows.Forms.Button button_num_1;
        private System.Windows.Forms.Button button_oper_minus;
        private System.Windows.Forms.Button button_num_6;
        private System.Windows.Forms.Button button_num_5;
        private System.Windows.Forms.Button button_num_4;
        private System.Windows.Forms.Button button_oper_multiply;
        private System.Windows.Forms.Button button_num_9;
        private System.Windows.Forms.Button button_num_8;
        private System.Windows.Forms.Button button_num_7;
        private System.Windows.Forms.Button button_oper_division;
        private System.Windows.Forms.Button button_oper_root;
        private System.Windows.Forms.Button button_oper_power;
        private System.Windows.Forms.Button button_oper_factorial;
        private System.Windows.Forms.Button button_oper_del;
        private System.Windows.Forms.Button button_oper_c;
        private System.Windows.Forms.Button button_oper_ce;
        private System.Windows.Forms.Button button_oper_percent;
        private System.Windows.Forms.Label CalculationBox;
        private System.Windows.Forms.Button button_oper_root2;
        private System.Windows.Forms.Button button_oper_power2;
        private System.Windows.Forms.Button button_oper_fraction;
        private System.Windows.Forms.Button button_oper_abs;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem button_pivo;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

