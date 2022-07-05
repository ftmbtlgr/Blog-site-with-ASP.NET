using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator :AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Adını boş geçemezsiniz.");
            RuleFor(x => x.AuthorSurName).NotEmpty().WithMessage("Soyadı boş geçemezsiniz.");     
            RuleFor(x => x.AuthorUserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz.");
            RuleFor(x => x.AuthorUserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik kullanıcı adı girişi yapınız.");
            RuleFor(x => x.AuthorUserName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik kullanıcı adı girişi yapınız.");
        }
    }
}
