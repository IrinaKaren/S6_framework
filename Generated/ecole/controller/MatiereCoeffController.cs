namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.MatiereCoeffContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[matiereCoeff]]")]
public class MatiereCoeffController : Controller {
	private readonly MatiereCoeffDbContext _context;
	private readonly ILogger<MatiereCoeffController> _logger;

	[HttpPost]
	public ActionResult<MatiereCoeff> save([FromBody] MatiereCoeff matiereCoeff){
	 	_context.matiereCoeff.Add(matiereCoeff);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<MatiereCoeff> update([FromBody] MatiereCoeff matiereCoeff){
	 	var temp = matiereCoeff;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] MatiereCoeff matiereCoeff){
	 	_context.MatiereCoeff.Remove(matiereCoeff);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<MatiereCoeff>> findAll(){
	 	return Ok(_context.MatiereCoeff.ToList());
	}
	public MatiereCoeffController(MatiereCoeffDbContext context) { _context = context; }

}
