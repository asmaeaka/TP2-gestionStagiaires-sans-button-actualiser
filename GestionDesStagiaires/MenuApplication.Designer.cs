namespace GestionDesStagiaires
{
    partial class MenuApplication
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gestionDesStagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesIndividuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesStagiairesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesStagiairesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 26);
            // 
            // gestionDesStagiairesToolStripMenuItem
            // 
            this.gestionDesStagiairesToolStripMenuItem.Name = "gestionDesStagiairesToolStripMenuItem";
            this.gestionDesStagiairesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gestionDesStagiairesToolStripMenuItem.Text = "Gestion des Stagiaires";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesIndividuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesIndividuToolStripMenuItem
            // 
            this.gestionDesIndividuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesStagiairesToolStripMenuItem1});
            this.gestionDesIndividuToolStripMenuItem.Name = "gestionDesIndividuToolStripMenuItem";
            this.gestionDesIndividuToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gestionDesIndividuToolStripMenuItem.Text = "Gestion des Individu";
            // 
            // gestionDesStagiairesToolStripMenuItem1
            // 
            this.gestionDesStagiairesToolStripMenuItem1.Name = "gestionDesStagiairesToolStripMenuItem1";
            this.gestionDesStagiairesToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.gestionDesStagiairesToolStripMenuItem1.Text = "Gestion des Stagiaires";
            this.gestionDesStagiairesToolStripMenuItem1.Click += new System.EventHandler(this.gestionDesStagiairesToolStripMenuItem1_Click);
            // 
            // MenuApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuApplication";
            this.Text = "Menu Application";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesStagiairesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesIndividuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesStagiairesToolStripMenuItem1;
    }
}

