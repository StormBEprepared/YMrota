namespace YMrota
{
    partial class Rota
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
            this.ExtractExcelButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.GenerateRotaButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Associate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Marshalls = new System.Windows.Forms.Label();
            this.Training = new System.Windows.Forms.Label();
            this.PastPositions = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExtractExcelButton
            // 
            this.ExtractExcelButton.FlatAppearance.BorderSize = 0;
            this.ExtractExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtractExcelButton.Font = new System.Drawing.Font("KG Holocene", 8F, System.Drawing.FontStyle.Bold);
            this.ExtractExcelButton.Location = new System.Drawing.Point(492, 858);
            this.ExtractExcelButton.Name = "ExtractExcelButton";
            this.ExtractExcelButton.Size = new System.Drawing.Size(164, 95);
            this.ExtractExcelButton.TabIndex = 1;
            this.ExtractExcelButton.Text = "Extract EXCEL";
            this.ExtractExcelButton.UseVisualStyleBackColor = true;
            this.ExtractExcelButton.Click += new System.EventHandler(this.ExtractExcelButton_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("KG Holocene", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(14, 881);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("KG Holocene", 6.5F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(9, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 360);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(413, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(202, 183);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("KG Holocene", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(140, 881);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Assisgn Position";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GenerateRotaButton
            // 
            this.GenerateRotaButton.FlatAppearance.BorderSize = 0;
            this.GenerateRotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateRotaButton.Font = new System.Drawing.Font("KG Holocene", 8F, System.Drawing.FontStyle.Bold);
            this.GenerateRotaButton.Location = new System.Drawing.Point(478, 409);
            this.GenerateRotaButton.Name = "GenerateRotaButton";
            this.GenerateRotaButton.Size = new System.Drawing.Size(165, 87);
            this.GenerateRotaButton.TabIndex = 6;
            this.GenerateRotaButton.Text = "Generate Rota";
            this.GenerateRotaButton.UseVisualStyleBackColor = true;
            this.GenerateRotaButton.Click += new System.EventHandler(this.GenerateRotaButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(139, 935);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(396, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "You confirm that you have no other changes to do?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("KG Holocene", 6.5F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(388, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(254, 360);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.Associate});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(662, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(554, 897);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 8;
            this.Position.Name = "Position";
            this.Position.Width = 150;
            // 
            // Associate
            // 
            this.Associate.HeaderText = "Associate";
            this.Associate.MinimumWidth = 8;
            this.Associate.Name = "Associate";
            this.Associate.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1184, -16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Marshalls
            // 
            this.Marshalls.AutoSize = true;
            this.Marshalls.Font = new System.Drawing.Font("KG Holocene", 8F, System.Drawing.FontStyle.Bold);
            this.Marshalls.Location = new System.Drawing.Point(9, 29);
            this.Marshalls.Name = "Marshalls";
            this.Marshalls.Size = new System.Drawing.Size(116, 25);
            this.Marshalls.TabIndex = 11;
            this.Marshalls.Text = "Marshalls";
            // 
            // Training
            // 
            this.Training.AutoSize = true;
            this.Training.Font = new System.Drawing.Font("KG Holocene", 8F, System.Drawing.FontStyle.Bold);
            this.Training.Location = new System.Drawing.Point(383, 29);
            this.Training.Name = "Training";
            this.Training.Size = new System.Drawing.Size(104, 25);
            this.Training.TabIndex = 12;
            this.Training.Text = "Training";
            // 
            // PastPositions
            // 
            this.PastPositions.AutoSize = true;
            this.PastPositions.Font = new System.Drawing.Font("KG Holocene", 8F, System.Drawing.FontStyle.Bold);
            this.PastPositions.Location = new System.Drawing.Point(12, 440);
            this.PastPositions.Name = "PastPositions";
            this.PastPositions.Size = new System.Drawing.Size(161, 25);
            this.PastPositions.TabIndex = 13;
            this.PastPositions.Text = "Past Positions";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 490);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(616, 362);
            this.dataGridView2.TabIndex = 14;
            // 
            // Rota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 1173);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.PastPositions);
            this.Controls.Add(this.Training);
            this.Controls.Add(this.Marshalls);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.GenerateRotaButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ExtractExcelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rota";
            this.Load += new System.EventHandler(this.Rota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExtractExcelButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GenerateRotaButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Associate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Marshalls;
        private System.Windows.Forms.Label Training;
        private System.Windows.Forms.Label PastPositions;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}