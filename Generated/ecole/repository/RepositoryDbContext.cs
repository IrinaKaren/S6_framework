namespace ecole.repository;

using entity;
using Microsoft.EntityFrameworkCore;

public class RepositoryDbContext : DbContext {
	public DbSet<AnneeScolaire> AnneeScolaire { get; set; }
	public DbSet<Classe> Classe { get; set; }
	public DbSet<Etudiant> Etudiant { get; set; }
	public DbSet<EtudiantClasse> EtudiantClasse { get; set; }
	public DbSet<HistoriqueSalaireProfesseur> HistoriqueSalaireProfesseur { get; set; }
	public DbSet<Matiere> Matiere { get; set; }
	public DbSet<MatiereCoeff> MatiereCoeff { get; set; }
	public DbSet<Professeur> Professeur { get; set; }
	public DbSet<Salle> Salle { get; set; }
	public DbSet<SalleClasse> SalleClasse { get; set; }
	public DbSet<Trimestre> Trimestre { get; set; }




}
