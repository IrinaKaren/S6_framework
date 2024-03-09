namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("etudiant_classe")]
public class EtudiantClasse {
	[Key]
	[Column("id_etudiant_classe")]
	int idEtudiantClasse { get; set; }
	[ForeignKey("id_etudiant")]
	Etudiant etudiant { get; set; }
	[ForeignKey("id_classe")]
	Classe classe { get; set; }
	[ForeignKey("id_annee_scolaire")]
	AnneeScolaire anneeScolaire { get; set; }


	public EtudiantClasse(){}

}
