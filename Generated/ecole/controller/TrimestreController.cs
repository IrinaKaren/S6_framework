namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.TrimestreContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[trimestre]]")]
public class TrimestreController : Controller {
	private readonly TrimestreDbContext _context;
	private readonly ILogger<TrimestreController> _logger;

	[HttpPost]
	public ActionResult<Trimestre> save([FromBody] Trimestre trimestre){
	 	_context.trimestre.Add(trimestre);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<Trimestre> update([FromBody] Trimestre trimestre){
	 	var temp = trimestre;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] Trimestre trimestre){
	 	_context.Trimestre.Remove(trimestre);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<Trimestre>> findAll(){
	 	return Ok(_context.Trimestre.ToList());
	}
	public TrimestreController(TrimestreDbContext context) { _context = context; }

}
