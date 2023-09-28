namespace SamTechToDoApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.dgvdisplay = new System.Windows.Forms.DataGridView();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.sheet = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.tsklbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(545, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(232, 50);
            this.title.TabIndex = 0;
            this.title.Text = "To Do List";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvdisplay
            // 
            this.dgvdisplay.AllowUserToAddRows = false;
            this.dgvdisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplay.Location = new System.Drawing.Point(341, 72);
            this.dgvdisplay.Name = "dgvdisplay";
            this.dgvdisplay.ReadOnly = true;
            this.dgvdisplay.RowHeadersWidth = 62;
            this.dgvdisplay.RowTemplate.Height = 28;
            this.dgvdisplay.Size = new System.Drawing.Size(724, 466);
            this.dgvdisplay.TabIndex = 1;
            this.dgvdisplay.DoubleClick += new System.EventHandler(this.dgvdisplay_DoubleClick);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(12, 151);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(323, 26);
            this.dtp.TabIndex = 2;
            // 
            // sheet
            // 
            this.sheet.Location = new System.Drawing.Point(102, 72);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(233, 66);
            this.sheet.TabIndex = 5;
            this.sheet.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 619);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 208);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(107, 52);
            this.add.TabIndex = 6;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(185, 208);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(125, 52);
            this.update.TabIndex = 6;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(185, 294);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 52);
            this.delete.TabIndex = 6;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 377);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(107, 52);
            this.search.TabIndex = 6;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(12, 294);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(107, 52);
            this.resetbtn.TabIndex = 7;
            this.resetbtn.Text = "RESET";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // tsklbl
            // 
            this.tsklbl.Location = new System.Drawing.Point(12, 72);
            this.tsklbl.Name = "tsklbl";
            this.tsklbl.Size = new System.Drawing.Size(84, 31);
            this.tsklbl.TabIndex = 8;
            this.tsklbl.Text = "Task";
            this.tsklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(136, 377);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 52);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1205, 619);
            this.Controls.Add(this.tsklbl);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.dgvdisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAM OPERATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dgvdisplay;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.RichTextBox sheet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label tsklbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

