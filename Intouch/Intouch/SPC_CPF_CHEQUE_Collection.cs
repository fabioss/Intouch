namespace Intouch
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;

    public class SPC_CPF_CHEQUE_Collection : List<SPC_CPF_CHEQUE>
    {
        public void Add(SPC_CPF_CHEQUE item)
        {
            base.Add(item);
        }

        public object Add(int _codAlinea, string _dscAlinea, string _banco, string _numAgencia, string _numCC, string _dtEmissao, string _numCheque, string _vlCheque, string _nmAssociado, string _nmEntidade, string _origem)
        {
            object Add;
            SPC_CPF_CHEQUE _aux = new SPC_CPF_CHEQUE();
            SPC_CPF_CHEQUE _aux2 = _aux;
            _aux.CodAlinea = _codAlinea;
            _aux.DscAlinea = _dscAlinea;
            _aux.Banco = Conversions.ToShort(_banco);
            _aux.NumAgencia = Conversions.ToShort(_numAgencia);
            _aux.NumCC = _numCC;
            _aux.DtEmissao = Conversions.ToDate(_dtEmissao);
            _aux.NumCheque = Conversions.ToInteger(_numCheque);
            _aux.VlCheque = Conversions.ToDecimal(_vlCheque);
            _aux.NmAssociado = _nmAssociado;
            _aux.NmEntidade = _nmEntidade;
            _aux.Origem = _origem;
            _aux = null;
            base.Add(_aux);
            return _aux;
        }

        public bool Remove(SPC_CPF_CHEQUE item)
        {
            bool Remove;
            try
            {
                base.Remove(item);
                Remove = true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                Remove = false;
                ProjectData.ClearProjectError();
            }
            return Remove;
        }
    }
}

