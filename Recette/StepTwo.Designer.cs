namespace Recette
{
    partial class StepTwo
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
            this.grpType = new System.Windows.Forms.GroupBox();
            this.grpBudget = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpType
            // 
            this.grpType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.Location = new System.Drawing.Point(61, 21);
            this.grpType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpType.Name = "grpType";
            this.grpType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpType.Size = new System.Drawing.Size(629, 231);
            this.grpType.TabIndex = 0;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type de plat";
            // 
            // grpBudget
            // 
            this.grpBudget.Location = new System.Drawing.Point(61, 273);
            this.grpBudget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBudget.Name = "grpBudget";
            this.grpBudget.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBudget.Size = new System.Drawing.Size(629, 122);
            this.grpBudget.TabIndex = 1;
            this.grpBudget.TabStop = false;
            this.grpBudget.Text = "Budget";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(69, 412);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(150, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Temps de cuisson";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 412);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Afficher les recettes";
            // 
            // StepTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpBudget);
            this.Controls.Add(this.grpType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StepTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StepTwo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.GroupBox grpBudget;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}