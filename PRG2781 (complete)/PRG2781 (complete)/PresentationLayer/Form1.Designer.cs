namespace WindowsFormsApp1_PRG282_Project
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

        private System.ComponentModel.IContainer GetComponents()
        {
            return components;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnClear = new Button();
            deletebtn = new Button();
            updatebtn = new Button();
            btnAdd = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtHeroID = new TextBox();
            txtPower = new TextBox();
            txtAge = new NumericUpDown();
            txtScore = new NumericUpDown();
            txtName = new TextBox();
            dgvRank = new DataGridView();
            colRank = new DataGridViewTextBoxColumn();
            dgvThreat = new DataGridView();
            colThreatLevel = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            searchbtn = new Button();
            btnRefresh = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            colTotalHeros = new DataGridViewTextBoxColumn();
            colAveAge = new DataGridViewTextBoxColumn();
            colAveScore = new DataGridViewTextBoxColumn();
            dgvHero = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colPower = new DataGridViewTextBoxColumn();
            colScore = new DataGridViewTextBoxColumn();
            colThreat = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThreat).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHero).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 561F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 561F));
            tableLayoutPanel1.Size = new Size(884, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 555);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hero Details Capture";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(btnClear);
            flowLayoutPanel1.Controls.Add(deletebtn);
            flowLayoutPanel1.Controls.Add(updatebtn);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 450);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 8, 0, 0);
            flowLayoutPanel1.Size = new Size(341, 102);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Location = new Point(261, 13);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 81);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // deletebtn
            // 
            deletebtn.AutoSize = true;
            deletebtn.Location = new Point(176, 13);
            deletebtn.Margin = new Padding(5);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 81);
            deletebtn.TabIndex = 2;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.AutoSize = true;
            updatebtn.Location = new Point(91, 13);
            updatebtn.Margin = new Padding(5);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(75, 81);
            updatebtn.TabIndex = 1;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Location = new Point(6, 13);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 81);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(label7, 0, 6);
            tableLayoutPanel2.Controls.Add(txtHeroID, 1, 0);
            tableLayoutPanel2.Controls.Add(txtPower, 1, 3);
            tableLayoutPanel2.Controls.Add(txtAge, 1, 2);
            tableLayoutPanel2.Controls.Add(txtScore, 1, 4);
            tableLayoutPanel2.Controls.Add(txtName, 1, 1);
            tableLayoutPanel2.Controls.Add(dgvRank, 1, 5);
            tableLayoutPanel2.Controls.Add(dgvThreat, 1, 6);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 21);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.Size = new Size(341, 429);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(13, 30);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 0;
            label1.Text = "Hero ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(122, 17);
            label2.TabIndex = 1;
            label2.Text = "Name ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(13, 146);
            label3.Name = "label3";
            label3.Size = new Size(122, 17);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(13, 204);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 3;
            label4.Text = "Power";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(13, 262);
            label5.Name = "label5";
            label5.Size = new Size(122, 17);
            label5.TabIndex = 4;
            label5.Text = "Score";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(13, 320);
            label6.Name = "label6";
            label6.Size = new Size(122, 17);
            label6.TabIndex = 5;
            label6.Text = "Rank";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(13, 380);
            label7.Name = "label7";
            label7.Size = new Size(122, 17);
            label7.TabIndex = 6;
            label7.Text = "Threat Level";
            // 
            // txtHeroID
            // 
            txtHeroID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHeroID.Location = new Point(141, 26);
            txtHeroID.MaxLength = 10;
            txtHeroID.Name = "txtHeroID";
            txtHeroID.Size = new Size(187, 25);
            txtHeroID.TabIndex = 0;
            // 
            // txtPower
            // 
            txtPower.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPower.Location = new Point(141, 200);
            txtPower.MaxLength = 50;
            txtPower.Name = "txtPower";
            txtPower.Size = new Size(187, 25);
            txtPower.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAge.Location = new Point(141, 142);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(187, 25);
            txtAge.TabIndex = 2;
            // 
            // txtScore
            // 
            txtScore.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtScore.Location = new Point(141, 258);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(187, 25);
            txtScore.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(141, 84);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 25);
            txtName.TabIndex = 1;
            // 
            // dgvRank
            // 
            dgvRank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRank.Columns.AddRange(new DataGridViewColumn[] { colRank });
            dgvRank.Location = new Point(141, 303);
            dgvRank.Name = "dgvRank";
            dgvRank.Size = new Size(187, 48);
            dgvRank.TabIndex = 7;
            // 
            // colRank
            // 
            colRank.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRank.HeaderText = "Rank";
            colRank.Name = "colRank";
            colRank.ReadOnly = true;
            // 
            // dgvThreat
            // 
            dgvThreat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThreat.Columns.AddRange(new DataGridViewColumn[] { colThreatLevel });
            dgvThreat.Location = new Point(141, 361);
            dgvThreat.Name = "dgvThreat";
            dgvThreat.Size = new Size(187, 49);
            dgvThreat.TabIndex = 8;
            // 
            // colThreatLevel
            // 
            colThreatLevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colThreatLevel.HeaderText = "Threat Level";
            colThreatLevel.Name = "colThreatLevel";
            colThreatLevel.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(dgvHero);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(356, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(8);
            groupBox2.Size = new Size(525, 555);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hero Details Display";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.Controls.Add(searchbtn, 0, 0);
            tableLayoutPanel3.Controls.Add(btnRefresh, 1, 0);
            tableLayoutPanel3.Controls.Add(button7, 2, 0);
            tableLayoutPanel3.Location = new Point(12, 450);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(505, 94);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // searchbtn
            // 
            searchbtn.Dock = DockStyle.Fill;
            searchbtn.Location = new Point(3, 3);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(162, 88);
            searchbtn.TabIndex = 0;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.Location = new Point(171, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(162, 88);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button6_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(339, 3);
            button7.Name = "button7";
            button7.Size = new Size(163, 88);
            button7.TabIndex = 2;
            button7.Text = "Summary";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTotalHeros, colAveAge, colAveScore });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(8, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(509, 56);
            dataGridView1.TabIndex = 1;
            // 
            // colTotalHeros
            // 
            colTotalHeros.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalHeros.FillWeight = 33F;
            colTotalHeros.HeaderText = "Total Heros";
            colTotalHeros.Name = "colTotalHeros";
            // 
            // colAveAge
            // 
            colAveAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAveAge.FillWeight = 33F;
            colAveAge.HeaderText = "Average Age";
            colAveAge.Name = "colAveAge";
            // 
            // colAveScore
            // 
            colAveScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAveScore.FillWeight = 34F;
            colAveScore.HeaderText = "Average Score";
            colAveScore.Name = "colAveScore";
            // 
            // dgvHero
            // 
            dgvHero.AllowUserToAddRows = false;
            dgvHero.AllowUserToDeleteRows = false;
            dgvHero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHero.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colAge, colPower, colScore, colThreat });
            dgvHero.Dock = DockStyle.Top;
            dgvHero.Location = new Point(8, 26);
            dgvHero.Name = "dgvHero";
            dgvHero.ReadOnly = true;
            dgvHero.Size = new Size(509, 363);
            dgvHero.TabIndex = 0;
            dgvHero.CellContentClick += dgvHero_CellContentClick;
            // 
            // colID
            // 
            colID.FillWeight = 12F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 18F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colAge
            // 
            colAge.FillWeight = 10F;
            colAge.HeaderText = "Age";
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            // 
            // colPower
            // 
            colPower.FillWeight = 20F;
            colPower.HeaderText = "Power";
            colPower.Name = "colPower";
            colPower.ReadOnly = true;
            // 
            // colScore
            // 
            colScore.FillWeight = 10F;
            colScore.HeaderText = "Score";
            colScore.Name = "colScore";
            colScore.ReadOnly = true;
            // 
            // colThreat
            // 
            colThreat.FillWeight = 20F;
            colThreat.HeaderText = "Threat";
            colThreat.Name = "colThreat";
            colThreat.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(900, 550);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Superhero Manager";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRank).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThreat).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHero).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeroID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.NumericUpDown txtAge;
        private System.Windows.Forms.NumericUpDown txtScore;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThreat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalHeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAveAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAveScore;
        private System.Windows.Forms.DataGridView dgvRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridView dgvThreat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThreatLevel;
    }
}

