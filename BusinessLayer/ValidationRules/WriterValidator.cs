using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x=>x.WriterName).NotEmpty().WithMessage("İsim ve soyisim kısmı boş olamaz");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş olamaz");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş olamaz");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter girin");
		}
	}
}
