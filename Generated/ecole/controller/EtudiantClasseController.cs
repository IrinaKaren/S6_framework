namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.EtudiantClasseContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[etudiantClasse]]")]
public class EtudiantClasseController : Controller {
	private readonly EtudiantClasseDbContext _context;
	private readonly ILogger<EtudiantClasseController> _logger;

	[HttpPost]
	public ActionResult<EtudiantClasse> save([FromBody] EtudiantClasse etudiantClasse){
	 	_context.etudiantClasse.Add(etudiantClasse);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<EtudiantClasse> update([FromBody] EtudiantClasse etudiantClasse){
	 	var temp = etudiantClasse;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] EtudiantClasse etudiantClasse){
	 	_context.EtudiantClasse.Remove(etudiantClasse);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<EtudiantClasse>> findAll(){
	 	return Ok(_context.EtudiantClasse.ToList());
	}
	public EtudiantClasseController(EtudiantClasseDbContext context) { _context = context; }

}
