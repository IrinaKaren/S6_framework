namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("salle")]
public class Salle {
	[Column("nom_salle")]
	string nomSalle { get; set; }
	[Key]
	[Column("id_salle")]
	int idSalle { get; set; }


	public Salle(){}

}
