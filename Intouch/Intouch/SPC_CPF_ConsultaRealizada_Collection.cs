namespace Intouch
{
    using System;
    using System.Collections.Generic;

    public class SPC_CPF_ConsultaRealizada_Collection : List<SPC_CPF_ConsultaRealizada>
    {
        public void Add(SPC_CPF_ConsultaRealizada item)
        {
            base.Add(item);
        }

        public void Add(int _quantidadediasconsultados, DateTime _dataultimaocorrencia, DateTime _dataConsulta, string _nomeAssociado, string _nomeEntidade, string _origem)
        {
            SPC_CPF_ConsultaRealizada _aux = new SPC_CPF_ConsultaRealizada();
            SPC_CPF_ConsultaRealizada _aux2 = _aux;
            _aux.QuantidadeDiasConsultados = _quantidadediasconsultados;
            _aux.DataUltimaOcorrencia = _dataultimaocorrencia;
            _aux.DataConsulta = _dataConsulta;
            _aux.NomeAssociado = _nomeAssociado;
            _aux.NomeEntidade = _nomeEntidade;
            _aux.Origem = _origem;
            _aux = null;
            base.Add(_aux);
        }
    }
}

