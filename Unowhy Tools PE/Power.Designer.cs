namespace Unowhy_Tools_PE
{
    partial class Power
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
            this.closebtn = new System.Windows.Forms.Button();
            this.rebootbtn = new System.Windows.Forms.Button();
            this.shutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(12, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(119, 91);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "Cancel";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // rebootbtn
            // 
            this.rebootbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebootbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebootbtn.Location = new System.Drawing.Point(137, 61);
            this.rebootbtn.Name = "rebootbtn";
            this.rebootbtn.Size = new System.Drawing.Size(119, 43);
            this.rebootbtn.TabIndex = 2;
            this.rebootbtn.Text = "Reboot";
            this.rebootbtn.UseVisualStyleBackColor = true;
            this.rebootbtn.Click += new System.EventHandler(this.rebootbtn_Click);
            // 
            // shutbtn
            // 
            this.shutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutbtn.Location = new System.Drawing.Point(137, 12);
            this.shutbtn.Name = "shutbtn";
            this.shutbtn.Size = new System.Drawing.Size(119, 43);
            this.shutbtn.TabIndex = 1;
            this.shutbtn.Text = "Shutdown";
            this.shutbtn.UseVisualStyleBackColor = true;
            this.shutbtn.Click += new System.EventHandler(this.shutbtn_Click);
            // 
            // Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(271, 115);
            this.ControlBox = false;
            this.Controls.Add(this.shutbtn);
            this.Controls.Add(this.rebootbtn);
            this.Controls.Add(this.closebtn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Power";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button rebootbtn;
        private System.Windows.Forms.Button shutbtn;
    }
}