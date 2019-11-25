namespace DevIO.Business.Models.Validations
{
    public static class ValidationsMessages
    {
        public static string MessageNotEmpty => "O campo {PropertyName} precisa ser fornecedido";
        public static string MessageMinAndMaxLength => "O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres";
        public static string MessageGreaterThan => "O campo {PropertyName} precisa ser maior que {ComparisonValue}";
    }
}
