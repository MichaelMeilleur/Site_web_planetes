using System.ComponentModel.DataAnnotations;

namespace TP2.Models
{
    /// <summary>
    /// Auteurs : Michael Meilleur et Mahdi Ellili
    /// Date : 2022-11-23
    /// Description : Classe pour le sondage
    /// </summary>
    public class SondageViewModel :  IValidatableObject
    {
       
        [Required(ErrorMessage ="Votre prénom est manquant!")]
        public string? Prénom { get; set; }
        [Required(ErrorMessage ="Votre nom est manquant!")]
        public string? Nom { get; set; }

        [RegularExpression(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$",ErrorMessage ="Format courriel incorrect!")]

        public string? Email { get; set; }
        [RegularExpression(@"^[A-Z][0-9]{3}-[A-Z]{4}-[0-9][A-Z]",ErrorMessage ="Code de promotion incorrect!")]
        public string? CodePromotion { get; set; }
        [Required(ErrorMessage ="Vous devez cocher votre niveau de connaissance!")]

        public string? Niveau { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="aaaa-mm-jj --:--")]
        public DateTime? DernièreVisite { get ; set; }
        public bool RecevoirNotification { get; set; }
        public string? planètechoisie { get; set; }
        public bool Validation { get; set; } = false;
        public string? MessageSuccès { get; set; } = "Formulaire envoyé!";
        public List<string> liste_planetes { get; set; } = new List<string> { "Mercure", "Venus", "Terre", "Mars", "Cérès", "Jupiter", "Saturne", "Uranus", "Neptune", "Pluton", "Makémaké", "Hauméa" };
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Email == null && RecevoirNotification)
                yield return new ValidationResult("Vous devez spécifier un courriel pour recevoir les nouvelles!");
            else
                yield return ValidationResult.Success!;
        }   

    } 
}
