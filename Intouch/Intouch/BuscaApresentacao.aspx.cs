namespace Intouch
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Web.UI;

    public partial class BuscaApresentacao : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();

        [DebuggerNonUserCode]
        public BuscaApresentacao()
        {
            base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}

