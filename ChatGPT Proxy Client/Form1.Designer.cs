namespace ChatGPT_Proxy_Client
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.APIKEY = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic ChatGPT Proxy Client";
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.Gray;
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.Location = new System.Drawing.Point(13, 36);
            this.List.Multiline = true;
            this.List.Name = "List";
            this.List.ReadOnly = true;
            this.List.Size = new System.Drawing.Size(363, 305);
            this.List.TabIndex = 1;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(13, 348);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(241, 58);
            this.Message.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // APIKEY
            // 
            this.APIKEY.Location = new System.Drawing.Point(13, 413);
            this.APIKEY.Name = "APIKEY";
            this.APIKEY.Size = new System.Drawing.Size(241, 20);
            this.APIKEY.TabIndex = 4;
            this.APIKEY.Text = "";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(12, 439);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(124, 20);
            this.IP.TabIndex = 4;
            // 
            // PORT
            // 
            this.PORT.Location = new System.Drawing.Point(142, 439);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(112, 20);
            this.PORT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Api Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(257, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server IP | PORT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(388, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.APIKEY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox List;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox APIKEY;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox PORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

