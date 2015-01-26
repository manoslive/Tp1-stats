namespace tp1_echantillonnage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RB_AleatoireSimple = new System.Windows.Forms.RadioButton();
            this.RB_Systematique = new System.Windows.Forms.RadioButton();
            this.DGV_Fichier = new System.Windows.Forms.DataGridView();
            this.DGV_Echantillon = new System.Windows.Forms.DataGridView();
            this.GB_Methodes = new System.Windows.Forms.GroupBox();
            this.GB_Fichier = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Generer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fichier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Echantillon)).BeginInit();
            this.GB_Methodes.SuspendLayout();
            this.GB_Fichier.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom des fichiers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Taille des échantillons:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 26);
            this.textBox2.TabIndex = 1;
            // 
            // RB_AleatoireSimple
            // 
            this.RB_AleatoireSimple.AutoSize = true;
            this.RB_AleatoireSimple.Location = new System.Drawing.Point(36, 45);
            this.RB_AleatoireSimple.Name = "RB_AleatoireSimple";
            this.RB_AleatoireSimple.Size = new System.Drawing.Size(146, 24);
            this.RB_AleatoireSimple.TabIndex = 2;
            this.RB_AleatoireSimple.TabStop = true;
            this.RB_AleatoireSimple.Text = "Aléatoire simple";
            this.RB_AleatoireSimple.UseVisualStyleBackColor = true;
            // 
            // RB_Systematique
            // 
            this.RB_Systematique.AutoSize = true;
            this.RB_Systematique.Location = new System.Drawing.Point(36, 75);
            this.RB_Systematique.Name = "RB_Systematique";
            this.RB_Systematique.Size = new System.Drawing.Size(131, 24);
            this.RB_Systematique.TabIndex = 2;
            this.RB_Systematique.TabStop = true;
            this.RB_Systematique.Text = "Systématique";
            this.RB_Systematique.UseVisualStyleBackColor = true;
            // 
            // DGV_Fichier
            // 
            this.DGV_Fichier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Fichier.Location = new System.Drawing.Point(28, 215);
            this.DGV_Fichier.Name = "DGV_Fichier";
            this.DGV_Fichier.RowTemplate.Height = 28;
            this.DGV_Fichier.Size = new System.Drawing.Size(226, 372);
            this.DGV_Fichier.TabIndex = 3;
            // 
            // DGV_Echantillon
            // 
            this.DGV_Echantillon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Echantillon.Location = new System.Drawing.Point(344, 215);
            this.DGV_Echantillon.Name = "DGV_Echantillon";
            this.DGV_Echantillon.Size = new System.Drawing.Size(578, 372);
            this.DGV_Echantillon.TabIndex = 3;
            // 
            // GB_Methodes
            // 
            this.GB_Methodes.Controls.Add(this.RB_Systematique);
            this.GB_Methodes.Controls.Add(this.RB_AleatoireSimple);
            this.GB_Methodes.Location = new System.Drawing.Point(544, 22);
            this.GB_Methodes.Name = "GB_Methodes";
            this.GB_Methodes.Size = new System.Drawing.Size(368, 178);
            this.GB_Methodes.TabIndex = 4;
            this.GB_Methodes.TabStop = false;
            this.GB_Methodes.Text = "Méthodes d\'échantillonnage";
            // 
            // GB_Fichier
            // 
            this.GB_Fichier.Controls.Add(this.textBox3);
            this.GB_Fichier.Controls.Add(this.textBox2);
            this.GB_Fichier.Controls.Add(this.label1);
            this.GB_Fichier.Controls.Add(this.label3);
            this.GB_Fichier.Controls.Add(this.label2);
            this.GB_Fichier.Controls.Add(this.textBox1);
            this.GB_Fichier.Location = new System.Drawing.Point(28, 12);
            this.GB_Fichier.Name = "GB_Fichier";
            this.GB_Fichier.Size = new System.Drawing.Size(436, 178);
            this.GB_Fichier.TabIndex = 4;
            this.GB_Fichier.TabStop = false;
            this.GB_Fichier.Text = "Information sur l\'échantillon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre d\'échantillon:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 26);
            this.textBox3.TabIndex = 1;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(813, 610);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(109, 39);
            this.BTN_Save.TabIndex = 5;
            this.BTN_Save.Text = "Sauvegarder";
            this.BTN_Save.UseVisualStyleBackColor = true;
            // 
            // BTN_Generer
            // 
            this.BTN_Generer.Location = new System.Drawing.Point(698, 610);
            this.BTN_Generer.Name = "BTN_Generer";
            this.BTN_Generer.Size = new System.Drawing.Size(109, 39);
            this.BTN_Generer.TabIndex = 5;
            this.BTN_Generer.Text = "Générer";
            this.BTN_Generer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 661);
            this.Controls.Add(this.BTN_Generer);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.GB_Fichier);
            this.Controls.Add(this.GB_Methodes);
            this.Controls.Add(this.DGV_Echantillon);
            this.Controls.Add(this.DGV_Fichier);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fichier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Echantillon)).EndInit();
            this.GB_Methodes.ResumeLayout(false);
            this.GB_Methodes.PerformLayout();
            this.GB_Fichier.ResumeLayout(false);
            this.GB_Fichier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton RB_AleatoireSimple;
        private System.Windows.Forms.RadioButton RB_Systematique;
        private System.Windows.Forms.DataGridView DGV_Fichier;
        private System.Windows.Forms.DataGridView DGV_Echantillon;
        private System.Windows.Forms.GroupBox GB_Methodes;
        private System.Windows.Forms.GroupBox GB_Fichier;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Generer;
    }
}

