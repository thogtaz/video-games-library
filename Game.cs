namespace GameLibrary.Classes
{
    public class Game
    {
        public string Title { get; set; } = string.Empty;
        
        public string Platform { get; set; } = string.Empty;
        
        public string Genre { get; set; } = string.Empty;
        
        public int ReleaseYear { get; set; }
        
        public bool IsMultiplayer { get; set; }
        
        public bool IsPhysical { get; set; } // true = physique, false = numérique
    }
}
