namespace BIUnit4
{
    using DllPainelDeControle;
    using System;
    using System.Data;
    using System.Text;

    public class Consulta : AbstractError, IConsulta
    {
        bool IConsulta.AutorizadoParaConsultar(string usuario, string Ip, string senha, string cliente, EnumProduto produto, ref int idLogin)
        {
            DataTable table = new DataTable();
            try
            {
                table = DbIntouch.ExecuteDataTable("PROJETO_FINANCEIRO..[BIINTOUCH.AUTORIZADOPARACONSULTAR] @USUARIO='" + usuario + "', @SENHA='" + senha + "', @CLIENTE='" + cliente + "', @IP='" + Ip + "', @ID_PRODUTO=" + Convert.ToInt32(produto).ToString());
            }
            catch (Exception exception)
            {
                base.Erro = exception.Message;
                return false;
            }
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row["ERRO"].ToString().Trim() != string.Empty)
                    {
                        base.Erro = row["ERRO"].ToString();
                        return false;
                    }
                    idLogin = Convert.ToInt32(row["IDLOGIN"].ToString());
                }
            }
            return true;
        }

        DataTable IConsulta.BuscaApresentacao(string tipoPessoa, string nome, string dataInicial, string dataFinal, string idadeInicial, string idadeFinal, string endereco, string numero, string complemento, string bairro, string cidade, string uf, string cep, string ddd, string telefone)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("[BIINTOUCH.LOCALIZA_BUSCA_APRESENTACAO_" + tipoPessoa + "] ");
            builder.AppendLine("@NOME = '" + nome + "',");
            if ((dataInicial != string.Empty) & (dataFinal != string.Empty))
            {
                builder.AppendLine("@DATAINICIAL = '" + DateTime.ParseExact(dataInicial, "dd/MM/yyyy", null).ToString("yyyy/MM/dd") + "',");
                builder.AppendLine("@DATAFINAL = '" + DateTime.ParseExact(dataFinal, "dd/MM/yyyy", null).ToString("yyyy/MM/dd") + "',");
            }
            builder.AppendLine("@IDADEINICIAL = '" + idadeInicial + "',");
            builder.AppendLine("@IDADEFINAL = '" + idadeFinal + "',");
            builder.AppendLine("@ENDERECO = '" + endereco + "', ");
            builder.AppendLine("@NUMERO = '" + numero + "', ");
            builder.AppendLine("@COMPLEMENTO = '" + complemento + "',");
            builder.AppendLine("@BAIRRO = '" + bairro + "',");
            builder.AppendLine("@CIDADE = '" + cidade + "',");
            builder.AppendLine("@UF = '" + uf + "',");
            builder.AppendLine("@CEP = '" + cep.Replace("-", "") + "',");
            builder.AppendLine("@DDD = " + ((ddd == string.Empty) ? "0" : ddd) + ",");
            builder.AppendLine("@TELEFONE = " + ((telefone == string.Empty) ? "0" : telefone));
            return DbIntouch.ExecuteDataTable(builder.ToString());
        }

        DataTable IConsulta.CarregaDadosMae(string idUnit)
        {
            DataTable table2;
            StringBuilder builder = new StringBuilder();
            DataTable table = new DataTable();
            try
            {
                builder.Length = 0;
                builder.AppendLine("EXECUTE INTOUCH.DBO.[BIINTOUCH.CARREGAINFORMACOES_MAE] ");
                builder.AppendLine("@ID_UNIT = '" + idUnit + "' ");
                table = DbIntouch.ExecuteDataTable(builder.ToString());
                table2 = table.Copy();
            }
            catch
            {
                table2 = null;
            }
            finally
            {
                if (table != null)
                {
                    table.Dispose();
                }
            }
            return table2;
        }

        DataSet IConsulta.CarregaDadosPf(string idUnit, bool filtroProcon)
        {
            DataSet set = new DataSet();
            try
            {
                set = DbIntouch.ExecuteDataset(string.Concat(new object[] { "INTOUCH..[BIINTOUCH.CARREGAINFORMACOES_PF_DESENV2] @ID_UNIT='", idUnit, "', @FILTRO_PROCON=", Convert.ToInt32(filtroProcon) }));
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return set;
        }

        DataSet IConsulta.CarregaDadosPj(string idUnit, bool filtroProcon)
        {
            DataSet set = new DataSet();
            try
            {
                set = DbIntouch.ExecuteDataset(string.Concat(new object[] { "UNITEMPRESAS..[BIINTOUCH.CARREGAINFORMACOES_PJ_DESENV2] @ID_UNIT_PJ=", idUnit, ", @FILTRO_PROCON=", Convert.ToInt32(filtroProcon) }));
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return set;
        }

        DataTable IConsulta.CarregaEmpresasLigadas(string idUnitPj, Usuario usuario, int idHistoricoLogin)
        {
            DataTable table = new DataTable();
            string cmd = "[BIINTOUCH.CARREGAEMPRESASLIGADAS] @ID_UNIT_PJ=" + idUnitPj;
            object obj2 = "INTOUCH..[BIINTOUCH.COBRARCONSULTA] @ID_CLIENTE = " + usuario.IdCliente.ToString();
            string str2 = string.Concat(new object[] { obj2, ", @ID_LOGIN=", usuario.IdLogin.ToString(), ", @ID_UNIT='", idUnitPj, "' , @TIPO_CONSULTA=3,@ID_HISTORICO_LOGIN=", idHistoricoLogin });
            try
            {
                table = DbIntouch.ExecuteDataTable(cmd);
                if (table != null)
                {
                    DbIntouch.ExecuteNonQuery(str2);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        DataTable IConsulta.CarregarDadosComerciasPf(string cpf)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("[BIINTOUCH.SP_CARREGADADOSCOMERCIAIS_PF] @CPF = '" + cpf + "'");
                table = DbIntouch.ExecuteDataTable(builder.ToString());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        DataTable IConsulta.CarregarDadosComerciasPj(string cnpj)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("[BIINTOUCH.SP_CARREGADADOSCOMERCIAIS_PJ] @CNPJ = '" + cnpj + "'");
                table = DbIntouch.ExecuteDataTable(builder.ToString());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        DataTable IConsulta.CarregarPessoasLigadas(string idPessoa, string ultimoNome, Usuario usuario, int idHistoricoLogin)
        {
            DataTable table = new DataTable();
            string cmd = "[BIINTOUCH.CARREGAPESSOASLIGADAS] @ID_UNIT=" + idPessoa;
            object obj2 = "INTOUCH..[BIINTOUCH.COBRARCONSULTA] @ID_CLIENTE = " + usuario.IdCliente.ToString();
            string str2 = string.Concat(new object[] { obj2, ", @ID_LOGIN=", usuario.IdLogin.ToString(), ", @ID_UNIT='", idPessoa, "' , @TIPO_CONSULTA=3,@ID_HISTORICO_LOGIN=", idHistoricoLogin });
            try
            {
                table = DbIntouch.ExecuteDataTable(cmd);
                if (table != null)
                {
                    table.TableName = "PESSOASLIGADAS";
                    DbIntouch.ExecuteNonQuery(str2);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        void IConsulta.CobrarConsulta(Usuario usuario, string intIdPessoa, int intTipoConsulta, int idHistoricoLogin)
        {
            try
            {
                object obj2 = "INTOUCH..[BIINTOUCH.COBRARCONSULTA] @ID_CLIENTE = " + usuario.IdCliente.ToString();
                DbIntouch.ExecuteNonQuery(string.Concat(new object[] { obj2, ", @ID_LOGIN=", usuario.IdLogin.ToString(), ", @ID_UNIT='", intIdPessoa, "' , @TIPO_CONSULTA=", intTipoConsulta, ",@ID_HISTORICO_LOGIN=", idHistoricoLogin }));
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        DataTable IConsulta.GetCcf(string cpf_cnpj)
        {
            DataTable table = new DataTable();
            string cmd = "[BIINTOUCH.GETCCF] @DOCUMENTO=" + cpf_cnpj;
            try
            {
                table = DbIntouch.ExecuteDataTable(cmd);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        string IConsulta.GetIdUnit(string documento)
        {
            string cmd = "[BIINTOUCH.GET_IDUNIT] @DOCUMENTO='" + documento + "'";
            string str2 = "";
            try
            {
                str2 = DbIntouch.ExecuteScalar(cmd);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return str2;
        }

        DataTable IConsulta.GetMaisTelefone(string idUnit, string tipoPessoa)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                string str = tipoPessoa.ToUpper();
                if (str != null)
                {
                    if (!(str == "PF"))
                    {
                        if (str == "PJ")
                        {
                            goto Label_0051;
                        }
                    }
                    else
                    {
                        builder.Append("[BIINTOUCH.MAIS_TELEFONES_PF] '" + idUnit + "'");
                    }
                }
                goto Label_006A;
            Label_0051:
                builder.Append("[BIINTOUCH.MAIS_TELEFONES_PJ] '" + idUnit + "'");
            Label_006A:
                table = DbIntouch.ExecuteDataTable(builder.ToString());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        DataTable IConsulta.GetPerfil(string cpf_cnpj)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.Append("[BIINTOUCH.PERFIL] '" + cpf_cnpj + "'");
                table = DbIntouch.ExecuteDataTable(builder.ToString());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        DataTable IConsulta.GetPerfilConsumo(string cpf)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.Append("[BIINTOUCH..GETPERFILCONSUMO] @CPF= '" + cpf + "'");
                table = DbIntouch.ExecuteDataTable(builder.ToString());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        string IConsulta.GetTipoDocumento(string documento)
        {
            string cmd = "DATAFOURLIB2010..[BIINTOUCH.OBTEM_TIPODOCUMENTO] @DOCUMENTO='" + documento + "'";
            string str2 = "";
            try
            {
                str2 = DbIntouch.ExecuteScalar(cmd);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return str2;
        }

        DataTable IConsulta.GetVeiculo(string cpf_cnpj)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.Append("[BIINTOUCH.VEICULOS] '" + cpf_cnpj + "'");
                table = DbIntouch.ExecuteDataTable(builder.ToString());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }

        int IConsulta.InserirInformacoesPf(string cpf, string nome, string sexo, string dataNasc, string idade, string estadoCivil, string nomeMae, int idUnit, int idLogin, bool obito)
        {
            int num = 0;
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("[BIINTOUCH.INSERIRINFORMACOES_PF] ");
                builder.AppendLine("'" + cpf.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty) + "',");
                builder.AppendLine("'" + nome.TrimStart(new char[0]).TrimEnd(new char[0]) + "',");
                builder.AppendLine("'" + sexo + "',");
                builder.AppendLine("'" + dataNasc + "',");
                builder.AppendLine("'" + idade + "',");
                builder.AppendLine("'" + estadoCivil + "',");
                builder.AppendLine("'" + nomeMae.TrimStart(new char[0]).TrimEnd(new char[0]) + "',");
                builder.AppendLine(idUnit.ToString() + ",");
                builder.AppendLine(idLogin.ToString() + ",");
                builder.AppendLine(Convert.ToInt32(obito).ToString() ?? "");
                num = Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return num;
        }

        int IConsulta.InserirInformacoesPj(string cnpj, string razao, string nomeFantasia, string dataAbertura, string cnae, string qtdFuncionarios, string situacao, string njur, string porte, string qtdProprietarios, int idUnit, int idLogin)
        {
            int num = 0;
            if (qtdFuncionarios.Length == 0)
            {
                qtdFuncionarios = "0";
            }
            if (qtdProprietarios.Length == 0)
            {
                qtdProprietarios = "0";
            }
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("DECLARE @RETORNO AS INT ");
                builder.AppendLine("INSERT INTO UNITEMPRESAS..HISTORICO_PJ (");
                builder.AppendLine("CNPJ,");
                builder.AppendLine("RAZAO,");
                builder.AppendLine("NOME_FANTASIA,");
                builder.AppendLine("DT_ABERTURA,");
                builder.AppendLine("CNAE,");
                builder.AppendLine("QTD_FUNCIONARIOS,");
                builder.AppendLine("DESCR_SITUACAO_CAD,");
                builder.AppendLine("NJUR,");
                builder.AppendLine("PORTE,");
                builder.AppendLine("QTD_PROP,");
                builder.AppendLine("ID_UNIT_PJ,");
                builder.AppendLine("ID_LOGIN,");
                builder.AppendLine("DATA_ACESSO )");
                builder.AppendLine("VALUES (");
                builder.AppendLine("'" + cnpj + "',");
                builder.AppendLine("'" + razao + "',");
                builder.AppendLine("'" + nomeFantasia + "',");
                builder.AppendLine("'" + dataAbertura + "',");
                builder.AppendLine("'" + cnae + "',");
                builder.AppendLine(qtdFuncionarios.ToString() + ",");
                builder.AppendLine("'" + situacao + "',");
                builder.AppendLine("'" + njur + "',");
                builder.AppendLine("'" + porte + "',");
                builder.AppendLine(qtdProprietarios.ToString() + ",");
                builder.AppendLine(idUnit.ToString() + ",");
                builder.AppendLine(idLogin.ToString() + ",");
                builder.AppendLine("GETDATE())");
                builder.AppendLine("SET @RETORNO = @@IDENTITY ");
                builder.AppendLine("SELECT @RETORNO");
                num = Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return num;
        }

        int IConsulta.InserirNovoEmailPf(string email, bool particular, int idStatus, int idUnit, int idLogin)
        {
            int num = 0;
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("[BIINTOUCH.INSERIR_NOVO_EMAIL_PF] ");
                builder.AppendLine(string.Format(" @EMAIL='{0}', ", email));
                builder.AppendLine(string.Format(" @STATUS={0}, ", idStatus.ToString()));
                builder.AppendLine(string.Format(" @ID_UNIT={0}, ", idUnit.ToString()));
                builder.AppendLine(string.Format(" @ID_LOGIN={0}", idLogin.ToString()));
                num = Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return num;
        }

        int IConsulta.InserirNovoEmailPj(string email, bool particular, int idStatus, int idUnitPj, int idLogin)
        {
            int num = 0;
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("[BIINTOUCH.INSERIR_NOVO_EMAIL_PJ] ");
                builder.AppendLine(string.Format(" @EMAIL='{0}', ", email));
                if (particular)
                {
                    builder.AppendLine(" @PARTICULAR=1, ");
                }
                else
                {
                    builder.AppendLine(" @PARTICULAR=0, ");
                }
                builder.AppendLine(string.Format(" @STATUS={0}, ", idStatus.ToString()));
                builder.AppendLine(string.Format(" @ID_UNIT_PJ={0}, ", idUnitPj.ToString()));
                builder.AppendLine(string.Format(" @ID_LOGIN={0}", idLogin.ToString()));
                num = Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return num;
        }

        int IConsulta.InserirNovoEndereco(string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string cep, int idStatus, int idUnit, int idLogin, int hEndId, int tipoConsulta, int origem, int idCliente)
        {
            int num = 0;
            logradouro.Replace('\'', '\x00b4');
            StringBuilder builder = new StringBuilder();
            try
            {
                if (cep.Length == 8)
                {
                    builder.AppendLine("[BIINTOUCH.INSERIR_NOVO_ENDERECO] ");
                    builder.AppendLine(string.Format(" @LOGRADOURO='{0}', ", logradouro));
                    builder.AppendLine(string.Format(" @NUMERO='{0}', ", numero));
                    builder.AppendLine(string.Format(" @COMPLEMENTO='{0}', ", complemento));
                    builder.AppendLine(string.Format(" @BAIRRO='{0}', ", bairro));
                    builder.AppendLine(string.Format(" @CIDADE='{0}', ", cidade));
                    builder.AppendLine(string.Format(" @UF='{0}', ", uf));
                    builder.AppendLine(string.Format(" @CEP='{0}', ", cep));
                    builder.AppendLine(string.Format(" @STATUS={0}, ", idStatus.ToString()));
                    builder.AppendLine(string.Format(" @ID_UNIT={0}, ", idUnit.ToString()));
                    builder.AppendLine(string.Format(" @ID_LOGIN={0},", idLogin.ToString()));
                    builder.AppendLine(string.Format(" @H_END_ID={0}, ", hEndId.ToString()));
                    builder.AppendLine(string.Format(" @TIPOCONSULTA={0}, ", tipoConsulta.ToString()));
                    builder.AppendLine(string.Format(" @ORIGEM={0}, ", origem.ToString()));
                    builder.AppendLine(string.Format(" @ID_CLIENTE={0} ", idCliente.ToString()));
                    num = Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return num;
        }

        DataSet IConsulta.LocalizarPessoaMarcondes(string[] opcoesAvancadas, bool filtroProcon)
        {
            string cmd = "[BIINTOUCH.LOCALIZA_" + opcoesAvancadas[0].ToUpper() + "_DESENV2]";
            DataSet set = new DataSet();
            try
            {
                if ((opcoesAvancadas[0] == "PF") && (opcoesAvancadas[1] == "POR_CPF"))
                {
                    cmd = (cmd + "@PESQ_AVANCADA = '" + opcoesAvancadas[1] + "', ") + "@CPF = '" + opcoesAvancadas[2].Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty) + "' ";
                    cmd = string.Concat(new object[] { cmd, ",@FILTRO_PROCON=", Convert.ToInt32(filtroProcon), " " });
                }
                else if ((opcoesAvancadas[0] == "PJ") && (opcoesAvancadas[1] == "POR_CNPJ"))
                {
                    cmd = (cmd + "@PESQ_AVANCADA = '" + opcoesAvancadas[1] + "', ") + "@CNPJ = '" + opcoesAvancadas[2].Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty) + "' ";
                    cmd = string.Concat(new object[] { cmd, ",@FILTRO_PROCON=", Convert.ToInt32(filtroProcon), " " });
                }
                else
                {
                    string str2 = opcoesAvancadas[1];
                    if (str2 != null)
                    {
                        if (!(str2 == "POR_NOME"))
                        {
                            if (str2 == "POR_TELEFONE")
                            {
                                goto Label_0267;
                            }
                            if (str2 == "POR_CEP")
                            {
                                goto Label_02DE;
                            }
                            if (str2 == "POR_ENDERECO")
                            {
                                goto Label_0341;
                            }
                            if (str2 == "POR_PLACA_VEICULO")
                            {
                                goto Label_03F1;
                            }
                        }
                        else
                        {
                            cmd = ((((cmd + "@PESQ_AVANCADA = '" + opcoesAvancadas[1] + "', ") + "@NOME = '" + opcoesAvancadas[2] + "', ") + "@BAIRRO = '" + opcoesAvancadas[3] + "', ") + "@CIDADE = '" + opcoesAvancadas[4] + "', ") + "@UF = '" + opcoesAvancadas[5] + "' ";
                        }
                    }
                }
                goto Label_0452;
            Label_0267:
                cmd = ((cmd + "@PESQ_AVANCADA = '" + opcoesAvancadas[1] + "', ") + "@DDD = '" + opcoesAvancadas[2] + "', ") + "@TELEFONE = '" + opcoesAvancadas[3] + "' ";
                cmd = string.Concat(new object[] { cmd, ",@FILTRO_PROCON=", Convert.ToInt32(filtroProcon), " " });
                goto Label_0452;
            Label_02DE:
                cmd = (cmd + "@PESQ_AVANCADA = '" + opcoesAvancadas[1] + "', ") + "@CEP = '" + opcoesAvancadas[2] + "' ";
                cmd = string.Concat(new object[] { cmd, ",@FILTRO_PROCON=", Convert.ToInt32(filtroProcon), " " });
                goto Label_0452;
            Label_0341:
                cmd = (((((cmd + "@PESQ_AVANCADA = '" + opcoesAvancadas[1] + "', ") + "@ENDERECO = '" + opcoesAvancadas[2] + "', ") + "@NUMERO = '" + opcoesAvancadas[3] + "', ") + "@BAIRRO = '" + opcoesAvancadas[4] + "', ") + "@CIDADE = '" + opcoesAvancadas[5] + "', ") + "@UF = '" + opcoesAvancadas[6] + "' ";
                cmd = string.Concat(new object[] { cmd, ",@FILTRO_PROCON=", Convert.ToInt32(filtroProcon), " " });
                goto Label_0452;
            Label_03F1:
                cmd = (cmd + "@PESQ_AVANCADA = '" + opcoesAvancadas[1] + "', ") + "@PLACA_VEICULO = '" + opcoesAvancadas[2] + "' ";
                cmd = string.Concat(new object[] { cmd, ",@FILTRO_PROCON=", Convert.ToInt32(filtroProcon), " " });
            Label_0452:
                set = DbIntouch.ExecuteDataset(cmd);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return set;
        }

        DataTable IConsulta.LocalizaVizinhos(string idUnit, string tipoPessoa, string melhorcep)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("[BIINTOUCH.PR_VIZINHOS_" + tipoPessoa + "_DESENV] @ID_UNIT = " + idUnit + ", @MELHORCEP='" + melhorcep + "'");
                table = DbIntouch.ExecuteDataTable(builder.ToString());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return table;
        }
    }
}

