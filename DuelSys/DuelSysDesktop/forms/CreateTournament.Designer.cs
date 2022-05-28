namespace DuelSysDesktop.forms
{
    partial class CreateTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournament));
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblMaxPlayers = new System.Windows.Forms.Label();
            this.lblMinPlayers = new System.Windows.Forms.Label();
            this.cbSport = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblSport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.RichTextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.tbMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.tbMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSystem = new System.Windows.Forms.ComboBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreateTourney = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(448, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "* Fields are required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(136, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "*";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(379, 222);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 20);
            this.lblLocation.TabIndex = 75;
            this.lblLocation.Text = "Location";
            // 
            // tbLocation
            // 
            this.tbLocation.BackColor = System.Drawing.Color.Gainsboro;
            this.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocation.Location = new System.Drawing.Point(379, 245);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(192, 27);
            this.tbLocation.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(141, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(102, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "*";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(59, 316);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 20);
            this.lblStartDate.TabIndex = 69;
            this.lblStartDate.Text = "Start date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblEndDate.Location = new System.Drawing.Point(62, 387);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(68, 20);
            this.lblEndDate.TabIndex = 67;
            this.lblEndDate.Text = "End date";
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.ForeColor = System.Drawing.Color.Black;
            this.lblMaxPlayers.Location = new System.Drawing.Point(380, 133);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(88, 20);
            this.lblMaxPlayers.TabIndex = 66;
            this.lblMaxPlayers.Text = "Max players";
            // 
            // lblMinPlayers
            // 
            this.lblMinPlayers.AutoSize = true;
            this.lblMinPlayers.ForeColor = System.Drawing.Color.Black;
            this.lblMinPlayers.Location = new System.Drawing.Point(378, 44);
            this.lblMinPlayers.Name = "lblMinPlayers";
            this.lblMinPlayers.Size = new System.Drawing.Size(88, 20);
            this.lblMinPlayers.TabIndex = 65;
            this.lblMinPlayers.Text = "Min. players";
            // 
            // cbSport
            // 
            this.cbSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Items.AddRange(new object[] {
            "Badminton"});
            this.cbSport.Location = new System.Drawing.Point(60, 139);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(256, 28);
            this.cbSport.TabIndex = 64;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.Location = new System.Drawing.Point(60, 176);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(85, 20);
            this.lblDesc.TabIndex = 63;
            this.lblDesc.Text = "Description";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.ForeColor = System.Drawing.Color.Black;
            this.lblSport.Location = new System.Drawing.Point(60, 111);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(45, 20);
            this.lblSport.TabIndex = 62;
            this.lblSport.Text = "Sport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(450, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(451, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(472, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(139, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "*";
            // 
            // tbDesc
            // 
            this.tbDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDesc.Location = new System.Drawing.Point(59, 203);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(257, 92);
            this.tbDesc.TabIndex = 80;
            this.tbDesc.Text = "";
            // 
            // dtStart
            // 
            this.dtStart.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtStart.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtStart.Location = new System.Drawing.Point(59, 339);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(257, 27);
            this.dtStart.TabIndex = 82;
            // 
            // dtEnd
            // 
            this.dtEnd.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtEnd.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtEnd.Location = new System.Drawing.Point(59, 410);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(257, 27);
            this.dtEnd.TabIndex = 83;
            // 
            // tbMinPlayers
            // 
            this.tbMinPlayers.BackColor = System.Drawing.Color.Gainsboro;
            this.tbMinPlayers.Location = new System.Drawing.Point(379, 72);
            this.tbMinPlayers.Name = "tbMinPlayers";
            this.tbMinPlayers.Size = new System.Drawing.Size(129, 27);
            this.tbMinPlayers.TabIndex = 84;
            // 
            // tbMaxPlayers
            // 
            this.tbMaxPlayers.BackColor = System.Drawing.Color.Gainsboro;
            this.tbMaxPlayers.Location = new System.Drawing.Point(380, 162);
            this.tbMaxPlayers.Name = "tbMaxPlayers";
            this.tbMaxPlayers.Size = new System.Drawing.Size(128, 27);
            this.tbMaxPlayers.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(429, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 25);
            this.label8.TabIndex = 88;
            this.label8.Text = "*";
            // 
            // cbSystem
            // 
            this.cbSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSystem.FormattingEnabled = true;
            this.cbSystem.Items.AddRange(new object[] {
            "Round-robin",
            "Single-elimination"});
            this.cbSystem.Location = new System.Drawing.Point(379, 334);
            this.cbSystem.Name = "cbSystem";
            this.cbSystem.Size = new System.Drawing.Size(192, 28);
            this.cbSystem.TabIndex = 87;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.ForeColor = System.Drawing.Color.Black;
            this.lblSystem.Location = new System.Drawing.Point(379, 306);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(56, 20);
            this.lblSystem.TabIndex = 86;
            this.lblSystem.Text = "System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(473, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 25);
            this.label10.TabIndex = 89;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(446, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 25);
            this.label11.TabIndex = 90;
            this.label11.Text = "*";
            // 
            // btnCreateTourney
            // 
            this.btnCreateTourney.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateTourney.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateTourney.FlatAppearance.BorderSize = 0;
            this.btnCreateTourney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTourney.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTourney.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateTourney.Location = new System.Drawing.Point(0, 505);
            this.btnCreateTourney.Name = "btnCreateTourney";
            this.btnCreateTourney.Size = new System.Drawing.Size(623, 49);
            this.btnCreateTourney.TabIndex = 91;
            this.btnCreateTourney.Text = "Create Tournament";
            this.btnCreateTourney.UseVisualStyleBackColor = false;
            this.btnCreateTourney.Click += new System.EventHandler(this.btnCreateTourney_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(110, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 25);
            this.label12.TabIndex = 94;
            this.label12.Text = "*";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 93;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(59, 72);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(192, 27);
            this.tbName.TabIndex = 92;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 554);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCreateTourney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSystem);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.tbMaxPlayers);
            this.Controls.Add(this.tbMinPlayers);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblMaxPlayers);
            this.Controls.Add(this.lblMinPlayers);
            this.Controls.Add(this.cbSport);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournament";
            this.Text = "Create Tournament";
            ((System.ComponentModel.ISupportInitialize)(this.tbMinPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label6;
        private Label lblLocation;
        private TextBox tbLocation;
        private Label label2;
        private Label label1;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblMaxPlayers;
        private Label lblMinPlayers;
        private ComboBox cbSport;
        private Label lblDesc;
        private Label lblSport;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private RichTextBox tbDesc;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private NumericUpDown tbMinPlayers;
        private NumericUpDown tbMaxPlayers;
        private Label label8;
        private ComboBox cbSystem;
        private Label lblSystem;
        private Label label10;
        private Label label11;
        private Button btnCreateTourney;
        private Label label12;
        private Label lblName;
        private TextBox tbName;
    }
}