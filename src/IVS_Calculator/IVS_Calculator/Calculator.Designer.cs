﻿namespace IVS_Calculator
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
            this.ButtonRoot2 = new System.Windows.Forms.Button();
            this.ButtonPower2 = new System.Windows.Forms.Button();
            this.ButtonFranction = new System.Windows.Forms.Button();
            this.ButtonAbs = new System.Windows.Forms.Button();
            this.ButtonRoot = new System.Windows.Forms.Button();
            this.ButtonPower = new System.Windows.Forms.Button();
            this.ButtonFactorial = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.MemoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonMemoryminus = new System.Windows.Forms.Button();
            this.ButtonMemoryPlus = new System.Windows.Forms.Button();
            this.ButtonMR = new System.Windows.Forms.Button();
            this.ButtonMC = new System.Windows.Forms.Button();
            this.ButtonMS = new System.Windows.Forms.Button();
            this.CalculationBox = new System.Windows.Forms.Label();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.UserInput.Location = new System.Drawing.Point(10, 55);
            this.UserInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserInput.Name = "UserInput";
            this.UserInput.ReadOnly = true;
            this.UserInput.Size = new System.Drawing.Size(432, 55);
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
            this.ButtonPanel.Controls.Add(this.ButtonRoot2, 2, 2);
            this.ButtonPanel.Controls.Add(this.ButtonPower2, 1, 2);
            this.ButtonPanel.Controls.Add(this.ButtonFranction, 0, 2);
            this.ButtonPanel.Controls.Add(this.ButtonAbs, 3, 1);
            this.ButtonPanel.Controls.Add(this.ButtonRoot, 2, 1);
            this.ButtonPanel.Controls.Add(this.ButtonPower, 1, 1);
            this.ButtonPanel.Controls.Add(this.ButtonFactorial, 0, 1);
            this.ButtonPanel.Controls.Add(this.ButtonDel, 3, 0);
            this.ButtonPanel.Controls.Add(this.ButtonC, 2, 0);
            this.ButtonPanel.Controls.Add(this.ButtonCE, 1, 0);
            this.ButtonPanel.Controls.Add(this.ButtonPercent, 0, 0);
            this.ButtonPanel.Controls.Add(this.ButtonEqual, 3, 6);
            this.ButtonPanel.Controls.Add(this.ButtonDot, 2, 6);
            this.ButtonPanel.Controls.Add(this.Button0, 1, 6);
            this.ButtonPanel.Controls.Add(this.ButtonChange, 0, 6);
            this.ButtonPanel.Controls.Add(this.Button1, 0, 5);
            this.ButtonPanel.Controls.Add(this.Button4, 0, 4);
            this.ButtonPanel.Controls.Add(this.Button7, 0, 3);
            this.ButtonPanel.Controls.Add(this.Button2, 1, 5);
            this.ButtonPanel.Controls.Add(this.Button5, 1, 4);
            this.ButtonPanel.Controls.Add(this.Button8, 1, 3);
            this.ButtonPanel.Controls.Add(this.Button3, 2, 5);
            this.ButtonPanel.Controls.Add(this.Button6, 2, 4);
            this.ButtonPanel.Controls.Add(this.Button9, 2, 3);
            this.ButtonPanel.Controls.Add(this.ButtonPlus, 3, 5);
            this.ButtonPanel.Controls.Add(this.ButtonMinus, 3, 4);
            this.ButtonPanel.Controls.Add(this.ButtonMultiply, 3, 3);
            this.ButtonPanel.Controls.Add(this.ButtonDivision, 3, 2);
            this.ButtonPanel.Location = new System.Drawing.Point(0, 163);
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
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ButtonPanel.Size = new System.Drawing.Size(453, 485);
            this.ButtonPanel.TabIndex = 2;
            // 
            // ButtonRoot2
            // 
            this.ButtonRoot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonRoot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRoot2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonRoot2.FlatAppearance.BorderSize = 0;
            this.ButtonRoot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRoot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRoot2.ForeColor = System.Drawing.Color.White;
            this.ButtonRoot2.Location = new System.Drawing.Point(228, 140);
            this.ButtonRoot2.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRoot2.Name = "ButtonRoot2";
            this.ButtonRoot2.Size = new System.Drawing.Size(109, 65);
            this.ButtonRoot2.TabIndex = 28;
            this.ButtonRoot2.Text = "²√x";
            this.ButtonRoot2.UseCompatibleTextRendering = true;
            this.ButtonRoot2.UseVisualStyleBackColor = false;
            this.ButtonRoot2.Click += new System.EventHandler(this.OperationsOnClick);
            // 
            // ButtonPower2
            // 
            this.ButtonPower2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPower2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPower2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonPower2.FlatAppearance.BorderSize = 0;
            this.ButtonPower2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPower2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPower2.ForeColor = System.Drawing.Color.White;
            this.ButtonPower2.Location = new System.Drawing.Point(115, 140);
            this.ButtonPower2.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPower2.Name = "ButtonPower2";
            this.ButtonPower2.Size = new System.Drawing.Size(109, 65);
            this.ButtonPower2.TabIndex = 27;
            this.ButtonPower2.Text = "x²";
            this.ButtonPower2.UseCompatibleTextRendering = true;
            this.ButtonPower2.UseVisualStyleBackColor = false;
            this.ButtonPower2.Click += new System.EventHandler(this.OperationsOnClick);
            // 
            // ButtonFranction
            // 
            this.ButtonFranction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonFranction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFranction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonFranction.FlatAppearance.BorderSize = 0;
            this.ButtonFranction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFranction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonFranction.ForeColor = System.Drawing.Color.White;
            this.ButtonFranction.Location = new System.Drawing.Point(2, 140);
            this.ButtonFranction.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonFranction.Name = "ButtonFranction";
            this.ButtonFranction.Size = new System.Drawing.Size(109, 65);
            this.ButtonFranction.TabIndex = 26;
            this.ButtonFranction.Text = "1/x";
            this.ButtonFranction.UseCompatibleTextRendering = true;
            this.ButtonFranction.UseVisualStyleBackColor = false;
            this.ButtonFranction.Click += new System.EventHandler(this.OperationsOnClick);
            // 
            // ButtonAbs
            // 
            this.ButtonAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonAbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAbs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonAbs.FlatAppearance.BorderSize = 0;
            this.ButtonAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAbs.ForeColor = System.Drawing.Color.White;
            this.ButtonAbs.Location = new System.Drawing.Point(341, 71);
            this.ButtonAbs.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAbs.Name = "ButtonAbs";
            this.ButtonAbs.Size = new System.Drawing.Size(110, 65);
            this.ButtonAbs.TabIndex = 25;
            this.ButtonAbs.Text = "|x|";
            this.ButtonAbs.UseCompatibleTextRendering = true;
            this.ButtonAbs.UseVisualStyleBackColor = false;
            this.ButtonAbs.Click += new System.EventHandler(this.OperationsOnClick);
            // 
            // ButtonRoot
            // 
            this.ButtonRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRoot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonRoot.FlatAppearance.BorderSize = 0;
            this.ButtonRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRoot.ForeColor = System.Drawing.Color.White;
            this.ButtonRoot.Location = new System.Drawing.Point(228, 71);
            this.ButtonRoot.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRoot.Name = "ButtonRoot";
            this.ButtonRoot.Size = new System.Drawing.Size(109, 65);
            this.ButtonRoot.TabIndex = 6;
            this.ButtonRoot.Text = "ⁿ√x";
            this.ButtonRoot.UseCompatibleTextRendering = true;
            this.ButtonRoot.UseVisualStyleBackColor = false;
            this.ButtonRoot.Click += new System.EventHandler(this.ButtonRoot_Click);
            this.ButtonRoot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonPower
            // 
            this.ButtonPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPower.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonPower.FlatAppearance.BorderSize = 0;
            this.ButtonPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPower.ForeColor = System.Drawing.Color.White;
            this.ButtonPower.Location = new System.Drawing.Point(115, 71);
            this.ButtonPower.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPower.Name = "ButtonPower";
            this.ButtonPower.Size = new System.Drawing.Size(109, 65);
            this.ButtonPower.TabIndex = 5;
            this.ButtonPower.Text = "xⁿ";
            this.ButtonPower.UseCompatibleTextRendering = true;
            this.ButtonPower.UseVisualStyleBackColor = false;
            this.ButtonPower.Click += new System.EventHandler(this.ButtonPower_Click);
            this.ButtonPower.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonFactorial
            // 
            this.ButtonFactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonFactorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFactorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonFactorial.FlatAppearance.BorderSize = 0;
            this.ButtonFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonFactorial.ForeColor = System.Drawing.Color.White;
            this.ButtonFactorial.Location = new System.Drawing.Point(2, 71);
            this.ButtonFactorial.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonFactorial.Name = "ButtonFactorial";
            this.ButtonFactorial.Size = new System.Drawing.Size(109, 65);
            this.ButtonFactorial.TabIndex = 4;
            this.ButtonFactorial.Text = "x!";
            this.ButtonFactorial.UseCompatibleTextRendering = true;
            this.ButtonFactorial.UseVisualStyleBackColor = false;
            this.ButtonFactorial.Click += new System.EventHandler(this.OperationsOnClick);
            this.ButtonFactorial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonDel.FlatAppearance.BorderSize = 0;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDel.ForeColor = System.Drawing.Color.White;
            this.ButtonDel.Location = new System.Drawing.Point(341, 2);
            this.ButtonDel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(110, 65);
            this.ButtonDel.TabIndex = 3;
            this.ButtonDel.Text = "DEL";
            this.ButtonDel.UseCompatibleTextRendering = true;
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            this.ButtonDel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonC.FlatAppearance.BorderSize = 0;
            this.ButtonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonC.ForeColor = System.Drawing.Color.White;
            this.ButtonC.Location = new System.Drawing.Point(228, 2);
            this.ButtonC.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(109, 65);
            this.ButtonC.TabIndex = 2;
            this.ButtonC.Text = "C";
            this.ButtonC.UseCompatibleTextRendering = true;
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            this.ButtonC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonCE
            // 
            this.ButtonCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonCE.FlatAppearance.BorderSize = 0;
            this.ButtonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCE.ForeColor = System.Drawing.Color.White;
            this.ButtonCE.Location = new System.Drawing.Point(115, 2);
            this.ButtonCE.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(109, 65);
            this.ButtonCE.TabIndex = 1;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseCompatibleTextRendering = true;
            this.ButtonCE.UseVisualStyleBackColor = false;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            this.ButtonCE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPercent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonPercent.FlatAppearance.BorderSize = 0;
            this.ButtonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPercent.ForeColor = System.Drawing.Color.White;
            this.ButtonPercent.Location = new System.Drawing.Point(2, 2);
            this.ButtonPercent.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(109, 65);
            this.ButtonPercent.TabIndex = 0;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = false;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            this.ButtonPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEqual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonEqual.FlatAppearance.BorderSize = 0;
            this.ButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEqual.ForeColor = System.Drawing.Color.White;
            this.ButtonEqual.Location = new System.Drawing.Point(341, 416);
            this.ButtonEqual.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(110, 67);
            this.ButtonEqual.TabIndex = 23;
            this.ButtonEqual.Text = "=";
            this.ButtonEqual.UseCompatibleTextRendering = true;
            this.ButtonEqual.UseVisualStyleBackColor = false;
            this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            this.ButtonEqual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonDot
            // 
            this.ButtonDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonDot.FlatAppearance.BorderSize = 0;
            this.ButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDot.ForeColor = System.Drawing.Color.White;
            this.ButtonDot.Location = new System.Drawing.Point(228, 416);
            this.ButtonDot.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(109, 67);
            this.ButtonDot.TabIndex = 22;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseCompatibleTextRendering = true;
            this.ButtonDot.UseVisualStyleBackColor = false;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            this.ButtonDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button0.FlatAppearance.BorderSize = 0;
            this.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button0.ForeColor = System.Drawing.Color.White;
            this.Button0.Location = new System.Drawing.Point(115, 416);
            this.Button0.Margin = new System.Windows.Forms.Padding(2);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(109, 67);
            this.Button0.TabIndex = 21;
            this.Button0.Text = "0";
            this.Button0.UseCompatibleTextRendering = true;
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            this.Button0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonChange
            // 
            this.ButtonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonChange.FlatAppearance.BorderSize = 0;
            this.ButtonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonChange.ForeColor = System.Drawing.Color.White;
            this.ButtonChange.Location = new System.Drawing.Point(2, 416);
            this.ButtonChange.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(109, 67);
            this.ButtonChange.TabIndex = 20;
            this.ButtonChange.Text = "ᐩ/₋";
            this.ButtonChange.UseCompatibleTextRendering = true;
            this.ButtonChange.UseVisualStyleBackColor = false;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            this.ButtonChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(2, 347);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(109, 65);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "1";
            this.Button1.UseCompatibleTextRendering = true;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.Button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(2, 278);
            this.Button4.Margin = new System.Windows.Forms.Padding(2);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(109, 65);
            this.Button4.TabIndex = 12;
            this.Button4.Text = "4";
            this.Button4.UseCompatibleTextRendering = true;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            this.Button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Location = new System.Drawing.Point(2, 209);
            this.Button7.Margin = new System.Windows.Forms.Padding(2);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(109, 65);
            this.Button7.TabIndex = 8;
            this.Button7.Text = "7";
            this.Button7.UseCompatibleTextRendering = true;
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            this.Button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(115, 347);
            this.Button2.Margin = new System.Windows.Forms.Padding(2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(109, 65);
            this.Button2.TabIndex = 24;
            this.Button2.Text = "2";
            this.Button2.UseCompatibleTextRendering = true;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            this.Button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(115, 278);
            this.Button5.Margin = new System.Windows.Forms.Padding(2);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(109, 65);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "5";
            this.Button5.UseCompatibleTextRendering = true;
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            this.Button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button8.ForeColor = System.Drawing.Color.White;
            this.Button8.Location = new System.Drawing.Point(115, 209);
            this.Button8.Margin = new System.Windows.Forms.Padding(2);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(109, 65);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "8";
            this.Button8.UseCompatibleTextRendering = true;
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            this.Button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(228, 347);
            this.Button3.Margin = new System.Windows.Forms.Padding(2);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(109, 65);
            this.Button3.TabIndex = 18;
            this.Button3.Text = "3";
            this.Button3.UseCompatibleTextRendering = true;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            this.Button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(228, 278);
            this.Button6.Margin = new System.Windows.Forms.Padding(2);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(109, 65);
            this.Button6.TabIndex = 14;
            this.Button6.Text = "6";
            this.Button6.UseCompatibleTextRendering = true;
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            this.Button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button9.ForeColor = System.Drawing.Color.Transparent;
            this.Button9.Location = new System.Drawing.Point(228, 209);
            this.Button9.Margin = new System.Windows.Forms.Padding(2);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(109, 65);
            this.Button9.TabIndex = 10;
            this.Button9.Text = "9";
            this.Button9.UseCompatibleTextRendering = true;
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            this.Button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonPlus.FlatAppearance.BorderSize = 0;
            this.ButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPlus.ForeColor = System.Drawing.Color.White;
            this.ButtonPlus.Location = new System.Drawing.Point(341, 347);
            this.ButtonPlus.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(110, 65);
            this.ButtonPlus.TabIndex = 19;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseCompatibleTextRendering = true;
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.OperationsOnClick);
            this.ButtonPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonMinus.FlatAppearance.BorderSize = 0;
            this.ButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMinus.ForeColor = System.Drawing.Color.White;
            this.ButtonMinus.Location = new System.Drawing.Point(341, 278);
            this.ButtonMinus.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(110, 65);
            this.ButtonMinus.TabIndex = 15;
            this.ButtonMinus.Text = "—";
            this.ButtonMinus.UseCompatibleTextRendering = true;
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.OperationsOnClick);
            this.ButtonMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonMultiply.FlatAppearance.BorderSize = 0;
            this.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMultiply.ForeColor = System.Drawing.Color.White;
            this.ButtonMultiply.Location = new System.Drawing.Point(341, 209);
            this.ButtonMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(110, 65);
            this.ButtonMultiply.TabIndex = 11;
            this.ButtonMultiply.Text = "×";
            this.ButtonMultiply.UseCompatibleTextRendering = true;
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.OperationsOnClick);
            this.ButtonMultiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonDivision.FlatAppearance.BorderSize = 0;
            this.ButtonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDivision.ForeColor = System.Drawing.Color.White;
            this.ButtonDivision.Location = new System.Drawing.Point(341, 140);
            this.ButtonDivision.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(110, 65);
            this.ButtonDivision.TabIndex = 7;
            this.ButtonDivision.Text = "÷";
            this.ButtonDivision.UseCompatibleTextRendering = true;
            this.ButtonDivision.UseVisualStyleBackColor = false;
            this.ButtonDivision.Click += new System.EventHandler(this.OperationsOnClick);
            this.ButtonDivision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
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
            this.MemoryTable.Controls.Add(this.ButtonMemoryminus, 3, 0);
            this.MemoryTable.Controls.Add(this.ButtonMemoryPlus, 2, 0);
            this.MemoryTable.Controls.Add(this.ButtonMR, 1, 0);
            this.MemoryTable.Controls.Add(this.ButtonMC, 0, 0);
            this.MemoryTable.Controls.Add(this.ButtonMS, 4, 0);
            this.MemoryTable.Location = new System.Drawing.Point(6, 123);
            this.MemoryTable.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryTable.Name = "MemoryTable";
            this.MemoryTable.RowCount = 1;
            this.MemoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MemoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MemoryTable.Size = new System.Drawing.Size(440, 40);
            this.MemoryTable.TabIndex = 4;
            // 
            // ButtonMemoryminus
            // 
            this.ButtonMemoryminus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMemoryminus.FlatAppearance.BorderSize = 0;
            this.ButtonMemoryminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMemoryminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMemoryminus.ForeColor = System.Drawing.Color.White;
            this.ButtonMemoryminus.Location = new System.Drawing.Point(268, 5);
            this.ButtonMemoryminus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonMemoryminus.Name = "ButtonMemoryminus";
            this.ButtonMemoryminus.Size = new System.Drawing.Size(80, 30);
            this.ButtonMemoryminus.TabIndex = 3;
            this.ButtonMemoryminus.Text = "M-";
            this.ButtonMemoryminus.UseCompatibleTextRendering = true;
            this.ButtonMemoryminus.UseVisualStyleBackColor = true;
            this.ButtonMemoryminus.Click += new System.EventHandler(this.ButtonMemoryminus_Click);
            this.ButtonMemoryminus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonMemoryPlus
            // 
            this.ButtonMemoryPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonMemoryPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMemoryPlus.FlatAppearance.BorderSize = 0;
            this.ButtonMemoryPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMemoryPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMemoryPlus.ForeColor = System.Drawing.Color.White;
            this.ButtonMemoryPlus.Location = new System.Drawing.Point(180, 5);
            this.ButtonMemoryPlus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonMemoryPlus.Name = "ButtonMemoryPlus";
            this.ButtonMemoryPlus.Size = new System.Drawing.Size(80, 30);
            this.ButtonMemoryPlus.TabIndex = 2;
            this.ButtonMemoryPlus.Text = "M+";
            this.ButtonMemoryPlus.UseCompatibleTextRendering = true;
            this.ButtonMemoryPlus.UseVisualStyleBackColor = false;
            this.ButtonMemoryPlus.Click += new System.EventHandler(this.ButtonMemoryPlus_Click);
            this.ButtonMemoryPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonMR
            // 
            this.ButtonMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMR.FlatAppearance.BorderSize = 0;
            this.ButtonMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMR.ForeColor = System.Drawing.Color.White;
            this.ButtonMR.Location = new System.Drawing.Point(92, 5);
            this.ButtonMR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonMR.Name = "ButtonMR";
            this.ButtonMR.Size = new System.Drawing.Size(80, 30);
            this.ButtonMR.TabIndex = 1;
            this.ButtonMR.Text = "MR";
            this.ButtonMR.UseCompatibleTextRendering = true;
            this.ButtonMR.UseVisualStyleBackColor = true;
            this.ButtonMR.Click += new System.EventHandler(this.ButtonMR_Click);
            this.ButtonMR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // ButtonMC
            // 
            this.ButtonMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMC.FlatAppearance.BorderSize = 0;
            this.ButtonMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMC.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonMC.Location = new System.Drawing.Point(4, 5);
            this.ButtonMC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonMC.Name = "ButtonMC";
            this.ButtonMC.Size = new System.Drawing.Size(80, 30);
            this.ButtonMC.TabIndex = 0;
            this.ButtonMC.Text = "MC";
            this.ButtonMC.UseCompatibleTextRendering = true;
            this.ButtonMC.UseVisualStyleBackColor = true;
            this.ButtonMC.Click += new System.EventHandler(this.ButtonMC_Click);
            // 
            // ButtonMS
            // 
            this.ButtonMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMS.FlatAppearance.BorderSize = 0;
            this.ButtonMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMS.ForeColor = System.Drawing.Color.White;
            this.ButtonMS.Location = new System.Drawing.Point(356, 5);
            this.ButtonMS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonMS.Name = "ButtonMS";
            this.ButtonMS.Size = new System.Drawing.Size(80, 30);
            this.ButtonMS.TabIndex = 4;
            this.ButtonMS.Text = "MS";
            this.ButtonMS.UseCompatibleTextRendering = true;
            this.ButtonMS.UseVisualStyleBackColor = true;
            this.ButtonMS.Click += new System.EventHandler(this.ButtonMS_Click);
            this.ButtonMS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // CalculationBox
            // 
            this.CalculationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalculationBox.ForeColor = System.Drawing.Color.Coral;
            this.CalculationBox.Location = new System.Drawing.Point(114, 26);
            this.CalculationBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CalculationBox.Name = "CalculationBox";
            this.CalculationBox.Size = new System.Drawing.Size(332, 25);
            this.CalculationBox.TabIndex = 6;
            this.CalculationBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.TopMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TopMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.TopMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(3, 5);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.TopMenu.Size = new System.Drawing.Size(46, 36);
            this.TopMenu.TabIndex = 12;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.coloursToolStripMenuItem,
            this.toolStripMenuItem1,
            this.HelpToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.optionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(38, 26);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(197, 38);
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
            this.coloursToolStripMenuItem.Size = new System.Drawing.Size(197, 38);
            this.coloursToolStripMenuItem.Text = "Colours";
            this.coloursToolStripMenuItem.Click += new System.EventHandler(this.coloursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 38);
            this.toolStripMenuItem1.Text = "Manual";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(143)))), ((int)(((byte)(88)))));
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.HelpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(197, 38);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // Calculator
            // 
            this.AcceptButton = this.ButtonPlus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CancelButton = this.ButtonCE;
            this.ClientSize = new System.Drawing.Size(453, 648);
            this.Controls.Add(this.TopMenu);
            this.Controls.Add(this.CalculationBox);
            this.Controls.Add(this.MemoryTable);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.UserInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(466, 634);
            this.Name = "Calculator";
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
        private System.Windows.Forms.Button ButtonMS;
        private System.Windows.Forms.Button ButtonMemoryminus;
        private System.Windows.Forms.Button ButtonMemoryPlus;
        private System.Windows.Forms.Button ButtonMR;
        private System.Windows.Forms.Button ButtonMC;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.Button ButtonRoot;
        private System.Windows.Forms.Button ButtonPower;
        private System.Windows.Forms.Button ButtonFactorial;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button ButtonPercent;
        private System.Windows.Forms.Label CalculationBox;
        private System.Windows.Forms.Button ButtonRoot2;
        private System.Windows.Forms.Button ButtonPower2;
        private System.Windows.Forms.Button ButtonFranction;
        private System.Windows.Forms.Button ButtonAbs;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

