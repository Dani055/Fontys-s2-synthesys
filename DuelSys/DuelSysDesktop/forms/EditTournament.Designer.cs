namespace DuelSysDesktop.forms
{
    partial class EditTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTournament));
            this.btnEditTourney = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSystem = new System.Windows.Forms.ComboBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.tbMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.tbMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.tbDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label12 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditTourney
            // 
            this.btnEditTourney.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditTourney.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditTourney.FlatAppearance.BorderSize = 0;
            this.btnEditTourney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTourney.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditTourney.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditTourney.Location = new System.Drawing.Point(0, 506);
            this.btnEditTourney.Name = "btnEditTourney";
            this.btnEditTourney.Size = new System.Drawing.Size(605, 49);
            this.btnEditTourney.TabIndex = 119;
            this.btnEditTourney.Text = "Edit Tournament";
            this.btnEditTourney.UseVisualStyleBackColor = false;
            this.btnEditTourney.Click += new System.EventHandler(this.btnEditTourney_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(442, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 25);
            this.label11.TabIndex = 118;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(469, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 25);
            this.label10.TabIndex = 117;
            this.label10.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(425, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 25);
            this.label8.TabIndex = 116;
            this.label8.Text = "*";
            // 
            // cbSystem
            // 
            this.cbSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSystem.FormattingEnabled = true;
            this.cbSystem.Items.AddRange(new object[] {
            "Round-robin",
            "Single-elimination"});
            this.cbSystem.Location = new System.Drawing.Point(375, 318);
            this.cbSystem.Name = "cbSystem";
            this.cbSystem.Size = new System.Drawing.Size(192, 28);
            this.cbSystem.TabIndex = 115;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.ForeColor = System.Drawing.Color.Black;
            this.lblSystem.Location = new System.Drawing.Point(375, 290);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(56, 20);
            this.lblSystem.TabIndex = 114;
            this.lblSystem.Text = "System";
            // 
            // tbMaxPlayers
            // 
            this.tbMaxPlayers.BackColor = System.Drawing.Color.Gainsboro;
            this.tbMaxPlayers.Location = new System.Drawing.Point(376, 146);
            this.tbMaxPlayers.Name = "tbMaxPlayers";
            this.tbMaxPlayers.Size = new System.Drawing.Size(128, 27);
            this.tbMaxPlayers.TabIndex = 113;
            // 
            // tbMinPlayers
            // 
            this.tbMinPlayers.BackColor = System.Drawing.Color.Gainsboro;
            this.tbMinPlayers.Location = new System.Drawing.Point(375, 56);
            this.tbMinPlayers.Name = "tbMinPlayers";
            this.tbMinPlayers.Size = new System.Drawing.Size(129, 27);
            this.tbMinPlayers.TabIndex = 112;
            // 
            // dtEnd
            // 
            this.dtEnd.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtEnd.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtEnd.Location = new System.Drawing.Point(56, 387);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(257, 27);
            this.dtEnd.TabIndex = 111;
            // 
            // dtStart
            // 
            this.dtStart.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtStart.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtStart.Location = new System.Drawing.Point(56, 316);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(257, 27);
            this.dtStart.TabIndex = 110;
            // 
            // tbDesc
            // 
            this.tbDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDesc.Location = new System.Drawing.Point(56, 180);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(257, 92);
            this.tbDesc.TabIndex = 109;
            this.tbDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(136, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 108;
            this.label7.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(468, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 107;
            this.label5.Text = "*";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(435, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 106;
            this.label9.Text = "* Fields are required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(133, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 105;
            this.label6.Text = "*";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(375, 206);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 20);
            this.lblLocation.TabIndex = 104;
            this.lblLocation.Text = "Location";
            // 
            // tbLocation
            // 
            this.tbLocation.BackColor = System.Drawing.Color.Gainsboro;
            this.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocation.Location = new System.Drawing.Point(375, 229);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(192, 27);
            this.tbLocation.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(138, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(99, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "*";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(56, 293);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 20);
            this.lblStartDate.TabIndex = 98;
            this.lblStartDate.Text = "Start date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblEndDate.Location = new System.Drawing.Point(59, 364);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(68, 20);
            this.lblEndDate.TabIndex = 97;
            this.lblEndDate.Text = "End date";
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.ForeColor = System.Drawing.Color.Black;
            this.lblMaxPlayers.Location = new System.Drawing.Point(376, 117);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(88, 20);
            this.lblMaxPlayers.TabIndex = 96;
            this.lblMaxPlayers.Text = "Max players";
            // 
            // lblMinPlayers
            // 
            this.lblMinPlayers.AutoSize = true;
            this.lblMinPlayers.ForeColor = System.Drawing.Color.Black;
            this.lblMinPlayers.Location = new System.Drawing.Point(374, 28);
            this.lblMinPlayers.Name = "lblMinPlayers";
            this.lblMinPlayers.Size = new System.Drawing.Size(88, 20);
            this.lblMinPlayers.TabIndex = 95;
            this.lblMinPlayers.Text = "Min. players";
            // 
            // cbSport
            // 
            this.cbSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Items.AddRange(new object[] {
            "Badminton"});
            this.cbSport.Location = new System.Drawing.Point(57, 116);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(256, 28);
            this.cbSport.TabIndex = 94;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.Location = new System.Drawing.Point(57, 153);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(85, 20);
            this.lblDesc.TabIndex = 93;
            this.lblDesc.Text = "Description";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.ForeColor = System.Drawing.Color.Black;
            this.lblSport.Location = new System.Drawing.Point(57, 88);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(45, 20);
            this.lblSport.TabIndex = 92;
            this.lblSport.Text = "Sport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(446, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(447, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 102;
            this.label4.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(110, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 25);
            this.label12.TabIndex = 122;
            this.label12.Text = "*";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 121;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(59, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(192, 27);
            this.tbName.TabIndex = 120;
            // 
            // EditTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 555);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnEditTourney);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTournament";
            this.Text = "Edit tournament";
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditTourney;
        private Label label11;
        private Label label10;
        private Label label8;
        private ComboBox cbSystem;
        private Label lblSystem;
        private NumericUpDown tbMaxPlayers;
        private NumericUpDown tbMinPlayers;
        private DateTimePicker dtEnd;
        private DateTimePicker dtStart;
        private RichTextBox tbDesc;
        private Label label7;
        private Label label5;
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
        private Label label12;
        private Label lblName;
        private TextBox tbName;
    }
}