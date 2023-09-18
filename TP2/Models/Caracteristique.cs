namespace TP2.Models
{
    /// <summary>
    /// Auteurs : Michael Meilleur et Mahdi Ellili
    /// Date : 2022-11-15
    /// Description : Classe pour les caractéristiques
    /// </summary>
    public class Caracteristique
    {
        public int ID { get; set; }
        public string? Nom { get; set; }
        public string? Catégorie { get; set; }
        public decimal Valeur { get; set; }
        public string? MesureHtml { get; set; }
        public int PlanèteID { get; set; }

        #region Constructeurs
        public Caracteristique()
        {

        }
        //Const de copie
        public Caracteristique( Caracteristique caracteritique) : base()
        {

        }
        #endregion
    }

    public class CaracteristiqueFR : Caracteristique
    {
        #region Constructeurs
        public CaracteristiqueFR()
        {

        }
        public CaracteristiqueFR(CaracteristiqueFR caract) : base(caract)
        {

        }
        #endregion


    }
    public class CaracteristiqueEN : Caracteristique
    {
        public CaracteristiqueEN()
        {

        }
        public CaracteristiqueEN(Caracteristique cara) : base(cara) 
        {

        }
    }
}
