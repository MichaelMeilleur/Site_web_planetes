namespace TP2.Models
{
    /// <summary>
    /// Auteurs : Michael Meilleur et Mahdi Ellili
    /// Date : 2022-11-15
    /// Description : Classe pour les propriétés d'une planète.
    /// </summary>
    public class Planète
    {
        public int ID { get; set; }
        public string? Nom { get; set; }
        public int ImageID { get; set; }
        public int NbSatellites { get; set; }
        public int NoPlanète { get; set; }
        public string? Résumé { get; set; }
        public float Révolution { get; set; }
        public string? Description { get; set; }
        public Image Image { get; set; }

        #region Constructeurs
        public Planète()
        {

        }
        //Constructeur de copie
        public Planète(Planète planète)
        {
            foreach (var propriété in typeof(Planète).GetProperties())
            {
                propriété.SetValue(this, propriété.GetValue(planète));
            }
        }
        #endregion
    }

    public class PlanèteFR : Planète
    {
        #region Constructeurs
        public PlanèteFR()
        {

        }
        #endregion

      
    }
    public class PlanèteEN:Planète
    {
        public PlanèteEN()
        {

        }
    }
}
