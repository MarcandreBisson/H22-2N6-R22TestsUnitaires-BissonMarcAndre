﻿namespace Thermostat
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnDiminuer;
        private System.Windows.Forms.Button btnAugmenter;
        private System.Windows.Forms.Label lblTemperature;


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
            this.btnDiminuer = new System.Windows.Forms.Button();
            this.btnAugmenter = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAffichageTempMin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAffichageTempMax = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAffichageTempCourante = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDiminuer
            // 
            this.btnDiminuer.BackColor = System.Drawing.Color.Transparent;
            this.btnDiminuer.FlatAppearance.BorderSize = 0;
            this.btnDiminuer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDiminuer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDiminuer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiminuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuer.Location = new System.Drawing.Point(210, 114);
            this.btnDiminuer.Name = "btnDiminuer";
            this.btnDiminuer.Size = new System.Drawing.Size(24, 28);
            this.btnDiminuer.TabIndex = 1;
            this.btnDiminuer.UseVisualStyleBackColor = false;
            this.btnDiminuer.Click += new System.EventHandler(this.btnDiminuer_Click);
            // 
            // btnAugmenter
            // 
            this.btnAugmenter.BackColor = System.Drawing.Color.Transparent;
            this.btnAugmenter.FlatAppearance.BorderSize = 0;
            this.btnAugmenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAugmenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAugmenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAugmenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAugmenter.Location = new System.Drawing.Point(210, 82);
            this.btnAugmenter.Name = "btnAugmenter";
            this.btnAugmenter.Size = new System.Drawing.Size(24, 28);
            this.btnAugmenter.TabIndex = 0;
            this.btnAugmenter.UseVisualStyleBackColor = false;
            this.btnAugmenter.Click += new System.EventHandler(this.btnAugmenter_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(134, 85);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(60, 49);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "00";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuAffichage});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(333, 24);
            this.mnuPrincipal.TabIndex = 3;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuAffichage
            // 
            this.mnuAffichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAffichageTempMin,
            this.mnuAffichageTempMax,
            this.mnuAffichageTempCourante});
            this.mnuAffichage.Name = "mnuAffichage";
            this.mnuAffichage.Size = new System.Drawing.Size(70, 20);
            this.mnuAffichage.Text = "&Affichage";
            // 
            // mnuAffichageTempMin
            // 
            this.mnuAffichageTempMin.Name = "mnuAffichageTempMin";
            this.mnuAffichageTempMin.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuAffichageTempMin.Size = new System.Drawing.Size(214, 22);
            this.mnuAffichageTempMin.Text = "Température minimale";
            this.mnuAffichageTempMin.Click += new System.EventHandler(this.mnuAffichageTempMin_Click);
            // 
            // mnuAffichageTempMax
            // 
            this.mnuAffichageTempMax.Name = "mnuAffichageTempMax";
            this.mnuAffichageTempMax.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuAffichageTempMax.Size = new System.Drawing.Size(214, 22);
            this.mnuAffichageTempMax.Text = "Température maximale";
            this.mnuAffichageTempMax.Click += new System.EventHandler(this.mnuAffichageTempMax_Click);
            // 
            // mnuAffichageTempCourante
            // 
            this.mnuAffichageTempCourante.Name = "mnuAffichageTempCourante";
            this.mnuAffichageTempCourante.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuAffichageTempCourante.Size = new System.Drawing.Size(214, 22);
            this.mnuAffichageTempCourante.Text = "Température &courante";
            this.mnuAffichageTempCourante.Click += new System.EventHandler(this.mnuAffichageTempCourante_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::Thermostat.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(333, 236);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.btnAugmenter);
            this.Controls.Add(this.btnDiminuer);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thermostat - ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuAffichage;
        private System.Windows.Forms.ToolStripMenuItem mnuAffichageTempMin;
        private System.Windows.Forms.ToolStripMenuItem mnuAffichageTempMax;
        private System.Windows.Forms.ToolStripMenuItem mnuAffichageTempCourante;

    }
}

