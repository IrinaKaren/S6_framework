namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.SalleContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[salle]]")]
public class SalleController : Controller {
	private readonly SalleDbContext _context;
	private readonly ILogger<SalleController> _logger;

	[HttpPost]
	public ActionResult<Salle> save([FromBody] Salle salle){
	 	_context.salle.Add(salle);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<Salle> update([FromBody] Salle salle){
	 	var temp = salle;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] Salle salle){
	 	_context.Salle.Remove(salle);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<Salle>> findAll(){
	 	return Ok(_context.Salle.ToList());
	}
	public SalleController(SalleDbContext context) { _context = context; }

}
