using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator:AbstractValidator<About>
	{
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Bu hisseni bosh saxliya bilmezsiniz");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Zehmet olmazsa sekil daxil edin");
            RuleFor(x => x.Description).NotEmpty().MinimumLength(50).WithMessage("Uzunglugu min 50 olsun");
            RuleFor(x => x.Description).NotEmpty().MaximumLength(5120).WithMessage("Uzunglugu max 5120 olsun");
		}
	}
}
