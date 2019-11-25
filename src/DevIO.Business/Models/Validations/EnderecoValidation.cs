using FluentValidation;

namespace DevIO.Business.Models.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(cd => cd.Logradouro)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(2, 200).WithMessage(ValidationsMessages.MessageMinAndMaxLength);

            RuleFor(cd => cd.Bairro)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(2, 100).WithMessage(ValidationsMessages.MessageMinAndMaxLength);

            RuleFor(cd => cd.Cep)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(8).WithMessage(ValidationsMessages.MessageMinAndMaxLength);

            RuleFor(cd => cd.Cidade)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(2, 100).WithMessage(ValidationsMessages.MessageMinAndMaxLength);

            RuleFor(cd => cd.Estado)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(2, 50).WithMessage(ValidationsMessages.MessageMinAndMaxLength);

            RuleFor(cd => cd.Numero)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(1, 50).WithMessage(ValidationsMessages.MessageMinAndMaxLength);
        }
    }
}
