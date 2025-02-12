using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("E-Posta alanı boş geçilemez.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karaker veri girişi yapabilirsiniz.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına en fazla 100 karaker veri girişi yapabilirsiniz.");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("E-Posta alanına en az 5 karaker veri girişi yapabilirsiniz.");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("E-Posta alanına en fazla 100 karaker veri girişi yapabilirsiniz.");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Geçerli bir E-Posta'ya uygun bir formatı ile giriş yapınız.");
        }
    }
}
