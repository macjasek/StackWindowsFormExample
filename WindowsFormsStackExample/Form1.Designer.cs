namespace WindowsFormsStackExample
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
            this.btnPush = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pushValue = new System.Windows.Forms.TextBox();
            this.labelPush = new System.Windows.Forms.Label();
            this.btnPushOK = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(12, 49);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 0;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz opcje";
            // 
            // pushValue
            // 
            this.pushValue.Location = new System.Drawing.Point(105, 87);
            this.pushValue.Name = "pushValue";
            this.pushValue.Size = new System.Drawing.Size(308, 20);
            this.pushValue.TabIndex = 2;
            this.pushValue.Visible = false;
            // 
            // labelPush
            // 
            this.labelPush.AutoSize = true;
            this.labelPush.Location = new System.Drawing.Point(12, 94);
            this.labelPush.Name = "labelPush";
            this.labelPush.Size = new System.Drawing.Size(76, 13);
            this.labelPush.TabIndex = 3;
            this.labelPush.Text = "Wpisz wartość";
            this.labelPush.Visible = false;
            // 
            // btnPushOK
            // 
            this.btnPushOK.Location = new System.Drawing.Point(338, 113);
            this.btnPushOK.Name = "btnPushOK";
            this.btnPushOK.Size = new System.Drawing.Size(75, 23);
            this.btnPushOK.TabIndex = 4;
            this.btnPushOK.Text = "OK";
            this.btnPushOK.UseVisualStyleBackColor = true;
            this.btnPushOK.Visible = false;
            this.btnPushOK.Click += new System.EventHandler(this.btnPushOK_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(94, 49);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 5;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(175, 49);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(75, 23);
            this.btnPeek.TabIndex = 6;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(256, 49);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 7;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(338, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 148);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPushOK);
            this.Controls.Add(this.labelPush);
            this.Controls.Add(this.pushValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPush);
            this.Name = "Form1";
            this.Text = "Stack Windows Form Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pushValue;
        private System.Windows.Forms.Label labelPush;
        private System.Windows.Forms.Button btnPushOK;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnExit;
    }
}

