using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain
{
    public class Conjuge
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public string cpf { get; set; }
        public string dataNascimento { get; set; }
        public string profissao { get; set; }
        public string codigoProfissao { get; set; }
    }
    public class Filhos
    {
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public string sexo { get; set; }
    }
    public class DadosCadastrais
    {
        private Erro erro;
        private string _nomeSegurado;
        public string nomeSegurado
        {
            get => _nomeSegurado;
            set
            {
                erro.valida(value, "nomeSegurado");
                this._nomeSegurado = value;
            }
        }

        private string _sexo;
        public string sexo
        {
            get => _sexo;
            set
            {
                erro.valida(value, "sexo");
                this._sexo = value;
            }
        }

        private string _cpf;
        public string cpf
        {
            get => _cpf;
            set
            {
                erro.valida(value, "cpf");
                this._cpf = value;
            }
        }

        private string _rg;
        public string rg
        {
            get => _rg;
            set
            {
                this._rg = value;
            }
        }

        private string _orgaoExpedidor;
        public string orgaoExpedidor
        {
            get => _orgaoExpedidor;
            set
            {
                this._orgaoExpedidor = value;
            }
        }

        private string _dataExpedicao;
        public string dataExpedicao
        {
            get => _dataExpedicao;
            set
            {
                this._dataExpedicao = value;
            }
        }

        private string _dataNascimento { get; set; }
        public string dataNascimento
        {
            get => _dataNascimento;
            set
            {
                erro.valida(value, "dataNascimento");
                this._dataNascimento = value;
            }
        }

        private string _estadoCivil;
        public string estadoCivil
        {
            get => _estadoCivil;
            set
            {
                erro.valida(value, "estadoCivil");
                this._estadoCivil = value;
            }
        }

        private string _rendaFamiliar;
        public string rendaFamiliar
        {
            get => _rendaFamiliar;
            set
            {
                this._rendaFamiliar = value;
            }
        }

        private string _cep;
        public string cep
        {
            get => _cep;
            set
            {
                erro.valida(value, "cep ");
                this._cep = value;
            }
        }

        private string _endereco;
        public string endereco
        {
            get => _endereco;
            set
            {
                erro.valida(value, "endereco");
                this._endereco = value;
            }
        }

        private int _numero;
        public int numero
        {
            get => _numero;
            set
            {
                this._numero = value;
            }
        }

        private string _complemento;
        public string complemento
        {
            get => _complemento;
            set
            {
                this._complemento = value;
            }
        }

        private string _bairro;
        public string bairro
        {
            get => _bairro;
            set
            {
                this._bairro = value;
            }
        }

        private string _cidade;
        public string cidade
        {
            get => _cidade;
            set
            {
                erro.valida(value, "cidade");
                this._cidade = value;
            }
        }

        private string _uf;
        public string uf
        {
            get => _uf;
            set
            {
                erro.valida(value, "uf");
                this._uf = value;
            }
        }

        private string _referencia;
        public string referencia
        {
            get => _referencia;
            set
            {
                this._referencia = value;
            }
        }

        private string _celular;
        public string celular
        {
            get => _celular;
            set
            {
                erro.valida(value, "celular");
                this._celular = value;
            }
        }

        private string _whatsApp;
        public string whatsApp
        {
            get => _whatsApp;
            set
            {
                erro.validaTelefone(value);
                this._whatsApp = value;
            }
        }

        private string _residencial;
        public string residencial
        {
            get => _residencial;
            set
            {
                erro.validaTelefone(value);
                this._residencial = value;
            }
        }

        private string _comercial;
        public string comercial
        {
            get => _comercial;
            set
            {
                erro.validaTelefone(value);
                this._comercial = value;
            }
        }

        private string _profissao;
        public string profissao
        {
            get => _profissao;
            set
            {
                erro.valida(value, "profissao");
                this._profissao = value;
            }
        }

        private string _codigoProfissao;
        public string codigoProfissao
        {
            get => _codigoProfissao;
            set
            {
                erro.valida(value, "codigoProfissao");
                this._codigoProfissao = value;
            }
        }

        private string _email;
        public string email
        {
            get => _email;
            set
            {
                this._email = value;
            }
        }

        //public Conjuge conjuge { get; set; } = new Conjuge();
        public List<Filhos> filhos { get; set; } = new List<Filhos>();
     


        private string _assistenciaFuneral;
        public string assistenciaFuneral
        {
            get => _assistenciaFuneral;
            set
            {
                erro.valida(value, "assistenciaFuneral");
                this._assistenciaFuneral = value;
            }
        }

        private string _plano;
        public string plano
        {
            get => _plano;
            set
            {
                this._plano = value;
            }
        }

        public DadosCadastrais(Erro erro)
        {
            this.erro = erro;
        }
    }
    public class Agregados
    {
        private Erro erro;

        public Agregados(Erro erro)
        {
            this.erro = erro;
        }

        public string nomeSegurado { get; set; }
        public string dataNascimento { get; set; }
        public string sexo { get; set; }
        public string parentesco { get; set; }
        public string plano { get; set; }

        private decimal _valorPremio;
        public decimal valorPremio
        {
            get => _valorPremio;
            set
            {
                erro.valida(value, "valorPremio");
                _valorPremio = value;
            }
        }

        private string _cpf;
        public string cpf
        {
            get => _cpf;
            set
            {
                erro.valida(value, "cpf");
                _cpf = value;
            }
        }

        private string _valorPremioFuneralMaster;
        public string valorPremioFuneralMaster
        {
            get => _valorPremioFuneralMaster;
            set
            {
                erro.valida(value, "valorPremioFuneralMaster");
                _valorPremioFuneralMaster = value;
            }
        }

    }
    public class RendaMensal
    {
        private Erro erro;

        public RendaMensal(Erro erro)
        {
            this.erro = erro;
        }

        private int _prazo;
        public int prazo
        {
            get => _prazo;
            set
            {
                erro.valida(value, "prazo");
                _prazo = value;
            }
        }

        private string _valorParcela;
        public string valorParcela
        {
            get => _valorParcela;
            set
            {
                erro.valida(value, "valorParcela");
                _valorParcela = value;
            }
        }

        private string _capitalSegurado;
        public string capitalSegurado
        {
            get => _capitalSegurado;
            set
            {
                erro.valida(value, "capitalSegurado");
                _capitalSegurado = value;
            }
        }

        private string _valorPremioRendaMensal;
        public string valorPremioRendaMensal
        {
            get => _valorPremioRendaMensal;
            set
            {
                erro.valida(value, "valorPremioRendaMensal");
                _valorPremioRendaMensal = value;
            }
        }
    }
    public class RendaMensalConjuge
    {
        private Erro erro;

        public RendaMensalConjuge(Erro erro)
        {
            this.erro = erro;
        }

        private int _prazo;
        public int prazo
        {
            get => _prazo;
            set
            {
                erro.valida(value, "prazo");
                _prazo = value;
            }
        }

        private string _valorParcela;
        public string valorParcela
        {
            get => _valorParcela;
            set
            {
                erro.valida(value, "valorParcela");
                _valorParcela = value;
            }
        }

        private string _capitalSegurado;
        public string capitalSegurado
        {
            get => _capitalSegurado;
            set
            {
                erro.valida(value, "capitalSegurado");
                _capitalSegurado = value;
            }
        }

        private string _valorPremioRendaMensal;
        public string valorPremioRendaMensal
        {
            get => _valorPremioRendaMensal;
            set
            {
                erro.valida(value, "valorPremioRendaMensal");
                _valorPremioRendaMensal = value;
            }
        }
    }
    public class CalculoPremioTotal
    {
        private Erro erro;

        private string _vencimento;
        public string vencimento
        {
            get => _vencimento;
            set
            {
                erro.valida(value, "vencimento");
                _vencimento = value;
            }
        }

        private string _valorPremioAcidentesPessoais;
        public string valorPremioAcidentesPessoais
        {
            get => _valorPremioAcidentesPessoais;
            set
            {
                erro.valida(value, "valorPremioAcidentesPessoais");
                _valorPremioAcidentesPessoais = value;
            }
        }
        private string _valorPremioAgregados;
        public string valorPremioAgregados
        {
            get => _valorPremioAgregados;
            set
            {
                erro.valida(value, "valorPremioAgregados");
                _valorPremioAgregados = value;
            }
        }
        private string _valorPremioRendaMensal;
        public string valorPremioRendaMensal
        {
            get => _valorPremioRendaMensal;
            set
            {
                erro.valida(value, "valorPremioRendaMensal");
                _valorPremioRendaMensal = value;
            }
        }
        private string _valorPremioTotal;
        public string valorPremioTotal
        {
            get => _valorPremioTotal;
            set
            {
                erro.valida(value, "valorPremioTotal");
                _valorPremioTotal = value;
            }
        }

        private string _valorPremioFuneralMaster;
        public string valorPremioFuneralMaster
        {
            get => _valorPremioFuneralMaster;
            set
            {
                erro.valida(value, "valorPremioFuneralMaster");
                _valorPremioFuneralMaster = value;
            }
        }

        private string _valorPremioAssistenciaFuneral;
        public string valorPremioAssistenciaFuneral
        {
            get => _valorPremioAssistenciaFuneral;
            set
            {
                erro.valida(value, "valorPremioAssistenciaFuneral");
                _valorPremioAssistenciaFuneral = value;
            }
        }
        public CalculoPremioTotal(Erro erro)
        {
            this.erro = erro;
        }
    }
    public class DadosCorretor
    {
        private Erro erro;
        private string _angariador;
        public string angariador
        {
            get => _angariador;
            set
            {
                erro.valida(value, "angariador");
                _angariador = value;
            }
        }
        private int _codigoAngariador;
        public int codigoAngariador
        {
            get => _codigoAngariador;
            set
            {
                erro.valida(value, "codigoAngariador");
                _codigoAngariador = value;
            }
        }
        private string _unidade;
        public string unidade
        {
            get => _unidade;
            set
            {
                erro.valida(value, "unidade");
                _unidade = value;
            }
        }
        public string coordenador { get; set; } = "";
        public string corretor { get; set; }
        public int registroSUSEP { get; set; }

        public DadosCorretor(Erro erro)
        {
            this.erro = erro;
        }
    }
    public class PerguntasResposta
    {
        private Erro erro;
        public string tipoSegurado { get; set; }
        public List<PerguntaRespostaDPS> perguntaRespostaDPS { get; set; }

        public PerguntasResposta(Erro erro)
        {
            this.erro = erro;
        }
    }
    public class PerguntaRespostaDPS
    {
        private Erro erro;
        public int codigoPergunta { get; set; }
        public string resposta
        {
            get;
            set;
        }
        public string justificativa { get; set; }

        public PerguntaRespostaDPS(Erro erro)
        {
            this.erro = erro;
        }
    }
    public class DeclaracaoPessoalSaude
    {
        private Erro erro;
        public List<PerguntasResposta> perguntasRespostas { get; set; }
        private string _filhoBeneficiario;
        public string filhoBeneficiario
        {
            get => _filhoBeneficiario;
            set
            {
                erro.valida(value, "filhoBeneficiario");
                _filhoBeneficiario = value;
            }
        }
        private string _dependenteAgregado;
        public string dependenteAgregado
        {
            get => _dependenteAgregado;
            set
            {
                erro.valida(value, "dependenteAgregado");
                _dependenteAgregado = value;
            }
        }
        private string _conjugeProponente;
        public string conjugeProponente
        {
            get => _conjugeProponente;
            set
            {
                erro.valida(value, "conjugeProponente");
                _conjugeProponente = value;
            }
        }

        public DeclaracaoPessoalSaude(Erro erro)
        {
            this.erro = erro;
        }
    }
    public class DadosDebito
    {
        private Erro erro;
        public string titular { get; set; }
        public string cpfTitular { get; set; }
        public int? codigoBanco { get; set; }
        public string numeroAgencia { get; set; }
        public string numeroConta { get; set; }
        public string tipoConta { get; set; }

        public DadosDebito(Erro erro)
        {
            this.erro = erro;
        }
    }
    public class FormaPagamento
    {
        private Erro erro;
        private string _primeiraParcela;
        public string primeiraParcela
        {
            get => _primeiraParcela;
            set
            {
                erro.valida(value, "primeiraParcela");
                _primeiraParcela = value;
            }
        }
        private string _demaisParcelas;
        public string demaisParcelas
        {
            get => _demaisParcelas;
            set
            {
                erro.valida(value, "demaisParcelas");
                _demaisParcelas = value;
            }
        }
        public DadosDebito dadosDebito { get; set; } = new DadosDebito(new Erro());

        public FormaPagamento(Erro erro)
        {
            this.erro = erro;
        }
    }
    public class Proposta
    {

        public Proposta(Erro erro)
        {
            this.erro = erro;
        }

        private Erro erro;
        private string _externalKey;
        public string externalKey
        {
            get => _externalKey;
            set
            {
                erro.valida(value, "externalKey");
                this._externalKey = value;
            }
        }
        private string _nomeProduto;

        public string nomeProduto
        {
            get => _nomeProduto;
            set
            {
                erro.valida(value, "nomeProduto");
                _nomeProduto = value;
            }
        }
        private int _numeroContrato;
        public int numeroContrato
        {
            get => _numeroContrato;
            set
            {
                erro.valida(value, "numeroContrato");
                _numeroContrato = value;
            }
        }
        private string _numeroApolice;
        public string numeroApolice
        {
            get => _numeroApolice;
            set
            {
                erro.valida(value, "numeroApolice");
                _numeroApolice = value;
            }
        }
        private string _processoSusep;

        public string processoSusep
        {
            get => _processoSusep;
            set
            {
                erro.valida(value, "processoSusep");
                _processoSusep = value;
            }
        }

        public string statusProposta
        {
            get;
            set;
        }

        private string _nome;
        public string nome
        {
            get => _nome;
            set
            {
                erro.valida(value, "nome");
                this._nome = value;
            }
        }

        private string _cpf;
        public string cpf
        {
            get => _cpf;
            set
            {
                erro.valida(value, "cpf");
                _cpf = value;
            }
        }

        private string _vencimento;
        public string vencimento
        {
            get => _vencimento;
            set
            {
                erro.valida(value, "vencimento");
                _vencimento = value;
            }
        }

        private int _proposta;
        public int proposta
        {
            get => _proposta;
            set
            {
                erro.valida(value, "proposta");
                _proposta = value;
            }
        }

        private string _tipoComunicacao;
        public string tipoComunicacao
        {
            get => _tipoComunicacao;
            set
            {
                erro.valida(value, "tipoComunicacao");
                _tipoComunicacao = value;
            }
        }
        public DadosCadastrais dadosCadastrais { get; set; }
        public CoberturaTitular coberturaTitular { get; set; }
        public RendaMensal rendaMensal { get; set; }
        public Conjuge conjuge { get; set; } = new Conjuge();
        public CoberturaConjuge coberturaConjuge { get; set; } = new CoberturaConjuge();
        public RendaMensalConjuge rendaMensalConjuge { get; set; } = new RendaMensalConjuge(new Erro());
        public List<Agregados> agregados { get; set; }
        public CalculoPremioTotal calculoPremioTotal { get; set; }
        public DadosCorretor dadosCorretor { get; set; }
        public DeclaracaoPessoalSaude declaracaoPessoalSaude { get; set; }
        public List<Beneficiario> beneficiarios { get; set; } = new List<Beneficiario>();
        private string _valorPermioAgregados;
        public string valorPremioAgregados
        {
            get => _valorPermioAgregados;
            set
            {
                erro.valida(value, "valorPremioAgregados");
                _valorPermioAgregados = value;
            }
        }
        private string _origemVenda;
        public string origemVenda
        {
            get => _origemVenda;
            set
            {
                //erro.valida(value, "origemVenda");
                _origemVenda = value;
            }
        }
        public FormaPagamento formaPagamento { get; set; }
        private DateTime _data;
        public string data
        {
            get => _data.ToShortDateString();
            set
            {
                erro.valida(value, "data");
                _data = DateTime.Parse(value);
            }
        }
        public Final final { get; set; }

    }
    public enum TipoTelefone
    {
        Residencial = 0,
        Comercial = 1,
        Celular = 2
    }
    public class Erro
    {
        public Boolean ocorreu { get; set; }
        public List<string> mensagens { get; set; }
        private int totalTelefones = 3;

        public Erro()
        {
            this.ocorreu = false;
            this.mensagens = new List<string>();
        }

        public void valida(string valor, string nomeCampo)
        {
            if (valor == null || valor == "")
            {
                ocorreu = true;
                mensagens.Add($"Deve existir o campo {nomeCampo}");
            }
        }

        public void valida(decimal? valor, string nomeCampo)
        {
            if (valor == null)
            {
                ocorreu = true;
                mensagens.Add($"Deve existir o campo {nomeCampo}");
            }
        }

        public void valida(int? valor, string nomeCampo)
        {
            if (valor == null)
            {
                ocorreu = true;
                mensagens.Add($"Deve existir o campo {nomeCampo}");
            }
        }


        public void valida(DateTime valor, string nomeCampo)
        {
            if (string.IsNullOrEmpty(valor.ToShortDateString()))
            {
                ocorreu = true;
                mensagens.Add($"Deve existir o campo {nomeCampo}");
            }
        }

        public void validaTelefone(string telefone)
        {
            if (telefone == null || telefone == "")
            {
                totalTelefones--;
                if (totalTelefones == 0)
                {
                    ocorreu = true;
                    mensagens.Add($"Deve existir pelo menos um telefone");
                }
            }
        }

    }
    public class CoberturaTitular
    {
        public string capitalSeguradoMorteAcidencial { get; set; } = "";
        public string valorPremioAcidentesPessoais { get; set; } = "";
        public string capitalSeguradoAssistenciaEmergencial { get; set; } = "";
        public string valorPremioAssistenciaEmergencial { get; set; } = "";
        public string capitalSeguradoAssistenciaFuneral { get; set; } = "";
        public string valorPremioAssistenciaFuneral { get; set; } = "";
    }
    public class CoberturaConjuge
    {
        public string plano { get; set; } = "";
        public string capitalSeguradoMorteAcidencial { get; set; } = "";
        public string valorPremioAcidentesPessoais { get; set; } = "";
        public string capitalSeguradoAssistenciaEmergencial { get; set; } = "";
        public string valorPremioAssistenciaEmergencial { get; set; } = "";
        public string capitalSeguradoAssistenciaFuneral { get; set; } = "";
        public string valorPremioAssistenciaFuneral { get; set; } = "";
    }
    public class Beneficiario
    {
        private Erro erro;

        public Beneficiario(Erro erro)
        {
            this.erro = erro;
        }
        public string nomeBeneficiário { get; set; } = "";
        public string parentesco { get; set; } = "";
        public string CPF { get; set; } = "";
        public string sexo { get; set; } = "";
        public string Percentual { get; set; } = "";
        public string filhoBeneficiario { get; set; } = "";
    }

    public class Final
    {
        public string Local { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string DataHora { get; set; } = "";
        public string Meio { get; set; } = "";
        public string AceiteDigital { get; set; } = "";

    }
}