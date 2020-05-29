namespace SQLApp__
{
    partial class RechercheFournisseurs
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
            this.labelAsk = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAsk
            // 
            this.labelAsk.AutoSize = true;
            this.labelAsk.Location = new System.Drawing.Point(49, 36);
            this.labelAsk.Name = "labelAsk";
            this.labelAsk.Size = new System.Drawing.Size(44, 20);
            this.labelAsk.TabIndex = 0;
            this.labelAsk.Text = "Code";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(151, 33);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(95, 27);
            this.textBoxCode.TabIndex = 1;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(33, 88);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(95, 33);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(151, 88);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(95, 33);
            this.buttonQuitter.TabIndex = 4;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // RechercheFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 164);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelAsk);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RechercheFournisseurs";
            this.Text = "Recherche d\'un Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAsk;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonQuitter;
    }
}