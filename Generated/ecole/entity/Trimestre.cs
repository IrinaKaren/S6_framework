namespace ecole.entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("trimestre")]
public class Trimestre {
	[Column("numero_trimestre")]
	int numeroTrimestre { get; set; }
	[Key]
	[Column("id_trimestre")]
	int idTrimestre { get; set; }


	public Trimestre(){}

}
