namespace WinFormApi
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
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblQteCri = new System.Windows.Forms.Label();
            this.lblQteMin = new System.Windows.Forms.Label();
            this.lblPU = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.txtQteMin = new System.Windows.Forms.TextBox();
            this.txtQteCri = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSelectioner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(550, 12);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.Size = new System.Drawing.Size(389, 426);
            this.dgProduit.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSupprimer.FlatAppearance.BorderSize = 2;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Location = new System.Drawing.Point(12, 401);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(133, 37);
            this.btnSupprimer.TabIndex = 52;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.ForeColor = System.Drawing.Color.Red;
            this.lblCat.Location = new System.Drawing.Point(288, 310);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(41, 13);
            this.lblCat.TabIndex = 64;
            this.lblCat.Text = "label14";
            this.lblCat.Visible = false;
            // 
            // lblQteCri
            // 
            this.lblQteCri.AutoSize = true;
            this.lblQteCri.ForeColor = System.Drawing.Color.Red;
            this.lblQteCri.Location = new System.Drawing.Point(288, 199);
            this.lblQteCri.Name = "lblQteCri";
            this.lblQteCri.Size = new System.Drawing.Size(41, 13);
            this.lblQteCri.TabIndex = 63;
            this.lblQteCri.Text = "label13";
            this.lblQteCri.Visible = false;
            // 
            // lblQteMin
            // 
            this.lblQteMin.AutoSize = true;
            this.lblQteMin.ForeColor = System.Drawing.Color.Red;
            this.lblQteMin.Location = new System.Drawing.Point(6, 199);
            this.lblQteMin.Name = "lblQteMin";
            this.lblQteMin.Size = new System.Drawing.Size(41, 13);
            this.lblQteMin.TabIndex = 62;
            this.lblQteMin.Text = "label12";
            this.lblQteMin.Visible = false;
            // 
            // lblPU
            // 
            this.lblPU.AutoSize = true;
            this.lblPU.ForeColor = System.Drawing.Color.Red;
            this.lblPU.Location = new System.Drawing.Point(9, 310);
            this.lblPU.Name = "lblPU";
            this.lblPU.Size = new System.Drawing.Size(41, 13);
            this.lblPU.TabIndex = 61;
            this.lblPU.Text = "label11";
            this.lblPU.Visible = false;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.ForeColor = System.Drawing.Color.Red;
            this.lblDes.Location = new System.Drawing.Point(288, 86);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(41, 13);
            this.lblDes.TabIndex = 60;
            this.lblDes.Text = "label10";
            this.lblDes.Visible = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.Red;
            this.lblCode.Location = new System.Drawing.Point(12, 86);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 59;
            this.lblCode.Text = "label9";
            this.lblCode.Visible = false;
            // 
            // txtPU
            // 
            this.txtPU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPU.ForeColor = System.Drawing.Color.Black;
            this.txtPU.Location = new System.Drawing.Point(9, 274);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(238, 24);
            this.txtPU.TabIndex = 50;
            // 
            // txtQteMin
            // 
            this.txtQteMin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtQteMin.ForeColor = System.Drawing.Color.Black;
            this.txtQteMin.Location = new System.Drawing.Point(9, 162);
            this.txtQteMin.Name = "txtQteMin";
            this.txtQteMin.Size = new System.Drawing.Size(238, 24);
            this.txtQteMin.TabIndex = 48;
            // 
            // txtQteCri
            // 
            this.txtQteCri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQteCri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtQteCri.ForeColor = System.Drawing.Color.Black;
            this.txtQteCri.Location = new System.Drawing.Point(291, 162);
            this.txtQteCri.Name = "txtQteCri";
            this.txtQteCri.Size = new System.Drawing.Size(238, 24);
            this.txtQteCri.TabIndex = 49;
            // 
            // txtDesignation
            // 
            this.txtDesignation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.ForeColor = System.Drawing.Color.Black;
            this.txtDesignation.Location = new System.Drawing.Point(291, 50);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(238, 24);
            this.txtDesignation.TabIndex = 47;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(12, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(238, 24);
            this.txtCode.TabIndex = 46;
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(291, 272);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(238, 21);
            this.cbbCategorie.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Quantite critique";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Quantite minimale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Prix Unitaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Designation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Code";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModifier.FlatAppearance.BorderSize = 2;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Location = new System.Drawing.Point(196, 401);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(133, 37);
            this.btnModifier.TabIndex = 65;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSelectioner
            // 
            this.btnSelectioner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSelectioner.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSelectioner.FlatAppearance.BorderSize = 2;
            this.btnSelectioner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelectioner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectioner.Location = new System.Drawing.Point(334, 347);
            this.btnSelectioner.Name = "btnSelectioner";
            this.btnSelectioner.Size = new System.Drawing.Size(133, 37);
            this.btnSelectioner.TabIndex = 66;
            this.btnSelectioner.Text = "&Selectionner";
            this.btnSelectioner.UseVisualStyleBackColor = false;
            this.btnSelectioner.Click += new System.EventHandler(this.btnSelectioner_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAjouter.FlatAppearance.BorderSize = 2;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Location = new System.Drawing.Point(117, 347);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(133, 37);
            this.btnAjouter.TabIndex = 67;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEffacer.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEffacer.FlatAppearance.BorderSize = 2;
            this.btnEffacer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Location = new System.Drawing.Point(380, 401);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(133, 37);
            this.btnEffacer.TabIndex = 68;
            this.btnEffacer.Text = "&Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectioner);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblQteCri);
            this.Controls.Add(this.lblQteMin);
            this.Controls.Add(this.lblPU);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.txtQteMin);
            this.Controls.Add(this.txtQteCri);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgProduit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblQteCri;
        private System.Windows.Forms.Label lblQteMin;
        private System.Windows.Forms.Label lblPU;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.TextBox txtQteMin;
        private System.Windows.Forms.TextBox txtQteCri;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSelectioner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEffacer;
    }
}

