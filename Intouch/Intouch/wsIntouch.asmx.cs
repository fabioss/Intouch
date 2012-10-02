namespace Intouch
{
    using Microsoft.ApplicationBlocks.Data;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics;
    using System.Web.Script.Services;
    using System.Web.Services;

    [WebService(Namespace="http://tempuri.org/"), ToolboxItem(false), WebServiceBinding(ConformsTo=WsiProfiles.BasicProfile1_1), ScriptService]
    public class wsIntouch : WebService
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();

        [DebuggerNonUserCode]
        public wsIntouch()
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        [WebMethod]
        public string[] GetClienteList(string prefixText, int count)
        {
            IEnumerator firstXPTO;
            List<string> items = new List<string>();
            DataTable dt = new DataTable();
            string strSql = "SELECT NOME FROM CLIENTE (NOLOCK) WHERE NOME LIKE '" + prefixText + "%'";
            dt = SqlHelper.ExecuteDataset(ConfigurationManager.AppSettings["CONEXAO"].ToString(), CommandType.Text, strSql).Tables[0];
            try
            {
                firstXPTO = dt.Rows.GetEnumerator();
                while (firstXPTO.MoveNext())
                {
                    DataRow dr = (DataRow) firstXPTO.Current;
                    items.Add(dr["NOME"].ToString());
                }
            }
            finally
            {
                //if (firstXPTO is IDisposable)
                //{
                //    (firstXPTO as IDisposable).Dispose();
                //}
            }
            return items.ToArray();
        }

        [WebMethod]
        public string[] GetCompletionList(string prefixText, int count)
        {
            if (count == 0)
            {
                count = 10;
            }
            Random rnd = new Random();
            List<string> items = new List<string>();
            int intFisrtXPTO = count;
            for (int i = 1; i <= intFisrtXPTO; i++)
            {
                char c1 = Convert.ToChar(Convert.ToString(rnd.Next(0x41, 90)));
                char c2 = Convert.ToChar(Convert.ToString(rnd.Next(0x61, 0x7a)));
                char c3 = Convert.ToChar(Convert.ToString(rnd.Next(0x61, 0x7a)));
                items.Add(prefixText + Convert.ToString(c1) + Convert.ToString(c2) + Convert.ToString(c3));
            }
            return items.ToArray();
        }

        [WebMethod]
        public string[] GetDocumentoPFList(string prefixText, int count)
        {
            string strSql;
            IEnumerator firstXPTO;
            List<string> items = new List<string>();
            DataTable dt = new DataTable();
            bool isDocument = true;
            int intFisrtXPTO = prefixText.Length - 1;
            for (int i = 0; i <= intFisrtXPTO; i++)
            {
                if (!char.IsNumber(prefixText[i]))
                {
                    isDocument = false;
                    break;
                }
            }
            if (isDocument)
            {
                strSql = "SELECT DISTINCT TOP 10 CPF + '|' + NOME AS DOCUMENTO FROM UNITPESSOAS..PESSOAS WHERE CPF LIKE '" + prefixText + "%'";
            }
            else
            {
                strSql = "SELECT DISTINCT TOP 10 CPF + '|' + NOME AS DOCUMENTO FROM UNITPESSOAS..PESSOAS WHERE NOME LIKE '" + prefixText + "%'";
            }
            dt = SqlHelper.ExecuteDataset("data source=200.98.214.218;initial catalog=INTOUCH;uid=sa;pwd=unit4os22$;Connect Timeout=300;", CommandType.Text, strSql).Tables[0];
            try
            {
                firstXPTO = dt.Rows.GetEnumerator();
                while (firstXPTO.MoveNext())
                {
                    DataRow dr = (DataRow) firstXPTO.Current;
                    items.Add(dr["DOCUMENTO"].ToString());
                }
            }
            finally
            {
                //if (firstXPTO is IDisposable)
                //{
                //    (firstXPTO as IDisposable).Dispose();
                //}
            }
            return items.ToArray();
        }

        [WebMethod]
        public string[] GetDocumentoPJList(string prefixText, int count)
        {
            string strSql;
            IEnumerator firstXPTO;
            List<string> items = new List<string>();
            DataTable dt = new DataTable();
            bool isDocument = true;
            int numXPTO = prefixText.Length - 1;
            for (int i = 0; i <= numXPTO; i++)
            {
                if (!char.IsNumber(prefixText[i]))
                {
                    isDocument = false;
                    break;
                }
            }
            if (isDocument)
            {
                strSql = "SELECT TOP 10 A.CNPJ + '|' + ISNULL(A.RAZAO,'') AS DOCUMENTO FROM UNITEMPRESAS..EMPRESAS A WITH (NOLOCK) WHERE A.CNPJ LIKE '" + prefixText + "%'";
            }
            else
            {
                strSql = "SELECT TOP 10 A.CNPJ + '|' + ISNULL(A.RAZAO,'') AS DOCUMENTO FROM UNITEMPRESAS..EMPRESAS A WITH (NOLOCK) WHERE A.RAZAO LIKE '" + prefixText + "%'";
            }
            dt = SqlHelper.ExecuteDataset("data source=200.98.214.218;initial catalog=INTOUCH;uid=sa;pwd=unit4os22$;Connect Timeout=300;", CommandType.Text , strSql).Tables[0];
            try
            {
                firstXPTO = dt.Rows.GetEnumerator();
                while (firstXPTO.MoveNext())
                {
                    DataRow dr = (DataRow) firstXPTO.Current;
                    items.Add(dr["DOCUMENTO"].ToString());
                }
            }
            finally
            {
                //if (firstXPTO is IDisposable)
                //{
                //    (firstXPTO as IDisposable).Dispose();
                //}
            }
            return items.ToArray();
        }

        [WebMethod]
        public string[] GetUsuarioList(string prefixText, int count, string contextKey)
        {
            IEnumerator firstXPTO;
            List<string> items = new List<string>();
            DataTable dt = new DataTable();
            string strSql = "SELECT DISTINCT TOP 15 CAST(ID_LOGIN AS VARCHAR(10)) + '|' + DS_LOGIN AS [USUARIO] FROM LOGINUNITFOUR..USUARIO (NOLOCK) WHERE ID_CLIENTE = " + contextKey + " AND DS_LOGIN LIKE '" + prefixText + "%' AND DS_LOGIN NOT LIKE '%EXCLUIDO%'";
            dt = SqlHelper.ExecuteDataset("data source=200.98.214.218;initial catalog=INTOUCH;uid=sa;pwd=unit4os22$;Connect Timeout=300;", CommandType.Text, strSql).Tables[0];
            try
            {
                firstXPTO = dt.Rows.GetEnumerator();
                while (firstXPTO.MoveNext())
                {
                    DataRow dr = (DataRow) firstXPTO.Current;
                    items.Add(dr["USUARIO"].ToString());
                }
            }
            finally
            {
                //if (firstXPTO is IDisposable)
                //{
                //    (firstXPTO as IDisposable).Dispose();
                //}
            }
            return items.ToArray();
        }
    }
}

