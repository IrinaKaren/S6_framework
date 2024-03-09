namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.SalleClasseContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[salleClasse]]")]
public class SalleClasseController : Controller {
	private readonly SalleClasseDbContext _context;
	private readonly ILogger<SalleClasseController> _logger;

	[HttpPost]
	public ActionResult<SalleClasse> save([FromBody] SalleClasse salleClasse){
	 	_context.salleClasse.Add(salleClasse);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<SalleClasse> update([FromBody] SalleClasse salleClasse){
	 	var temp = salleClasse;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] SalleClasse salleClasse){
	 	_context.SalleClasse.Remove(salleClasse);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<SalleClasse>> findAll(){
	 	return Ok(_context.SalleClasse.ToList());
	}
	public SalleClasseController(SalleClasseDbContext context) { _context = context; }

}
