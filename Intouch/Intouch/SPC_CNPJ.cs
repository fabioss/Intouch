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

    public class SPC_CNPJ : IDisposable
    {
        private SPC_CPF_CHEQUE_Collection _cheque;
        private SPC_CNPJ_CNAE_PRINCIPAL_Collection _cnae;
        private string _cnpj;
        private SPC_CPF_ConsultaRealizada_Collection _consultarealizada;
        private string _ddd;
        private string _dddfax;
        private SPC_CNPJ_ENDERECO _endereco;
        private string _fax;
        private string _insEstadual;
        private string _njur;
        private string _njurDescricao;
        private string _nmComercial;
        private string _razao;
        private string _razaoAnterior;
        private string _situacao;
        private string _telefone;
        private int _tipoConsulta;
        private decimal _vlCapital;
        private bool disposedValue = false;

        public SPC_CNPJ()
        {
            this.Cnae = new SPC_CNPJ_CNAE_PRINCIPAL_Collection();
            this.Endereco = new SPC_CNPJ_ENDERECO();
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
                    this.Endereco = null;
                    this.ConsultaRealizada = null;
                }
                //this.Finalize();
            }
            this.disposedValue = true;
        }

        public void Inserir_Empresa(SPC_CNPJ pj)
        {
            string cone = Cript_Decript.DeCifra(ConfigurationManager.AppSettings["Conexao"]);
            SqlParameter[] param = new SqlParameter[0x13];
            try
            {
                SPC_CNPJ cnpjXPTO = pj;
                param[0] = new SqlParameter("@CNPJ", SqlDbType.VarChar);
                param[0].Value = cnpjXPTO.CNPJ == null ? String.Empty : cnpjXPTO.CNPJ.ToString();
                param[1] = new SqlParameter("@Razao", SqlDbType.VarChar);
                param[1].Value = cnpjXPTO.Razao == null ? String.Empty : cnpjXPTO.Razao.ToString();
                param[2] = new SqlParameter("@Razao_Anterior", SqlDbType.VarChar);
                param[2].Value = cnpjXPTO.RazaoAnterior == null ? String.Empty : cnpjXPTO.RazaoAnterior.ToString();
                param[3] = new SqlParameter("@Bairro", SqlDbType.VarChar);
                param[3].Value = cnpjXPTO.Endereco.Bairro == null ? String.Empty : cnpjXPTO.Endereco.Bairro.ToString();
                param[4] = new SqlParameter("@Cidade", SqlDbType.VarChar);
                param[4].Value = cnpjXPTO.Endereco.Cidade == null ? String.Empty : cnpjXPTO.Endereco.Cidade.ToString();
                param[5] = new SqlParameter("@UF", SqlDbType.VarChar);
                param[5].Value = cnpjXPTO.Endereco.UF == null ? String.Empty : cnpjXPTO.Endereco.UF.ToString();
                param[6] = new SqlParameter("@Complemento", SqlDbType.VarChar);
                param[6].Value = cnpjXPTO.Endereco.Complemento == null ? String.Empty : cnpjXPTO.Endereco.Complemento.ToString();
                param[7] = new SqlParameter("@Logradouro", SqlDbType.VarChar);
                param[7].Value = cnpjXPTO.Endereco.Logradouro == null ? String.Empty : cnpjXPTO.Endereco.Logradouro.ToString();
                param[8] = new SqlParameter("@Numero", SqlDbType.VarChar);
                param[8].Value = cnpjXPTO.Endereco.Numero == null ? String.Empty : cnpjXPTO.Endereco.Numero.ToString();
                param[9] = new SqlParameter("@DDDFax", SqlDbType.VarChar);
                param[9].Value = cnpjXPTO.DDDFax == null ? String.Empty : cnpjXPTO.DDDFax.ToString();
                param[10] = new SqlParameter("@FoneFax", SqlDbType.VarChar);
                param[10].Value = cnpjXPTO.Fax == null ? String.Empty : cnpjXPTO.Fax.ToString();
                param[11] = new SqlParameter("@InscrEstadual", SqlDbType.VarChar);
                param[11].Value = cnpjXPTO.InscrEstadual == null ? String.Empty : cnpjXPTO.InscrEstadual.ToString();
                param[12] = new SqlParameter("@CodNatJur", SqlDbType.VarChar);
                param[12].Value = cnpjXPTO.NatJuridica == null ? String.Empty : cnpjXPTO.NatJuridica.ToString();
                param[13] = new SqlParameter("@DescNatJur", SqlDbType.VarChar);
                param[13].Value = cnpjXPTO.NatJurDescricao == null ? String.Empty : cnpjXPTO.NatJurDescricao.ToString();
                param[14] = new SqlParameter("@NmComercial", SqlDbType.VarChar);
                param[14].Value = cnpjXPTO.NmComercial == null ? String.Empty : cnpjXPTO.NmComercial.ToString();
                param[15] = new SqlParameter("@Situacao", SqlDbType.VarChar);
                param[15].Value = cnpjXPTO.Situacao == null ? String.Empty : cnpjXPTO.Situacao.ToString();
                param[0x10] = new SqlParameter("@DDD", SqlDbType.Int);
                param[0x10].Value = cnpjXPTO.DDD == null ? String.Empty : cnpjXPTO.DDD.ToString();
                param[0x11] = new SqlParameter("@Fone", SqlDbType.VarChar);
                param[0x11].Value = cnpjXPTO.Telefone == null ? String.Empty : cnpjXPTO.Telefone.ToString();
                param[0x12] = new SqlParameter("@VlCapital", SqlDbType.VarChar);
                param[0x12].Value = !Versioned.IsNumeric(cnpjXPTO.VlCapital) ? String.Empty : cnpjXPTO.VlCapital.ToString();
                long ID_SPC_CNPJ = (long)(SqlHelper.ExecuteScalar(cone, CommandType.StoredProcedure, "INTOUCH..prc_Inserir_CNPJ", param));
                param = new SqlParameter[4];
                foreach (SPC_CNPJ_CNAE_PRINCIPAL Cnae in cnpjXPTO.Cnae)
                {
                    param[0] = new SqlParameter("@ID_SPC_CNPJ", SqlDbType.BigInt);
                    param[0].Value = ID_SPC_CNPJ;
                    param[1] = new SqlParameter("@Cnae", SqlDbType.BigInt);
                    param[1].Value = !Versioned.IsNumeric(Cnae.Codigo) ? 0 : Cnae.Codigo;
                    param[2] = new SqlParameter("@DESCRICAO", SqlDbType.VarChar);
                    param[2].Value = Cnae.Descricao == null ? String.Empty : Cnae.Descricao;
                    param[3] = new SqlParameter("@TIPO", SqlDbType.VarChar);
                    param[3].Value = Cnae.Tipo == null ? String.Empty : Cnae.Tipo;
                    SqlHelper.ExecuteScalar(cone, CommandType.StoredProcedure, "INTOUCH..prc_Inserir_CNPJ_CNAE", param);
                }
                if ((cnpjXPTO.Cheque != null) && (cnpjXPTO.Cheque.Count > 0))
                {
                    param = new SqlParameter[13];
                    foreach (SPC_CPF_CHEQUE item in cnpjXPTO.Cheque)
                    {
                        param[0] = new SqlParameter("@ID", SqlDbType.BigInt);
                        param[0].Value = ID_SPC_CNPJ;
                        param[1] = new SqlParameter("@ID_TP_CONSULTA", SqlDbType.Int);
                        param[1].Value = pj.TipoConsulta;
                        param[2] = new SqlParameter("@CODALINEA", SqlDbType.BigInt);
                        param[2].Value = DBNull.Value.Equals(item.CodAlinea) ? String.Empty : item.CodAlinea.ToString();
                        param[3] = new SqlParameter("@DSCALINEA", SqlDbType.VarChar);
                        param[3].Value = item.DscAlinea.ToString() != "" ? item.DscAlinea : String.Empty ;
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
                        param[10].Value = item.NmAssociado != "" ? item.NmAssociado: String.Empty;
                        param[11] = new SqlParameter("@NOMEENTIDADECHEQUE", SqlDbType.VarChar);
                        param[11].Value = item.NmEntidade != "" ? item.NmEntidade: String.Empty;
                        param[12] = new SqlParameter("@ORIGEMCHEQUE", SqlDbType.VarChar);
                        param[12].Value = item.Origem != "" ? item.Origem: String.Empty;
                        SqlHelper.ExecuteNonQuery(cone, CommandType.StoredProcedure, "intouch..prc_SPC_Inserir_Cheque", param);
                    }
                }
                if ((cnpjXPTO.ConsultaRealizada != null) && (cnpjXPTO.ConsultaRealizada.Count > 0))
                {
                    param = new SqlParameter[8];
                    foreach (SPC_CPF_ConsultaRealizada item in cnpjXPTO.ConsultaRealizada)
                    {
                        param[0] = new SqlParameter("@ID", SqlDbType.BigInt);
                        param[0].Value = ID_SPC_CNPJ;
                        param[1] = new SqlParameter("@ID_TP_CONSULTA", SqlDbType.Int);
                        param[1].Value = pj.TipoConsulta;
                        param[2] = new SqlParameter("@QUANTIDADEDIASCONSULTADOS", SqlDbType.BigInt);
                        param[2].Value = !Versioned.IsNumeric(item.QuantidadeDiasConsultados) ? 0 : item.QuantidadeDiasConsultados;
                        param[3] = new SqlParameter("@DataUltimaOcorrencia", SqlDbType.DateTime);
                        param[3].Value = item.DataUltimaOcorrencia.ToShortDateString().Equals("01/01/0001") ? String.Empty : item.DataUltimaOcorrencia.ToShortDateString();
                        param[4] = new SqlParameter("@DataConsulta", SqlDbType.DateTime);
                        param[4].Value = item.DataConsulta.ToShortDateString().Equals("01/01/0001") ? String.Empty : item.DataConsulta.ToShortDateString();
                        param[5] = new SqlParameter("@NomeAssociado", SqlDbType.VarChar);
                        param[5].Value = item.NomeAssociado == null ? String.Empty :  item.NomeAssociado;
                        param[6] = new SqlParameter("@NomeEntidade", SqlDbType.VarChar);
                        param[6].Value = item.NomeEntidade == null ? String.Empty : item.NomeEntidade;
                        param[7] = new SqlParameter("@Origem", SqlDbType.VarChar);
                        param[7].Value = item.Origem == null ? String.Empty : item.Origem;
                    }
                    SqlHelper.ExecuteNonQuery(cone, CommandType.StoredProcedure, "intouch..prc_SPC_Inserir_ConsultaRealizada", param);
                }
                cnpjXPTO = null;
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

        public SPC_CNPJ_CNAE_PRINCIPAL_Collection Cnae
        {
            get
            {
                return this._cnae;
            }
            set
            {
                this._cnae = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this._cnpj;
            }
            set
            {
                this._cnpj = value;
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

        public string DDD
        {
            get
            {
                return this._ddd;
            }
            set
            {
                this._ddd = value;
            }
        }

        public string DDDFax
        {
            get
            {
                return this._dddfax;
            }
            set
            {
                this._dddfax = value;
            }
        }

        public SPC_CNPJ_ENDERECO Endereco
        {
            get
            {
                return this._endereco;
            }
            set
            {
                this._endereco = value;
            }
        }

        public string Fax
        {
            get
            {
                return this._fax;
            }
            set
            {
                this._fax = value;
            }
        }

        public string InscrEstadual
        {
            get
            {
                return this._insEstadual;
            }
            set
            {
                this._insEstadual = value;
            }
        }

        public string NatJurDescricao
        {
            get
            {
                return this._njurDescricao;
            }
            set
            {
                this._njurDescricao = value;
            }
        }

        public string NatJuridica
        {
            get
            {
                return this._njur;
            }
            set
            {
                this._njur = value;
            }
        }

        public string NmComercial
        {
            get
            {
                return this._nmComercial;
            }
            set
            {
                this._nmComercial = value;
            }
        }

        public string Razao
        {
            get
            {
                return this._razao;
            }
            set
            {
                this._razao = value;
            }
        }

        public string RazaoAnterior
        {
            get
            {
                return this._razaoAnterior;
            }
            set
            {
                this._razaoAnterior = value;
            }
        }

        public string Situacao
        {
            get
            {
                return this._situacao;
            }
            set
            {
                this._situacao = value;
            }
        }

        public string Telefone
        {
            get
            {
                return this._telefone;
            }
            set
            {
                this._telefone = value;
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

        public decimal VlCapital
        {
            get
            {
                return this._vlCapital;
            }
            set
            {
                this._vlCapital = value;
            }
        }

        public enum Tipo_Consulta
        {
            PF = 1,
            PJ = 2
        }
    }
}

