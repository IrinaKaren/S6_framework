namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("etudiant")]
public class Etudiant {
	[Column("nom_etudiant")]
	string nomEtudiant { get; set; }
	[Key]
	[Column("id_etudiant")]
	string idEtudiant { get; set; }


	public Etudiant(){}

}
