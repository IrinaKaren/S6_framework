namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.ProfesseurContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[professeur]]")]
public class ProfesseurController : Controller {
	private readonly ProfesseurDbContext _context;
	private readonly ILogger<ProfesseurController> _logger;

	[HttpPost]
	public ActionResult<Professeur> save([FromBody] Professeur professeur){
	 	_context.professeur.Add(professeur);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<Professeur> update([FromBody] Professeur professeur){
	 	var temp = professeur;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] Professeur professeur){
	 	_context.Professeur.Remove(professeur);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<Professeur>> findAll(){
	 	return Ok(_context.Professeur.ToList());
	}
	public ProfesseurController(ProfesseurDbContext context) { _context = context; }

}
