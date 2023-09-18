namespace TP2.Models
{
    /// <summary>
    /// Auteurs : Michael Meilleur et Mahdi Ellili
    /// Date : 2022-11-15
    /// Description : Classe pour les propriétés d'une image.
    /// </summary>
    public class Image
    {
        #region Champs
        public int Id { get; set; }
        public string? Nom { get; set; }
        public int Taille { get; set; }
        public string? Type { get; set; }
        public byte[]? Data { get; set; }
        #endregion
    }
}
