namespace Recette
{
    partial class Step3UC
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
            this.pibMiniature = new System.Windows.Forms.PictureBox();
            this.pibHorloge = new System.Windows.Forms.PictureBox();
            this.pibPrice = new System.Windows.Forms.PictureBox();
            this.lblHorloge = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibMiniature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibHorloge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pibMiniature
            // 
            this.pibMiniature.Location = new System.Drawing.Point(16, 14);
            this.pibMiniature.Name = "pibMiniature";
            this.pibMiniature.Size = new System.Drawing.Size(149, 145);
            this.pibMiniature.TabIndex = 0;
            this.pibMiniature.TabStop = false;
            // 
            // pibHorloge
            // 
            this.pibHorloge.Location = new System.Drawing.Point(209, 74);
            this.pibHorloge.Name = "pibHorloge";
            this.pibHorloge.Size = new System.Drawing.Size(48, 45);
            this.pibHorloge.TabIndex = 1;
            this.pibHorloge.TabStop = false;
            // 
            // pibPrice
            // 
            this.pibPrice.Location = new System.Drawing.Point(433, 74);
            this.pibPrice.Name = "pibPrice";
            this.pibPrice.Size = new System.Drawing.Size(48, 45);
            this.pibPrice.TabIndex = 2;
            this.pibPrice.TabStop = false;
            // 
            // lblHorloge
            // 
            this.lblHorloge.AutoSize = true;
            this.lblHorloge.Location = new System.Drawing.Point(263, 90);
            this.lblHorloge.Name = "lblHorloge";
            this.lblHorloge.Size = new System.Drawing.Size(30, 13);
            this.lblHorloge.TabIndex = 3;
            this.lblHorloge.Text = "Time";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(487, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(215, 30);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(32, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Desc";
            // 
            // Step3UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblHorloge);
            this.Controls.Add(this.pibPrice);
            this.Controls.Add(this.pibHorloge);
            this.Controls.Add(this.pibMiniature);
            this.Name = "Step3UC";
            this.Size = new System.Drawing.Size(741, 180);
            this.Load += new System.EventHandler(this.Step3UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibMiniature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibHorloge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibMiniature;
        private System.Windows.Forms.PictureBox pibHorloge;
        private System.Windows.Forms.PictureBox pibPrice;
        private System.Windows.Forms.Label lblHorloge;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDesc;
    }
}
