using System;
using Microsoft.EntityFrameworkCore;
using Practice_Crud___Agenda_Contactos.Models;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{


	}

	//Agregar futuros modelos aca

	public DbSet <Contact> Contact {  get; set; }
}
