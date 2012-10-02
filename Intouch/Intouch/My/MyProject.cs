namespace Intouch.My
{
    using Intouch.SPC;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using Microsoft.VisualBasic.MyServices.Internal;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [HideModuleName, StandardModule, GeneratedCode("MyTemplate", "8.0.0.0")]
    internal sealed class MyProject
    {
        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
        private static readonly ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get
            {
                return m_AppObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get
            {
                return m_ComputerObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User
        {
            [DebuggerHidden]
            get
            {
                return m_UserObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices
        {
            [DebuggerHidden]
            get
            {
                return m_MyWebServicesObjectProvider.GetInstance;
            }
        }

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            public Intouch.SPC.consultaWebService m_consultaWebService;

            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T: new()
            {
                if (instance == null)
                {
                    return Activator.CreateInstance<T>();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType()
            {
                return typeof(MyProject.MyWebServices);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override string ToString()
            {
                return base.ToString();
            }

            public Intouch.SPC.consultaWebService consultaWebService
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_consultaWebService = Create__Instance__<Intouch.SPC.consultaWebService>(this.m_consultaWebService);
                    return this.m_consultaWebService;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_consultaWebService)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Intouch.SPC.consultaWebService>(ref this.m_consultaWebService);
                    }
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T: new()
        {
            private readonly ContextValue<T> m_Context;

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public ThreadSafeObjectProvider()
            {
                this.m_Context = new ContextValue<T>();
            }

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    T Value = this.m_Context.Value;
                    if (Value == null)
                    {
                        Value = Activator.CreateInstance<T>();
                        this.m_Context.Value = Value;
                    }
                    return Value;
                }
            }
        }
    }
}

