using GameLibrary.Classes;
using System.Text.Json;

namespace GameLibrary
{
    public partial class Form1 : Form
    {
        public List<Game> games = new List<Game>();
        private readonly string saveFilePath = "bibliotheque.json";

        public Form1()
        {
            InitializeComponent();
            // Sélectionner les premiers éléments des ComboBox
            CmbPlateforme.SelectedIndex = 0;
            CmbGenre.SelectedIndex = 0;
            CmbTri.SelectedIndex = 0;
            
            // Charger automatiquement au démarrage
            ChargerDonnees();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            // Validation du titre
            if (string.IsNullOrWhiteSpace(TxtTitre.Text))
            {
                MessageBox.Show("Veuillez entrer un titre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation de l'année
            if (!int.TryParse(TxtAnnee.Text, out int annee) || annee < 1970 || annee > DateTime.Now.Year + 0)
            {
                MessageBox.Show("Veuillez entrer une année valide (1970 - " + (DateTime.Now.Year + 0) + ").", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Créer le nouveau jeu
            Game newGame = new Game
            {
                Title = TxtTitre.Text,
                Platform = CmbPlateforme.SelectedItem?.ToString() ?? "PC",
                Genre = CmbGenre.SelectedItem?.ToString() ?? "Action",
                ReleaseYear = annee,
                IsMultiplayer = ChkMultijoueur.Checked,
                IsPhysical = RdbPhysique.Checked
            };

            games.Add(newGame);
            MettreAJourListView();
            ViderChamps();
            SauvegarderDonnees(); // Sauvegarde automatique

            MessageBox.Show("Jeu ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            // Vérifier qu'un élément est sélectionné
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un jeu à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation du titre
            if (string.IsNullOrWhiteSpace(TxtTitre.Text))
            {
                MessageBox.Show("Veuillez entrer un titre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation de l'année
            if (!int.TryParse(TxtAnnee.Text, out int annee) || annee < 1970 || annee > DateTime.Now.Year + 0)
            {
                MessageBox.Show("Veuillez entrer une année valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trouver l'index du jeu sélectionné
            int index = listView1.SelectedIndices[0];

            // Modifier le jeu
            games[index].Title = TxtTitre.Text;
            games[index].Platform = CmbPlateforme.SelectedItem?.ToString() ?? "PC";
            games[index].Genre = CmbGenre.SelectedItem?.ToString() ?? "Action";
            games[index].ReleaseYear = annee;
            games[index].IsMultiplayer = ChkMultijoueur.Checked;
            games[index].IsPhysical = RdbPhysique.Checked;

            MettreAJourListView();
            ViderChamps();
            SauvegarderDonnees(); // Sauvegarde automatique

            MessageBox.Show("Jeu modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifier qu'un élément est sélectionné
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un jeu à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation de suppression
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer ce jeu ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int index = listView1.SelectedIndices[0];
                games.RemoveAt(index);
                MettreAJourListView();
                ViderChamps();
                SauvegarderDonnees(); // Sauvegarde automatique

                MessageBox.Show("Jeu supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quand on sélectionne un jeu, remplir les champs
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                Game selectedGame = games[index];

                TxtTitre.Text = selectedGame.Title;
                TxtAnnee.Text = selectedGame.ReleaseYear.ToString();
                CmbPlateforme.SelectedItem = selectedGame.Platform;
                CmbGenre.SelectedItem = selectedGame.Genre;
                ChkMultijoueur.Checked = selectedGame.IsMultiplayer;

                if (selectedGame.IsPhysical)
                    RdbPhysique.Checked = true;
                else
                    RdbNumerique.Checked = true;
            }
        }

        private void MettreAJourListView()
        {
            listView1.Items.Clear();
            
            // Trier selon le ComboBox
            var sortedGames = games.AsEnumerable();
            if (CmbTri?.SelectedIndex >= 0)
            {
                sortedGames = CmbTri.SelectedIndex switch
                {
                    0 => sortedGames.OrderBy(g => g.Title),
                    1 => sortedGames.OrderBy(g => g.ReleaseYear),
                    2 => sortedGames.OrderBy(g => g.Platform),
                    3 => sortedGames.OrderBy(g => g.Genre),
                    _ => sortedGames
                };
            }
            
            foreach (var game in sortedGames)
            {
                var item = new ListViewItem(game.Title);
                item.SubItems.Add(game.Platform);
                item.SubItems.Add(game.Genre);
                item.SubItems.Add(game.ReleaseYear.ToString());
                item.SubItems.Add(game.IsMultiplayer ? "Oui" : "Non");
                item.SubItems.Add(game.IsPhysical ? "Physique" : "Numérique");
                listView1.Items.Add(item);
            }

            // Mettre à jour le label du total
            LblTotal.Text = $"Total : {games.Count} jeu(x)";
        }
        
        // Événement changement de tri
        private void CmbTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourListView();
        }

        private void ViderChamps()
        {
            TxtTitre.Text = "";
            TxtAnnee.Text = DateTime.Now.Year.ToString();
            CmbPlateforme.SelectedIndex = 0;
            CmbGenre.SelectedIndex = 0;
            ChkMultijoueur.Checked = false;
            RdbNumerique.Checked = true;
            listView1.SelectedItems.Clear();
        }

        // Sauvegarde automatique en JSON
        private void SauvegarderDonnees()
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                string json = JsonSerializer.Serialize(games, options);
                File.WriteAllText(saveFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sauvegarde : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chargement automatique depuis JSON
        private void ChargerDonnees()
        {
            try
            {
                if (File.Exists(saveFilePath))
                {
                    string json = File.ReadAllText(saveFilePath);
                    games = JsonSerializer.Deserialize<List<Game>>(json) ?? new List<Game>();
                    MettreAJourListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                games = new List<Game>();
            }
        }

        // Bouton Sauvegarder (sauvegarde manuelle)
        private void BtnSauvegarder_Click(object sender, EventArgs e)
        {
            SauvegarderDonnees();
            MessageBox.Show("Bibliothèque sauvegardée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bouton Quitter
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            // Sauvegarder avant de quitter
            SauvegarderDonnees();
            Application.Exit();
        }
    }
}
