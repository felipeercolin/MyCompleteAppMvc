using DevIO.Business.Models.Validations.Documentos;
using FluentValidation;

namespace DevIO.Business.Models.Validations
{
    public class FornecedorValidation: AbstractValidator<Fornecedor>
    {
        private static string MessageInvalidCnpjCpf => "O documento fornecido é inválido";
        private static string MessageInvalidLengthCnpjCpf => "O campo Documento precisa ter {ComparisonValue} caracteres e for fornecido {PropertyValue}";

        public FornecedorValidation()
        {
            RuleFor(cd => cd.Nome)
                .NotEmpty().WithMessage(ValidationsMessages.MessageNotEmpty)
                .Length(2, 100).WithMessage(ValidationsMessages.MessageMinAndMaxLength);

            When(cd => cd.TipoFornecedor == TipoDocumento.PessoaFisica, () =>
            {
                RuleFor(cd =>cd.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage(MessageInvalidLengthCnpjCpf);

                RuleFor(cd => CpfValidacao.Validar(cd.Documento)).Equal(true)
                    .WithMessage(MessageInvalidCnpjCpf);
            });

            When(cd => cd.TipoFornecedor == TipoDocumento.PessoaJuridica, () =>
            {
                RuleFor(cd => cd.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage(MessageInvalidLengthCnpjCpf);

                RuleFor(cd => CnpjValidacao.Validar(cd.Documento)).Equal(true)
                    .WithMessage(MessageInvalidCnpjCpf);
            });

        }
    }
}