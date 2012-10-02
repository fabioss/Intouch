namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [GeneratedCode("System.Web.Services", "2.0.50727.4927"), DesignerCategory("code"), DebuggerStepThrough]
    public class consultarCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal consultarCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public ResultadoConsulta Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ResultadoConsulta) this.results[0];
            }
        }
    }
}

