namespace Mini_projet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleFenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauFenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remplacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionnerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseEnPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soulignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nouveauToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ouvrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.collerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnGras = new System.Windows.Forms.ToolStripButton();
            this.btnItalique = new System.Windows.Forms.ToolStripButton();
            this.btnSouligner = new System.Windows.Forms.ToolStripButton();
            this.zoomAvantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomArriereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurationZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeSIYAGRANotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(638, 383);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.miseEnPageToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.nouvelleFenetreToolStripMenuItem,
            this.nouveauFenetreToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir                       Ctrl+N";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer                      Ctrl+S";
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous             Ctrl+Shift+S";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // nouvelleFenetreToolStripMenuItem
            // 
            this.nouvelleFenetreToolStripMenuItem.Name = "nouvelleFenetreToolStripMenuItem";
            this.nouvelleFenetreToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.nouvelleFenetreToolStripMenuItem.Text = "Nouveau                         Ctrl+N";
            this.nouvelleFenetreToolStripMenuItem.Click += new System.EventHandler(this.nouvelleFenetreToolStripMenuItem_Click);
            // 
            // nouveauFenetreToolStripMenuItem
            // 
            this.nouveauFenetreToolStripMenuItem.Name = "nouveauFenetreToolStripMenuItem";
            this.nouveauFenetreToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.nouveauFenetreToolStripMenuItem.Text = "Nouvelle fenetre";
            this.nouveauFenetreToolStripMenuItem.Click += new System.EventHandler(this.nouveauFenetreToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.quitterToolStripMenuItem.Text = "Quitter.";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherToolStripMenuItem,
            this.remplacerToolStripMenuItem,
            this.annulerToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.selectionnerToutToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // remplacerToolStripMenuItem
            // 
            this.remplacerToolStripMenuItem.Name = "remplacerToolStripMenuItem";
            this.remplacerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.remplacerToolStripMenuItem.Text = "Remplacer";
            this.remplacerToolStripMenuItem.Click += new System.EventHandler(this.remplacerToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // selectionnerToutToolStripMenuItem
            // 
            this.selectionnerToutToolStripMenuItem.Name = "selectionnerToutToolStripMenuItem";
            this.selectionnerToutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectionnerToutToolStripMenuItem.Text = "Selectionner tout";
            this.selectionnerToutToolStripMenuItem.Click += new System.EventHandler(this.selectionnerToutToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // miseEnPageToolStripMenuItem
            // 
            this.miseEnPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grasToolStripMenuItem,
            this.italiqueToolStripMenuItem,
            this.soulignerToolStripMenuItem,
            this.toolStripMenuItem1});
            this.miseEnPageToolStripMenuItem.Name = "miseEnPageToolStripMenuItem";
            this.miseEnPageToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.miseEnPageToolStripMenuItem.Text = "Mise en page";
            // 
            // grasToolStripMenuItem
            // 
            this.grasToolStripMenuItem.Name = "grasToolStripMenuItem";
            this.grasToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.grasToolStripMenuItem.Text = "Gras";
            this.grasToolStripMenuItem.Click += new System.EventHandler(this.grasToolStripMenuItem_Click);
            // 
            // italiqueToolStripMenuItem
            // 
            this.italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            this.italiqueToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.italiqueToolStripMenuItem.Text = "Italique";
            this.italiqueToolStripMenuItem.Click += new System.EventHandler(this.italiqueToolStripMenuItem_Click);
            // 
            // soulignerToolStripMenuItem
            // 
            this.soulignerToolStripMenuItem.Name = "soulignerToolStripMenuItem";
            this.soulignerToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.soulignerToolStripMenuItem.Text = "Souligner";
            this.soulignerToolStripMenuItem.Click += new System.EventHandler(this.soulignerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(230, 22);
            this.toolStripMenuItem1.Text = "Retour automatique à la ligne";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem1});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zoomToolStripMenuItem.Text = "Affichage";
            // 
            // zoomToolStripMenuItem1
            // 
            this.zoomToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomAvantToolStripMenuItem,
            this.zoomArriereToolStripMenuItem,
            this.restaurationZoomToolStripMenuItem});
            this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem1.Text = "Zoom";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeSIYAGRANotesToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripButton,
            this.ouvrirToolStripButton,
            this.enregistrerToolStripButton,
            this.toolStripSeparator,
            this.couperToolStripButton,
            this.copierToolStripButton,
            this.collerToolStripButton,
            this.toolStripSeparator1,
            this.ToolStripButton,
            this.btnGras,
            this.btnItalique,
            this.btnSouligner});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nouveauToolStripButton
            // 
            this.nouveauToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nouveauToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripButton.Image")));
            this.nouveauToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveauToolStripButton.Name = "nouveauToolStripButton";
            this.nouveauToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nouveauToolStripButton.Text = "&Nouveau";
            this.nouveauToolStripButton.Click += new System.EventHandler(this.nouveauToolStripButton_Click);
            // 
            // ouvrirToolStripButton
            // 
            this.ouvrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ouvrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripButton.Image")));
            this.ouvrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripButton.Name = "ouvrirToolStripButton";
            this.ouvrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ouvrirToolStripButton.Text = "&Ouvrir";
            this.ouvrirToolStripButton.Click += new System.EventHandler(this.ouvrirToolStripButton_Click);
            // 
            // enregistrerToolStripButton
            // 
            this.enregistrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enregistrerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripButton.Image")));
            this.enregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripButton.Name = "enregistrerToolStripButton";
            this.enregistrerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.enregistrerToolStripButton.Text = "&Enregistrer";
            this.enregistrerToolStripButton.Click += new System.EventHandler(this.enregistrerToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // couperToolStripButton
            // 
            this.couperToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.couperToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripButton.Image")));
            this.couperToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couperToolStripButton.Name = "couperToolStripButton";
            this.couperToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.couperToolStripButton.Text = "C&ouper";
            this.couperToolStripButton.Click += new System.EventHandler(this.couperToolStripButton_Click);
            // 
            // copierToolStripButton
            // 
            this.copierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copierToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripButton.Image")));
            this.copierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copierToolStripButton.Name = "copierToolStripButton";
            this.copierToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copierToolStripButton.Text = "Co&pier";
            this.copierToolStripButton.Click += new System.EventHandler(this.copierToolStripButton_Click);
            // 
            // collerToolStripButton
            // 
            this.collerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.collerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripButton.Image")));
            this.collerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.collerToolStripButton.Name = "collerToolStripButton";
            this.collerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.collerToolStripButton.Text = "Co&ller";
            this.collerToolStripButton.Click += new System.EventHandler(this.collerToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
            this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton.Text = "&?";
            this.ToolStripButton.Click += new System.EventHandler(this.ToolStripButton_Click);
            // 
            // btnGras
            // 
            this.btnGras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGras.Name = "btnGras";
            this.btnGras.Size = new System.Drawing.Size(23, 22);
            this.btnGras.Text = "Gras";
            // 
            // btnItalique
            // 
            this.btnItalique.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalique.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalique.Name = "btnItalique";
            this.btnItalique.Size = new System.Drawing.Size(23, 22);
            this.btnItalique.Text = "Italique";
            // 
            // btnSouligner
            // 
            this.btnSouligner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSouligner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSouligner.Name = "btnSouligner";
            this.btnSouligner.Size = new System.Drawing.Size(23, 22);
            this.btnSouligner.Text = "Souligner";
            // 
            // zoomAvantToolStripMenuItem
            // 
            this.zoomAvantToolStripMenuItem.Name = "zoomAvantToolStripMenuItem";
            this.zoomAvantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomAvantToolStripMenuItem.Text = "Zoom avant";
            this.zoomAvantToolStripMenuItem.Click += new System.EventHandler(this.zoomAvantToolStripMenuItem_Click);
            // 
            // zoomArriereToolStripMenuItem
            // 
            this.zoomArriereToolStripMenuItem.Name = "zoomArriereToolStripMenuItem";
            this.zoomArriereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomArriereToolStripMenuItem.Text = "Zoom arriere";
            this.zoomArriereToolStripMenuItem.Click += new System.EventHandler(this.zoomArriereToolStripMenuItem_Click);
            // 
            // restaurationZoomToolStripMenuItem
            // 
            this.restaurationZoomToolStripMenuItem.Name = "restaurationZoomToolStripMenuItem";
            this.restaurationZoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurationZoomToolStripMenuItem.Text = "Restauration zoom";
            this.restaurationZoomToolStripMenuItem.Click += new System.EventHandler(this.restaurationZoomToolStripMenuItem_Click);
            // 
            // aProposDeSIYAGRANotesToolStripMenuItem
            // 
            this.aProposDeSIYAGRANotesToolStripMenuItem.Name = "aProposDeSIYAGRANotesToolStripMenuItem";
            this.aProposDeSIYAGRANotesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aProposDeSIYAGRANotesToolStripMenuItem.Text = "A propos de SIYAGRA Notes";
            this.aProposDeSIYAGRANotesToolStripMenuItem.Click += new System.EventHandler(this.aProposDeSIYAGRANotesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(638, 429);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SIYAGRA Notes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remplacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseEnPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton nouveauToolStripButton;
        private System.Windows.Forms.ToolStripButton ouvrirToolStripButton;
        private System.Windows.Forms.ToolStripButton enregistrerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton couperToolStripButton;
        private System.Windows.Forms.ToolStripButton copierToolStripButton;
        private System.Windows.Forms.ToolStripButton collerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton;
        private System.Windows.Forms.ToolStripButton btnGras;
        private System.Windows.Forms.ToolStripMenuItem soulignerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnItalique;
        private System.Windows.Forms.ToolStripButton btnSouligner;
        private System.Windows.Forms.ToolStripMenuItem nouvelleFenetreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauFenetreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionnerToutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomAvantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomArriereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurationZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeSIYAGRANotesToolStripMenuItem;
    }
}

