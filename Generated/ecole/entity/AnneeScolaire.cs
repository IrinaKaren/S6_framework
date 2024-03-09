namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("annee_scolaire")]
public class AnneeScolaire {
	[Column("annee_scolaire_debut")]
	int anneeScolaireDebut { get; set; }
	[Key]
	[Column("id_annee_scolaire")]
	int idAnneeScolaire { get; set; }
	[Column("annee_scolaire_fin")]
	int anneeScolaireFin { get; set; }


	public AnneeScolaire(){}

}
