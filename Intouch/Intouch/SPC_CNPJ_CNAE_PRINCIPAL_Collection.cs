namespace Intouch
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;

    public class SPC_CNPJ_CNAE_PRINCIPAL_Collection : List<SPC_CNPJ_CNAE_PRINCIPAL>
    {
        public void Add(SPC_CNPJ_CNAE_PRINCIPAL item)
        {
            base.Add(item);
        }

        public void Add(string _codigo, string _descricao, string _tp)
        {
            SPC_CNPJ_CNAE_PRINCIPAL _aux = new SPC_CNPJ_CNAE_PRINCIPAL();
            SPC_CNPJ_CNAE_PRINCIPAL _aux2 = _aux;
            _aux.Codigo = Conversions.ToLong(_codigo);
            _aux.Descricao = _descricao;
            _aux.Tipo = _tp;
            _aux = null;
            base.Add(_aux);
        }

        public void Remove(SPC_CNPJ_CNAE_PRINCIPAL item)
        {
            base.Remove(item);
        }
    }
}

