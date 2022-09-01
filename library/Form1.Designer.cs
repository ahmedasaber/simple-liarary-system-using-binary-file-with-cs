namespace library
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
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.filetextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pagecounttb = new System.Windows.Forms.TextBox();
            this.isbntb = new System.Windows.Forms.TextBox();
            this.typetb = new System.Windows.Forms.TextBox();
            this.titletb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(276, 71);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(88, 39);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(380, 71);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 39);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // filetextbox
            // 
            this.filetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filetextbox.Location = new System.Drawing.Point(122, 72);
            this.filetextbox.Name = "filetextbox";
            this.filetextbox.Size = new System.Drawing.Size(100, 27);
            this.filetextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "FileName";
            // 
            // pagecounttb
            // 
            this.pagecounttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagecounttb.Location = new System.Drawing.Point(122, 291);
            this.pagecounttb.Name = "pagecounttb";
            this.pagecounttb.Size = new System.Drawing.Size(100, 27);
            this.pagecounttb.TabIndex = 4;
            // 
            // isbntb
            // 
            this.isbntb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbntb.Location = new System.Drawing.Point(122, 160);
            this.isbntb.Name = "isbntb";
            this.isbntb.Size = new System.Drawing.Size(100, 27);
            this.isbntb.TabIndex = 5;
            // 
            // typetb
            // 
            this.typetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetb.Location = new System.Drawing.Point(122, 203);
            this.typetb.Name = "typetb";
            this.typetb.Size = new System.Drawing.Size(100, 27);
            this.typetb.TabIndex = 6;
            // 
            // titletb
            // 
            this.titletb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletb.Location = new System.Drawing.Point(122, 248);
            this.titletb.Name = "titletb";
            this.titletb.Size = new System.Drawing.Size(100, 27);
            this.titletb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Page_Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price";
            // 
            // pricetb
            // 
            this.pricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetb.Location = new System.Drawing.Point(122, 335);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(100, 27);
            this.pricetb.TabIndex = 12;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(334, 143);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 28);
            this.Save.TabIndex = 14;
            this.Save.Text = "Insert";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.OrangeRed;
            this.label.Location = new System.Drawing.Point(119, 122);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 17);
            this.label.TabIndex = 15;
            this.label.Text = "File exists";
            this.label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 417);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titletb);
            this.Controls.Add(this.typetb);
            this.Controls.Add(this.isbntb);
            this.Controls.Add(this.pagecounttb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filetextbox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox filetextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pagecounttb;
        private System.Windows.Forms.TextBox isbntb;
        private System.Windows.Forms.TextBox typetb;
        private System.Windows.Forms.TextBox titletb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label;
    }
}

