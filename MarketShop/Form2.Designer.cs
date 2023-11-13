namespace MarketShop
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.family = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(818, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 38);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(818, 279);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 38);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(818, 359);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 38);
            this.textBox3.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(1255, 215);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(89, 32);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // family
            // 
            this.family.AutoSize = true;
            this.family.Location = new System.Drawing.Point(1246, 285);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(98, 32);
            this.family.TabIndex = 1;
            this.family.Text = "Family";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(1247, 362);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(97, 32);
            this.phone.TabIndex = 1;
            this.phone.Text = "Phone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 268);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 824);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.family);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label family;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button button1;
    }
}