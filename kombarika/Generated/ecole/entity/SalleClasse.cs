namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("salle_classe")]
public class SalleClasse {
	[ForeignKey("id_classe")]
	Classe classe { get; set; }
	[ForeignKey("id_salle")]
	Salle salle { get; set; }
	[Key]
	[Column("id_salle_classe")]
	int idSalleClasse { get; set; }


	public SalleClasse(){}

}
