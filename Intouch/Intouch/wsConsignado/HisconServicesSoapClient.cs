namespace Intouch.wsConsignado
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    [DebuggerStepThrough, GeneratedCode("System.ServiceModel", "3.0.0.0")]
    public class HisconServicesSoapClient : ClientBase<HisconServicesSoap>, HisconServicesSoap
    {
        public HisconServicesSoapClient()
        {
        }

        public HisconServicesSoapClient(string endpointConfigurationName) : base(endpointConfigurationName)
        {
        }

        public HisconServicesSoapClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public HisconServicesSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public HisconServicesSoapClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public DataSet ConsultaProvider_IncluiConsulta(string login, string senha, string cpf, string nb)
        {
            return base.Channel.ConsultaProvider_IncluiConsulta(login, senha, cpf, nb);
        }

        public DataSet ConsultaProvider_SelecionaConsulta(string login, string senha, string codigo)
        {
            return base.Channel.ConsultaProvider_SelecionaConsulta(login, senha, codigo);
        }
    }
}

