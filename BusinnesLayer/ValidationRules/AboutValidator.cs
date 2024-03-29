﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("İzahat kısmı boş geçilemez.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakter giriniz.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen en fazla 1500 karakter giriniz.");
        }
    }
}
