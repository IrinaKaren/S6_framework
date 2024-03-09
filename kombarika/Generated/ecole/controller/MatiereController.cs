namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.MatiereContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[matiere]]")]
public class MatiereController : Controller {
	private readonly MatiereDbContext _context;
	private readonly ILogger<MatiereController> _logger;

	[HttpPost]
	public ActionResult<Matiere> save([FromBody] Matiere matiere){
	 	_context.matiere.Add(matiere);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<Matiere> update([FromBody] Matiere matiere){
	 	var temp = matiere;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] Matiere matiere){
	 	_context.Matiere.Remove(matiere);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<Matiere>> findAll(){
	 	return Ok(_context.Matiere.ToList());
	}
	public MatiereController(MatiereDbContext context) { _context = context; }

}
