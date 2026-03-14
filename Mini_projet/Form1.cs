using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void grasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = richTextBox1.SelectionFont.Style ^ FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void italiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = richTextBox1.SelectionFont.Style ^ FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void soulignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = richTextBox1.SelectionFont.Style ^ FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texteRecherche = Prompt.ShowDialog("Entrer le texte à rechercher :", "Recherche");
            int index = richTextBox1.Find(texteRecherche);

            if (index >= 0)
            {
                richTextBox1.Select(index, texteRecherche.Length);
                MessageBox.Show("Texte trouvé.");
            }
            else
            {
                MessageBox.Show("Texte non trouvé.");
            }
        }

        private void remplacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texteRecherche = Prompt.ShowDialog("Entrer le texte à remplacer :", "Remplacer");
            string texteRemplacer = Prompt.ShowDialog("Entrer le nouveau texte :", "Remplacer par");

            int index = richTextBox1.Find(texteRecherche);
            if (index >= 0)
            {
                richTextBox1.Select(index, texteRecherche.Length);
                richTextBox1.SelectedText = texteRemplacer;
                MessageBox.Show("Remplacement effectué.");
            }
            else
            {
                MessageBox.Show("Texte non trouvé.");
            }
        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 150,
                    Text = caption
                };

                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
                Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.OK };

                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nouvelleFenetreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vérifie si le RichTextBox contient du texte non sauvegardé
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                // Affiche une boîte de dialogue pour demander si l'utilisateur souhaite sauvegarder
                var result = MessageBox.Show("Voulez-vous sauvegarder le fichier avant de créer un nouveau ?",
                                              "Confirmation",
                                              MessageBoxButtons.YesNoCancel,
                                              MessageBoxIcon.Warning);

                // Si l'utilisateur choisit "Oui", appelle la méthode SaveFile
                if (result == DialogResult.Yes)
                {
                    enregistrerSousToolStripMenuItem_Click(sender, e); // Appelle la méthode SaveFile pour sauvegarder
                }
                else if (result == DialogResult.Cancel)
                {
                    return; // Annule l'opération "Nouveau"
                }
            }

            // Efface le contenu du RichTextBox pour un nouveau document
            richTextBox1.Clear();

            // Optionnel : Réinitialise le titre de la fenêtre pour indiquer que c'est un nouveau document
            this.Text = "Éditeur de texte - Nouveau Document";
        }

        private void nouveauFenetreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crée et affiche une nouvelle fenêtre de l'éditeur de texte
            Form1 newEditor = new Form1(); // Remplace "TextEditorForm" par le nom de ta classe
            newEditor.Show(); // Ouvre la nouvelle fenêtre
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectionnerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText=" ";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Inverser l'état de retour automatique à la ligne
            richTextBox1.WordWrap = !richTextBox1.WordWrap;
            toolStripMenuItem1.Checked = richTextBox1.WordWrap; // Met à jour la case à cocher
        }

        private void zoomAvantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Augmente la taille de la police de 2 points
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size + 2);
        }

        private void zoomArriereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diminue la taille de la police de 2 points
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size - 2);
        }

        private void restaurationZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Réinitialise la taille de la police à une taille par défaut (par exemple, 12 points)
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12);
        }

        private void nouveauToolStripButton_Click(object sender, EventArgs e)
        {
            // Crée et affiche une nouvelle fenêtre de l'éditeur de texte
            Form1 newEditor = new Form1(); // Remplace "TextEditorForm" par le nom de ta classe
            newEditor.Show(); // Ouvre la nouvelle fenêtre
        }

        private void aProposDeSIYAGRANotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer une boîte de dialogue pour afficher les informations à propos
            MessageBox.Show("Éditeur de texte\nVersion 1.0\nDéveloppé par [SIDIBE Issa , GRAH Lowa , YABI Yannick]\n\n© 2024 Tous droits réservés.",
                            "À propos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void ouvrirToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void enregistrerToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void couperToolStripButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void copierToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void collerToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Éditeur de texte\nVersion 1.0\nDéveloppé par [SIDIBE Issa , GRAH Lowa , YABI Yannick]\n\n© 2024 Tous droits réservés.",
                           "À propos",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }
    }
}
