namespace Recette
{
    partial class Buttons
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUC
            // 
            this.btnUC.Location = new System.Drawing.Point(3, 3);
            this.btnUC.Name = "btnUC";
            this.btnUC.Size = new System.Drawing.Size(134, 30);
            this.btnUC.TabIndex = 1;
            this.btnUC.Text = "button1";
            this.btnUC.UseVisualStyleBackColor = true;
            this.btnUC.Click += new System.EventHandler(this.btnUC_Click);
            // 
            // Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUC);
            this.Name = "Buttons";
            this.Size = new System.Drawing.Size(143, 38);
            this.Load += new System.EventHandler(this.Buttons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUC;
    }
}
