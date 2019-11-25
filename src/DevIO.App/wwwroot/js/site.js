function AjaxModal() {
    $(document).ready(function() {
        $(function() {
            $.ajaxSetup({ cache: false });

            $('a[data-modal]').on('click', function(e) {
                $('#myModalContent').load(this.href, function() {
                    $('#myModal').modal({ keyboard: true }, 'show');
                    bindForm(this);
                });

                return false;
            });
        });

        function bindForm(dialog) {
            $('form', dialog).submit(function() {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function(result) {
                        if (result.success) {
                            $('#myModal').modal('hide');
                            $('#EnderecoTarget').load(result.url);
                        } else {
                            $('#myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            });
        }
    });
}

function BuscaCep() {
    $(document).ready(function() {
        function limpaFormularioCep() {
            addValoresAosCampos();
        }

        function addValoresAosCampos(logradouro, bairro, cidade, estado) {
            $('[name="Endereco.Logradouro"]').val(logradouro === undefined || logradouro === null ? '' : logradouro);
            $('[name="Endereco.Bairro"]').val(bairro === undefined || bairro === null ? '' : bairro);
            $('[name="Endereco.Cidade"]').val(cidade === undefined || cidade === null ? '' : cidade);
            $('[name="Endereco.Estado"]').val(estado === undefined || estado === null ? '' : estado);
        }

        $(document).on('blur', '[name="Endereco.Cep"]', function() {
            var cep = $(this).val().replace(/\D/g, '');

            if (cep === '') {
                limpaFormularioCep();
                return;
            }

            var validaCep = /^[0-9]{8}$/;
            if (!validaCep.test(cep)) {
                limpaFormularioCep();
                alert('Formato de CEP inválido');
                return;
            }

            addValoresAosCampos('...', '...', '...', '...');

            $.getJSON('https:viacep.com.br/ws/' + cep + '/json/?callback=?', function(dados) {
                if (!('erro' in dados)) {
                    addValoresAosCampos(dados.logradouro, dados.bairro, dados.localidade, dados.uf);
                    return;
                } else {
                    limpaFormularioCep();
                    alert('cep NÃO Encontrado');
                    return;
                }
            });
        });
    });
}

$(document).ready(function() {
    $("#msg_box").fadeOut(2500);
});