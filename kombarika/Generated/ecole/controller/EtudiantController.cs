namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.EtudiantContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[etudiant]]")]
public class EtudiantController : Controller {
	private readonly EtudiantDbContext _context;
	private readonly ILogger<EtudiantController> _logger;

	[HttpPost]
	public ActionResult<Etudiant> save([FromBody] Etudiant etudiant){
	 	_context.etudiant.Add(etudiant);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<Etudiant> update([FromBody] Etudiant etudiant){
	 	var temp = etudiant;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] Etudiant etudiant){
	 	_context.Etudiant.Remove(etudiant);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<Etudiant>> findAll(){
	 	return Ok(_context.Etudiant.ToList());
	}
	public EtudiantController(EtudiantDbContext context) { _context = context; }

}
