using FluentValidation;

namespace DevIO.Business.Models.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(cd => cd.Nome)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(2, 200).WithMessage(ValidationsMessages.MessageMinAndMaxLength);

            RuleFor(cd => cd.Descricao)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(2, 1000).WithMessage(ValidationsMessages.MessageMinAndMaxLength);

            RuleFor(cd => cd.Valor)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .GreaterThan(0).WithMessage(ValidationsMessages.MessageGreaterThan);
        }
    }
}