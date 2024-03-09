namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("professeur")]
public class Professeur {
	[Column("nom_professeur")]
	string nomProfesseur { get; set; }
	[Key]
	[Column("id_professeur")]
	string idProfesseur { get; set; }
	[Column("salaire")]
	double salaire { get; set; }


	public Professeur(){}

}
