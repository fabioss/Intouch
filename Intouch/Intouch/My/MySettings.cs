namespace Intouch.My
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), CompilerGenerated, EditorBrowsable(EditorBrowsableState.Advanced)]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static MySettings defaultInstance = ((MySettings) SettingsBase.Synchronized(new MySettings()));

        public static MySettings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [DebuggerNonUserCode, SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("https://SERVICOS.SPC.ORG.BR:443/spc/remoting/ws/consulta/consultaWebService"), ApplicationScopedSetting]
        public string Intouch_SPC_consultaWebService
        {
            get
            {
                return Convert.ToString(this["Intouch_SPC_consultaWebService"]);
            }
        }
    }
}

