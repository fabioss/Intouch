namespace BIUnit4
{
    using System;

    public class BIPainelDeControle : IBIPainelDeControle
    {
        private Consulta _Consulta;

        IConsulta IBIPainelDeControle.Consulta
        {
            get
            {
                if (this._Consulta == null)
                {
                    this._Consulta = new Consulta();
                }
                return this._Consulta;
            }
        }
    }
}

