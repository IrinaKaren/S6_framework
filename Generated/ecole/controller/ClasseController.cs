namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.ClasseContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[classe]]")]
public class ClasseController : Controller {
	private readonly ClasseDbContext _context;
	private readonly ILogger<ClasseController> _logger;

	[HttpPost]
	public ActionResult<Classe> save([FromBody] Classe classe){
	 	_context.classe.Add(classe);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<Classe> update([FromBody] Classe classe){
	 	var temp = classe;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] Classe classe){
	 	_context.Classe.Remove(classe);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<Classe>> findAll(){
	 	return Ok(_context.Classe.ToList());
	}
	public ClasseController(ClasseDbContext context) { _context = context; }

}
