namespace Intouch
{
    using BIUnit4;
    using Microsoft.ApplicationBlocks.Data;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Runtime.CompilerServices;

    public class SPC_CPF : IDisposable
    {
        private SPC_CPF_CHEQUE_Collection _cheque;
        private SPC_CPF_ConsultaRealizada_Collection _consultarealizada;
        private string _cpf;
        private string _dddCel;
        private string _dddCom;
        private string _dddRes;
        private string _dscSituacao;
        private DateTime _dtSituacao;
        private string _ende;
        private string _estCiv;
        private string _idade;
        private DateTime _nasc;
        private string _nome;
        private string _nomeMae;
        private string _nomePai;
        private string _sexo;
        private string _signo;
        private string _telCel;
        private string _telCom;
        private string _telRes;
        private int _tipoConsulta;
        private string _titEleitor;
        private string _uf;
        private string _ufSituacao;
        private bool disposedValue = false;

        public SPC_CPF()
        {
            this.Cheque = new SPC_CPF_CHEQUE_Collection();
            this.ConsultaRealizada = new SPC_CPF_ConsultaRealizada_Collection();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.Cheque = null;
                    this.ConsultaRealizada = null;
                }
                //this.Finalize();
            }
            this.disposedValue = true;
        }

        public void Inserir(SPC_CPF spc)
        {
            try
            {
                string cone = Cript_Decript.DeCifra(ConfigurationManager.AppSettings["Conexao"]);
                SqlParameter[] param = new SqlParameter[0x15];
                param[0] = new SqlParameter("@CPF", SqlDbType.VarChar);
                param[0].Value = spc.CPF;
                param[1] = new SqlParameter("@NOME", SqlDbType.VarChar);
                param[1].Value = spc.Nome == null ? String.Empty : spc.Nome;
                param[2] = new SqlParameter("@NOMEMAE", SqlDbType.VarChar);
                param[2].Value = spc.NomeMae == null ? String.Empty : spc.NomeMae;
                param[3] = new SqlParameter("@NOMEPAI", SqlDbType.VarChar);
                param[3].Value = spc.NomePai == null ? String.Empty : spc.NomePai;
                param[4] = new SqlParameter("@DTNASC", SqlDbType.DateTime);
                param[4].Value = spc.Nasc.ToShortDateString().Equals("01/01/0001") ? null : spc.Nasc.ToShortDateString();
                param[5] = new SqlParameter("@ENDERECO", SqlDbType.VarChar);
                param[5].Value = spc.Ende == null ? String.Empty : spc.Ende;
                param[6] = new SqlParameter("@ESTCIV", SqlDbType.VarChar);
                param[6].Value = spc.EstCiv == null ? String.Empty : spc.EstCiv;
                param[7] = new SqlParameter("@UF", SqlDbType.VarChar);
                param[7].Value = spc.UF == null ? String.Empty : spc.UF;
                param[8] = new SqlParameter("@IDADE", SqlDbType.Int);
                param[8].Value = Versioned.IsNumeric(spc.Idade) ? Convert.ToInt32(spc.Idade) : 0;
                param[9] = new SqlParameter("@TituloEleitor", SqlDbType.VarChar);
                param[9].Value = spc.TitEleitor == null ? String.Empty : spc.TitEleitor;
                param[10] = new SqlParameter("@SEXO", SqlDbType.VarChar);
                param[10].Value = spc.Sexo == null ? String.Empty : spc.Sexo;
                param[11] = new SqlParameter("@SIGNO", SqlDbType.VarChar);
                param[11].Value = spc.Signo == null ? String.Empty : spc.Signo;
                param[12] = new SqlParameter("@DTSITUACAO", SqlDbType.DateTime);
                param[12].Value = spc.DtSituacao.ToShortDateString().Equals("01/01/0001") ? null : spc.DtSituacao.ToShortDateString();
                param[13] = new SqlParameter("@DSCSITUACAO", SqlDbType.VarChar);
                param[13].Value = spc.DscSituacao == null ? String.Empty : spc.DscSituacao;
                param[14] = new SqlParameter("@UFSITUACAO", SqlDbType.VarChar);
                param[14].Value = spc.UfSituacao == null ? String.Empty : spc.UfSituacao;
                param[15] = new SqlParameter("@DDDCEL", SqlDbType.VarChar);
                param[15].Value = spc.DDDCel == null ? String.Empty : spc.DDDCel;
                param[0x10] = new SqlParameter("@TELCEL", SqlDbType.VarChar);
                param[0x10].Value = spc.TelCel == null ? String.Empty : spc.TelCel;
                param[0x11] = new SqlParameter("@DDDCOM", SqlDbType.VarChar);
                param[0x11].Value = spc.DDDCom == null ? String.Empty : spc.DDDCom;
                param[0x12] = new SqlParameter("@TELCOM", SqlDbType.VarChar);
                param[0x12].Value = spc.TelCom == null ? String.Empty : spc.TelCom;
                param[0x13] = new SqlParameter("@DDDRES", SqlDbType.VarChar);
                param[0x13].Value = spc.DDDRes == null ? String.Empty : spc.DDDRes;
                param[20] = new SqlParameter("@TELRES", SqlDbType.VarChar);
                param[20].Value = spc.TelRes == null ? String.Empty : spc.TelRes;
                long resultConsulta = Convert.ToInt32(SqlHelper.ExecuteScalar(cone, CommandType.StoredProcedure, "intouch..prc_SPC_Inserir_Consulta", param));
                if ((spc.Cheque != null) && (spc.Cheque.Count > 0))
                {
                    param = new SqlParameter[13];
                    foreach (SPC_CPF_CHEQUE item in spc.Cheque)
                    {
                        param[0] = new SqlParameter("@ID", SqlDbType.BigInt);
                        param[0].Value = resultConsulta;
                        param[1] = new SqlParameter("@ID_TP_CONSULTA", SqlDbType.Int);
                        param[1].Value = spc.TipoConsulta;
                        param[2] = new SqlParameter("@CODALINEA", SqlDbType.BigInt);
                        param[2].Value = DBNull.Value.Equals(item.CodAlinea) ? String.Empty : item.CodAlinea.ToString();
                        param[3] = new SqlParameter("@DSCALINEA", SqlDbType.VarChar);
                        param[3].Value = item.DscAlinea.ToString() != "" ? item.DscAlinea : String.Empty;
                        param[4] = new SqlParameter("@BANCO", SqlDbType.VarChar);
                        param[4].Value = item.Banco.ToString() != "" ? item.Banco.ToString() : String.Empty;
                        param[5] = new SqlParameter("@NUMAGENCIA", SqlDbType.VarChar);
                        param[5].Value = item.NumAgencia.ToString() != "" ? item.NumAgencia.ToString() : String.Empty;
                        param[6] = new SqlParameter("@NUMCTACORRENTE", SqlDbType.VarChar);
                        param[6].Value = item.NumCC != "" ? item.NumCC : String.Empty;
                        param[7] = new SqlParameter("@DTEMISSAO", SqlDbType.DateTime);
                        param[7].Value = item.DtEmissao.ToShortDateString().Equals("01/01/0001") ? String.Empty : item.DtEmissao.ToShortDateString();
                        param[8] = new SqlParameter("@NUMCHEQUE", SqlDbType.VarChar);
                        param[8].Value = item.NumCheque.ToString() != "" ? item.NumCheque.ToString() : String.Empty;
                        param[9] = new SqlParameter("@VLCHEQUE", SqlDbType.Decimal);
                        param[9].Value = item.VlCheque.ToString() != "" ? item.VlCheque.ToString() : String.Empty;
                        param[10] = new SqlParameter("@NOMEASSOCIADOCHEQUE", SqlDbType.VarChar);
                        param[10].Value = item.NmAssociado != "" ? item.NmAssociado : String.Empty;
                        param[11] = new SqlParameter("@NOMEENTIDADECHEQUE", SqlDbType.VarChar);
                        param[11].Value = item.NmEntidade != "" ? item.NmEntidade : String.Empty;
                        param[12] = new SqlParameter("@ORIGEMCHEQUE", SqlDbType.VarChar);
                        param[12].Value = item.Origem != "" ? item.Origem : String.Empty;
                        SqlHelper.ExecuteNonQuery(cone, CommandType.StoredProcedure, "intouch..prc_SPC_Inserir_Cheque", param);
                    }
                }
                if ((spc.ConsultaRealizada != null) && (spc.ConsultaRealizada.Count > 0))
                {
                    param = new SqlParameter[8];
                    foreach (SPC_CPF_ConsultaRealizada item in spc.ConsultaRealizada)
                    {
                        param[0] = new SqlParameter("@ID", SqlDbType.BigInt);
                        param[0].Value = resultConsulta;
                        param[1] = new SqlParameter("@ID_TP_CONSULTA", SqlDbType.Int);
                        param[1].Value = spc.TipoConsulta;
                        param[2] = new SqlParameter("@QUANTIDADEDIASCONSULTADOS", SqlDbType.BigInt);
                        param[2].Value = !Versioned.IsNumeric(item.QuantidadeDiasConsultados) ? 0 : item.QuantidadeDiasConsultados;
                        param[3] = new SqlParameter("@DataUltimaOcorrencia", SqlDbType.DateTime);
                        param[3].Value = item.DataUltimaOcorrencia.ToShortDateString().Equals("01/01/0001") ? String.Empty : item.DataUltimaOcorrencia.ToShortDateString();
                        param[4] = new SqlParameter("@DataConsulta", SqlDbType.DateTime);
                        param[4].Value = item.DataConsulta.ToShortDateString().Equals("01/01/0001") ? String.Empty : item.DataConsulta.ToShortDateString();
                        param[5] = new SqlParameter("@NomeAssociado", SqlDbType.VarChar);
                        param[5].Value = item.NomeAssociado == null ? String.Empty : item.NomeAssociado;
                        param[6] = new SqlParameter("@NomeEntidade", SqlDbType.VarChar);
                        param[6].Value = item.NomeEntidade == null ? String.Empty : item.NomeEntidade;
                        param[7] = new SqlParameter("@Origem", SqlDbType.VarChar);
                        param[7].Value = item.Origem == null ? String.Empty : item.Origem;
                    }
                    SqlHelper.ExecuteNonQuery(cone, CommandType.StoredProcedure, "intouch..prc_SPC_Inserir_ConsultaRealizada", param);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                ProjectData.ClearProjectError();
            }
        }

        public SPC_CPF_CHEQUE_Collection Cheque
        {
            get
            {
                return this._cheque;
            }
            set
            {
                this._cheque = value;
            }
        }

        public SPC_CPF_ConsultaRealizada_Collection ConsultaRealizada
        {
            get
            {
                return this._consultarealizada;
            }
            set
            {
                this._consultarealizada = value;
            }
        }

        public string CPF
        {
            get
            {
                return this._cpf;
            }
            set
            {
                this._cpf = value;
            }
        }

        public string DDDCel
        {
            get
            {
                return this._dddCel;
            }
            set
            {
                this._dddCel = value;
            }
        }

        public string DDDCom
        {
            get
            {
                return this._dddCom;
            }
            set
            {
                this._dddCom = value;
            }
        }

        public string DDDRes
        {
            get
            {
                return this._dddRes;
            }
            set
            {
                this._dddRes = value;
            }
        }

        public string DscSituacao
        {
            get
            {
                return this._dscSituacao;
            }
            set
            {
                this._dscSituacao = value;
            }
        }

        public DateTime DtSituacao
        {
            get
            {
                return this._dtSituacao;
            }
            set
            {
                this._dtSituacao = value;
            }
        }

        public string Ende
        {
            get
            {
                return this._ende;
            }
            set
            {
                this._ende = value;
            }
        }

        public string EstCiv
        {
            get
            {
                return this._estCiv;
            }
            set
            {
                this._estCiv = value;
            }
        }

        public ushort Idade
        {
            get
            {
                return Convert.ToUInt16(this._idade);
            }
            set
            {
                this._idade = Convert.ToString((uint) value);
            }
        }

        public DateTime Nasc
        {
            get
            {
                return this._nasc;
            }
            set
            {
                this._nasc = value;
            }
        }

        public string Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        public string NomeMae
        {
            get
            {
                return this._nomeMae;
            }
            set
            {
                this._nomeMae = value;
            }
        }

        public string NomePai
        {
            get
            {
                return this._nomePai;
            }
            set
            {
                this._nomePai = value;
            }
        }

        public string Sexo
        {
            get
            {
                return this._sexo;
            }
            set
            {
                this._sexo = value;
            }
        }

        public string Signo
        {
            get
            {
                return this._signo;
            }
            set
            {
                this._signo = value;
            }
        }

        public string TelCel
        {
            get
            {
                return this._telCel;
            }
            set
            {
                this._telCel = value;
            }
        }

        public string TelCom
        {
            get
            {
                return this._telCom;
            }
            set
            {
                this._telCom = value;
            }
        }

        public string TelRes
        {
            get
            {
                return this._telRes;
            }
            set
            {
                this._telRes = value;
            }
        }

        public int TipoConsulta
        {
            get
            {
                return this._tipoConsulta;
            }
            set
            {
                this._tipoConsulta = value;
            }
        }

        public string TitEleitor
        {
            get
            {
                return this._titEleitor;
            }
            set
            {
                this._titEleitor = value;
            }
        }

        public string UF
        {
            get
            {
                return this._uf;
            }
            set
            {
                this._uf = value;
            }
        }

        public string UfSituacao
        {
            get
            {
                return this._ufSituacao;
            }
            set
            {
                this._ufSituacao = value;
            }
        }

        public enum Tipo_Consulta
        {
            PF = 1,
            PJ = 2
        }
    }
}

