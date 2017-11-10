namespace MyZoo.UI
{
    partial class Menu
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
            this.animalsBTN = new System.Windows.Forms.Button();
            this.veterinaryBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalsBTN
            // 
            this.animalsBTN.Location = new System.Drawing.Point(67, 84);
            this.animalsBTN.Name = "animalsBTN";
            this.animalsBTN.Size = new System.Drawing.Size(163, 63);
            this.animalsBTN.TabIndex = 0;
            this.animalsBTN.Text = "Animal Menu";
            this.animalsBTN.UseVisualStyleBackColor = true;
            this.animalsBTN.Click += new System.EventHandler(this.animalsBTN_Click);
            // 
            // veterinaryBTN
            // 
            this.veterinaryBTN.Location = new System.Drawing.Point(347, 84);
            this.veterinaryBTN.Name = "veterinaryBTN";
            this.veterinaryBTN.Size = new System.Drawing.Size(181, 63);
            this.veterinaryBTN.TabIndex = 1;
            this.veterinaryBTN.Text = "Veterinary Menu";
            this.veterinaryBTN.UseVisualStyleBackColor = true;
            this.veterinaryBTN.Click += new System.EventHandler(this.veterinaryBTN_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 259);
            this.Controls.Add(this.veterinaryBTN);
            this.Controls.Add(this.animalsBTN);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button animalsBTN;
        private System.Windows.Forms.Button veterinaryBTN;
    }
}