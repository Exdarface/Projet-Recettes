namespace Recette
{
    partial class StepOne
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEtape1 = new System.Windows.Forms.Label();
            this.gpbFamille = new System.Windows.Forms.GroupBox();
            this.pnlFamilles = new System.Windows.Forms.Panel();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.pnlChoix = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblChoix = new System.Windows.Forms.Label();
            this.gpbFamille.SuspendLayout();
            this.pnlChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEtape1
            // 
            this.lblEtape1.AutoSize = true;
            this.lblEtape1.BackColor = System.Drawing.Color.Transparent;
            this.lblEtape1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape1.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblEtape1.Location = new System.Drawing.Point(12, 9);
            this.lblEtape1.Name = "lblEtape1";
            this.lblEtape1.Size = new System.Drawing.Size(76, 19);
            this.lblEtape1.TabIndex = 0;
            this.lblEtape1.Text = "Etape 1 :";
            // 
            // gpbFamille
            // 
            this.gpbFamille.BackColor = System.Drawing.Color.Transparent;
            this.gpbFamille.Controls.Add(this.pnlFamilles);
            this.gpbFamille.ForeColor = System.Drawing.Color.DarkOrange;
            this.gpbFamille.Location = new System.Drawing.Point(14, 41);
            this.gpbFamille.Name = "gpbFamille";
            this.gpbFamille.Size = new System.Drawing.Size(235, 450);
            this.gpbFamille.TabIndex = 1;
            this.gpbFamille.TabStop = false;
            this.gpbFamille.Text = "Familles d\'ingrédients";
            // 
            // pnlFamilles
            // 
            this.pnlFamilles.AutoScroll = true;
            this.pnlFamilles.Location = new System.Drawing.Point(5, 21);
            this.pnlFamilles.Name = "pnlFamilles";
            this.pnlFamilles.Size = new System.Drawing.Size(220, 419);
            this.pnlFamilles.TabIndex = 0;
            // 
            // pnlListe
            // 
            this.pnlListe.BackColor = System.Drawing.SystemColors.Control;
            this.pnlListe.Location = new System.Drawing.Point(277, 41);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(579, 278);
            this.pnlListe.TabIndex = 2;
            // 
            // pnlChoix
            // 
            this.pnlChoix.Controls.Add(this.lblChoix);
            this.pnlChoix.Location = new System.Drawing.Point(277, 342);
            this.pnlChoix.Name = "pnlChoix";
            this.pnlChoix.Size = new System.Drawing.Size(455, 139);
            this.pnlChoix.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(756, 435);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 46);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next step";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(19, 9);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(46, 17);
            this.lblChoix.TabIndex = 0;
            this.lblChoix.Text = "label1";
            // 
            // StepOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(883, 497);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlChoix);
            this.Controls.Add(this.pnlListe);
            this.Controls.Add(this.gpbFamille);
            this.Controls.Add(this.lblEtape1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StepOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qu\'est-ce qu\'on mange ce soir ?";
            this.Load += new System.EventHandler(this.StepOne_Load);
            this.gpbFamille.ResumeLayout(false);
            this.pnlChoix.ResumeLayout(false);
            this.pnlChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtape1;
        private System.Windows.Forms.GroupBox gpbFamille;
        private System.Windows.Forms.Panel pnlFamilles;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Panel pnlChoix;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblChoix;
    }
}

