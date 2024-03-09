namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("matiere")]
public class Matiere {
	[Key]
	[Column("id_matiere")]
	int idMatiere { get; set; }
	[Column("code_matiere")]
	string codeMatiere { get; set; }
	[Column("nom_matiere")]
	string nomMatiere { get; set; }


	public Matiere(){}

}
