namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("matiere_coeff")]
public class MatiereCoeff {
	[ForeignKey("id_matiere")]
	Matiere matiere { get; set; }
	[ForeignKey("id_classe")]
	Classe classe { get; set; }
	[Column("coefficient")]
	int coefficient { get; set; }
	[Key]
	[Column("id_matiere_coeff")]
	int idMatiereCoeff { get; set; }


	public MatiereCoeff(){}

}
