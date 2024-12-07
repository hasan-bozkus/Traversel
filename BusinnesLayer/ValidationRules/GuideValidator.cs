using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("L�tfen Rehber Ad�n� Giriniz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("L�tfen 30 karakterden daha k�sa bir isim giriniz.");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("L�tfen 8 karakterden daha uzun bir isim giriniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("L�tfen Rehber A��klamas�n� Giriniz.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("L�tfen Rehber G�rselini Giriniz.");
        }
    }
}
