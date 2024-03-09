namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("historique_salaire_professeur")]
public class HistoriqueSalaireProfesseur {
	[Column("date_aug")]
	DateOnly dateAug { get; set; }
	[ForeignKey("id_professeur")]
	Professeur professeur { get; set; }
	[Column("salaire")]
	double salaire { get; set; }
	[Key]
	[Column("id_historique_salaire_professeur")]
	int idHistoriqueSalaireProfesseur { get; set; }


	public HistoriqueSalaireProfesseur(){}

}
