namespace ArrayListSimpleEx
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
            this.btnShowMsg = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtSecondPos = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMsg
            // 
            this.btnShowMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMsg.Location = new System.Drawing.Point(77, 112);
            this.btnShowMsg.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnShowMsg.Name = "btnShowMsg";
            this.btnShowMsg.Size = new System.Drawing.Size(501, 72);
            this.btnShowMsg.TabIndex = 0;
            this.btnShowMsg.Text = "Display Message";
            this.btnShowMsg.UseVisualStyleBackColor = true;
            this.btnShowMsg.Click += new System.EventHandler(this.btnShowMsg_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.Location = new System.Drawing.Point(595, 112);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(501, 72);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "Display Message In Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(69, 253);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1027, 55);
            this.lblMessage.TabIndex = 2;
            // 
            // txtSecondPos
            // 
            this.txtSecondPos.Location = new System.Drawing.Point(77, 372);
            this.txtSecondPos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSecondPos.Name = "txtSecondPos";
            this.txtSecondPos.Size = new System.Drawing.Size(364, 38);
            this.txtSecondPos.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(464, 367);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(515, 55);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add to Second Position";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(515, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remove from Second Position";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSecondPos);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnShowMsg);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowMsg;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtSecondPos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
    }
}

