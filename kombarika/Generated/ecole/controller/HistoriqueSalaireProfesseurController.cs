namespace ecole.controller;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecole.repository.HistoriqueSalaireProfesseurContext;
using ecole.entity;
using ;

[ApiController]
[Route("api/[[historiqueSalaireProfesseur]]")]
public class HistoriqueSalaireProfesseurController : Controller {
	private readonly HistoriqueSalaireProfesseurDbContext _context;
	private readonly ILogger<HistoriqueSalaireProfesseurController> _logger;

	[HttpPost]
	public ActionResult<HistoriqueSalaireProfesseur> save([FromBody] HistoriqueSalaireProfesseur historiqueSalaireProfesseur){
	 	_context.historiqueSalaireProfesseur.Add(historiqueSalaireProfesseur);
		_context.SaveChanges();
		return Ok();
	}
	[HttpPut]
	public ActionResult<HistoriqueSalaireProfesseur> update([FromBody] HistoriqueSalaireProfesseur historiqueSalaireProfesseur){
	 	var temp = historiqueSalaireProfesseur;
		_context.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	public void delete([FromBody] HistoriqueSalaireProfesseur historiqueSalaireProfesseur){
	 	_context.HistoriqueSalaireProfesseur.Remove(historiqueSalaireProfesseur);
		_context.SaveChanges();	return Ok();
	}
	[HttpGet]
	public ActionResult<IEnumerable<HistoriqueSalaireProfesseur>> findAll(){
	 	return Ok(_context.HistoriqueSalaireProfesseur.ToList());
	}
	public HistoriqueSalaireProfesseurController(HistoriqueSalaireProfesseurDbContext context) { _context = context; }

}
