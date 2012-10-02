namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.4927"), DesignerCategory("code")]
    public class listarProdutosCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal listarProdutosCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public Produto[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Produto[]) this.results[0];
            }
        }
    }
}

