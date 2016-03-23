namespace FormulaireMeh
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckcFrancais = new System.Windows.Forms.CheckBox();
            this.ckcAnglais = new System.Windows.Forms.CheckBox();
            this.ckcEco = new System.Windows.Forms.CheckBox();
            this.ckcMaths = new System.Windows.Forms.CheckBox();
            this.ckcSlam = new System.Windows.Forms.CheckBox();
            this.ckcTout = new System.Windows.Forms.CheckBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckcFrancais);
            this.groupBox1.Controls.Add(this.ckcAnglais);
            this.groupBox1.Controls.Add(this.ckcEco);
            this.groupBox1.Controls.Add(this.ckcMaths);
            this.groupBox1.Controls.Add(this.ckcSlam);
            this.groupBox1.Location = new System.Drawing.Point(43, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vous aimez :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ckcFrancais
            // 
            this.ckcFrancais.AutoSize = true;
            this.ckcFrancais.Location = new System.Drawing.Point(40, 113);
            this.ckcFrancais.Name = "ckcFrancais";
            this.ckcFrancais.Size = new System.Drawing.Size(76, 21);
            this.ckcFrancais.TabIndex = 6;
            this.ckcFrancais.Text = "Fraçais";
            this.ckcFrancais.UseVisualStyleBackColor = true;
            // 
            // ckcAnglais
            // 
            this.ckcAnglais.AutoSize = true;
            this.ckcAnglais.Location = new System.Drawing.Point(40, 167);
            this.ckcAnglais.Name = "ckcAnglais";
            this.ckcAnglais.Size = new System.Drawing.Size(76, 21);
            this.ckcAnglais.TabIndex = 5;
            this.ckcAnglais.Text = "Anglais";
            this.ckcAnglais.UseVisualStyleBackColor = true;
            // 
            // ckcEco
            // 
            this.ckcEco.AutoSize = true;
            this.ckcEco.Location = new System.Drawing.Point(40, 140);
            this.ckcEco.Name = "ckcEco";
            this.ckcEco.Size = new System.Drawing.Size(54, 21);
            this.ckcEco.TabIndex = 4;
            this.ckcEco.Text = "Eco";
            this.ckcEco.UseVisualStyleBackColor = true;
            // 
            // ckcMaths
            // 
            this.ckcMaths.AutoSize = true;
            this.ckcMaths.Location = new System.Drawing.Point(40, 86);
            this.ckcMaths.Name = "ckcMaths";
            this.ckcMaths.Size = new System.Drawing.Size(68, 21);
            this.ckcMaths.TabIndex = 2;
            this.ckcMaths.Text = "Maths";
            this.ckcMaths.UseVisualStyleBackColor = true;
            // 
            // ckcSlam
            // 
            this.ckcSlam.AutoSize = true;
            this.ckcSlam.Location = new System.Drawing.Point(40, 59);
            this.ckcSlam.Name = "ckcSlam";
            this.ckcSlam.Size = new System.Drawing.Size(61, 21);
            this.ckcSlam.TabIndex = 1;
            this.ckcSlam.Text = "Slam";
            this.ckcSlam.UseVisualStyleBackColor = true;
            // 
            // ckcTout
            // 
            this.ckcTout.AutoSize = true;
            this.ckcTout.Location = new System.Drawing.Point(45, 28);
            this.ckcTout.Name = "ckcTout";
            this.ckcTout.Size = new System.Drawing.Size(106, 21);
            this.ckcTout.TabIndex = 0;
            this.ckcTout.Text = "Tout cocher";
            this.ckcTout.UseVisualStyleBackColor = true;
            this.ckcTout.CheckedChanged += new System.EventHandler(this.ckcTout_CheckedChanged);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(352, 69);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(157, 75);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "Afficher les préférences";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(446, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 154);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckcTout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckcAnglais;
        private System.Windows.Forms.CheckBox ckcEco;
        private System.Windows.Forms.CheckBox ckcMaths;
        private System.Windows.Forms.CheckBox ckcSlam;
        private System.Windows.Forms.CheckBox ckcTout;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.CheckBox ckcFrancais;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

