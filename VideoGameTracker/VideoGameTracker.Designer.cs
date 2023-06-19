namespace VideoGameTracker
{
    partial class VideoGameTrackerForm
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
            this.btngamelist = new System.Windows.Forms.Button();
            this.btnrent = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btncustomers = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngamelist
            // 
            this.btngamelist.Location = new System.Drawing.Point(93, 57);
            this.btngamelist.Name = "btngamelist";
            this.btngamelist.Size = new System.Drawing.Size(114, 52);
            this.btngamelist.TabIndex = 0;
            this.btngamelist.Text = "Game List";
            this.btngamelist.UseVisualStyleBackColor = true;
            this.btngamelist.Click += new System.EventHandler(this.btngamelist_Click);
            // 
            // btnrent
            // 
            this.btnrent.Location = new System.Drawing.Point(239, 57);
            this.btnrent.Name = "btnrent";
            this.btnrent.Size = new System.Drawing.Size(114, 52);
            this.btnrent.TabIndex = 1;
            this.btnrent.Text = "Rent";
            this.btnrent.UseVisualStyleBackColor = true;
            this.btnrent.Click += new System.EventHandler(this.btnrent_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(93, 137);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(114, 52);
            this.btnreturn.TabIndex = 2;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btncustomers
            // 
            this.btncustomers.Location = new System.Drawing.Point(239, 137);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Size = new System.Drawing.Size(114, 52);
            this.btncustomers.TabIndex = 3;
            this.btncustomers.Text = "Customer List";
            this.btncustomers.UseVisualStyleBackColor = true;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // txtinput
            // 
            this.txtinput.Enabled = false;
            this.txtinput.Location = new System.Drawing.Point(93, 213);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(260, 20);
            this.txtinput.TabIndex = 4;
            this.txtinput.Visible = false;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Enabled = false;
            this.btnconfirm.Location = new System.Drawing.Point(184, 239);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 5;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Visible = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(184, 239);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // VideoGameTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 275);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btncustomers);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnrent);
            this.Controls.Add(this.btngamelist);
            this.Name = "VideoGameTrackerForm";
            this.Text = "Video Game Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngamelist;
        private System.Windows.Forms.Button btnrent;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btncustomers;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnexit;
    }
}

