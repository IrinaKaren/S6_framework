namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("classe")]
public class Classe {
	[Key]
	[Column("id_classe")]
	int idClasse { get; set; }
	[Column("nom_classe")]
	string nomClasse { get; set; }


	public Classe(){}

}
