﻿using System.ComponentModel.DataAnnotations;

namespace RestorantDeneme.Models
{
	public class Iletisimim
	{
		[Key]
		public int Id { get; set; }
		public string Email { get; set; }
		public string Telefon { get; set; }
		public string Adres { get; set; }
	}
}
