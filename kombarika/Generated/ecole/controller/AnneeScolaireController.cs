namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.AnneeScolaireContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[anneeScolaire]]")]
public class AnneeScolaireController : Controller {
	private readonly AnneeScolaireDbContext _context;
	private readonly ILogger<AnneeScolaireController> _logger;

	[HttpPost]
	public ActionResult<AnneeScolaire> save([FromBody] AnneeScolaire anneeScolaire){
	 	_context.anneeScolaire.Add(anneeScolaire);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<AnneeScolaire> update([FromBody] AnneeScolaire anneeScolaire){
	 	var temp = anneeScolaire;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] AnneeScolaire anneeScolaire){
	 	_context.AnneeScolaire.Remove(anneeScolaire);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<AnneeScolaire>> findAll(){
	 	return Ok(_context.AnneeScolaire.ToList());
	}
	public AnneeScolaireController(AnneeScolaireDbContext context) { _context = context; }

}
