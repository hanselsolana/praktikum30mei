namespace praktikum30mei
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
            this.btn_leftt = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_rightt = new System.Windows.Forms.Button();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.lblteamname = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.lblmanager = new System.Windows.Forms.Label();
            this.lblstadium = new System.Windows.Forms.Label();
            this.lblpenalty = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.lbl_manager = new System.Windows.Forms.Label();
            this.lbl_stadium = new System.Windows.Forms.Label();
            this.lbl_topscore = new System.Windows.Forms.Label();
            this.lbl_worstdiscipline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_leftt
            // 
            this.btn_leftt.Location = new System.Drawing.Point(50, 12);
            this.btn_leftt.Name = "btn_leftt";
            this.btn_leftt.Size = new System.Drawing.Size(67, 59);
            this.btn_leftt.TabIndex = 0;
            this.btn_leftt.Text = "<<";
            this.btn_leftt.UseVisualStyleBackColor = true;
            this.btn_leftt.Click += new System.EventHandler(this.btn_leftt_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(135, 12);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(67, 59);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(222, 12);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(67, 59);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_rightt
            // 
            this.btn_rightt.Location = new System.Drawing.Point(310, 12);
            this.btn_rightt.Name = "btn_rightt";
            this.btn_rightt.Size = new System.Drawing.Size(67, 59);
            this.btn_rightt.TabIndex = 3;
            this.btn_rightt.Text = ">>";
            this.btn_rightt.UseVisualStyleBackColor = true;
            this.btn_rightt.Click += new System.EventHandler(this.btn_rightt_Click);
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(77, 225);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 62;
            this.dgv_data.RowTemplate.Height = 28;
            this.dgv_data.Size = new System.Drawing.Size(659, 178);
            this.dgv_data.TabIndex = 4;
            // 
            // lblteamname
            // 
            this.lblteamname.AutoSize = true;
            this.lblteamname.Location = new System.Drawing.Point(53, 74);
            this.lblteamname.Name = "lblteamname";
            this.lblteamname.Size = new System.Drawing.Size(103, 20);
            this.lblteamname.TabIndex = 5;
            this.lblteamname.Text = "Team Name :";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(66, 164);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(99, 20);
            this.lblscore.TabIndex = 6;
            this.lblscore.Text = "Top Scorer : ";
            // 
            // lblmanager
            // 
            this.lblmanager.AutoSize = true;
            this.lblmanager.Location = new System.Drawing.Point(78, 103);
            this.lblmanager.Name = "lblmanager";
            this.lblmanager.Size = new System.Drawing.Size(80, 20);
            this.lblmanager.TabIndex = 7;
            this.lblmanager.Text = "Manager :";
            // 
            // lblstadium
            // 
            this.lblstadium.AutoSize = true;
            this.lblstadium.Location = new System.Drawing.Point(84, 134);
            this.lblstadium.Name = "lblstadium";
            this.lblstadium.Size = new System.Drawing.Size(76, 20);
            this.lblstadium.TabIndex = 8;
            this.lblstadium.Text = "Stadium :";
            // 
            // lblpenalty
            // 
            this.lblpenalty.AutoSize = true;
            this.lblpenalty.Location = new System.Drawing.Point(31, 193);
            this.lblpenalty.Name = "lblpenalty";
            this.lblpenalty.Size = new System.Drawing.Size(134, 20);
            this.lblpenalty.TabIndex = 9;
            this.lblpenalty.Text = "Worst Discipline : ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Location = new System.Drawing.Point(175, 74);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(51, 20);
            this.lbl_teamname.TabIndex = 10;
            this.lbl_teamname.Text = "label1";
            // 
            // lbl_manager
            // 
            this.lbl_manager.AutoSize = true;
            this.lbl_manager.Location = new System.Drawing.Point(175, 103);
            this.lbl_manager.Name = "lbl_manager";
            this.lbl_manager.Size = new System.Drawing.Size(51, 20);
            this.lbl_manager.TabIndex = 11;
            this.lbl_manager.Text = "label2";
            // 
            // lbl_stadium
            // 
            this.lbl_stadium.AutoSize = true;
            this.lbl_stadium.Location = new System.Drawing.Point(175, 134);
            this.lbl_stadium.Name = "lbl_stadium";
            this.lbl_stadium.Size = new System.Drawing.Size(51, 20);
            this.lbl_stadium.TabIndex = 12;
            this.lbl_stadium.Text = "label3";
            this.lbl_stadium.Click += new System.EventHandler(this.lbl_stadium_Click);
            // 
            // lbl_topscore
            // 
            this.lbl_topscore.AutoSize = true;
            this.lbl_topscore.Location = new System.Drawing.Point(175, 164);
            this.lbl_topscore.Name = "lbl_topscore";
            this.lbl_topscore.Size = new System.Drawing.Size(51, 20);
            this.lbl_topscore.TabIndex = 13;
            this.lbl_topscore.Text = "label4";
            // 
            // lbl_worstdiscipline
            // 
            this.lbl_worstdiscipline.AutoSize = true;
            this.lbl_worstdiscipline.Location = new System.Drawing.Point(175, 193);
            this.lbl_worstdiscipline.Name = "lbl_worstdiscipline";
            this.lbl_worstdiscipline.Size = new System.Drawing.Size(51, 20);
            this.lbl_worstdiscipline.TabIndex = 14;
            this.lbl_worstdiscipline.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_worstdiscipline);
            this.Controls.Add(this.lbl_topscore);
            this.Controls.Add(this.lbl_stadium);
            this.Controls.Add(this.lbl_manager);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.lblpenalty);
            this.Controls.Add(this.lblstadium);
            this.Controls.Add(this.lblmanager);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblteamname);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_rightt);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_leftt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_leftt;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_rightt;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Label lblteamname;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblmanager;
        private System.Windows.Forms.Label lblstadium;
        private System.Windows.Forms.Label lblpenalty;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lbl_worstdiscipline;
        private System.Windows.Forms.Label lbl_topscore;
        private System.Windows.Forms.Label lbl_stadium;
        private System.Windows.Forms.Label lbl_manager;
        private System.Windows.Forms.Label lbl_teamname;
    }
}

