namespace BIUnit4
{
    using System;

    public class BusinessProduto : IBusinessProduto
    {
        private BIDataFour _BIDataFour;
        private BIIntouch _BIIntouch;

        IBIDataFour IBusinessProduto.IBIDataFour
        {
            get
            {
                if (this._BIDataFour == null)
                {
                    this._BIDataFour = new BIDataFour();
                }
                return this._BIDataFour;
            }
        }

        IBIIntouch IBusinessProduto.IBIIntouch
        {
            get
            {
                if (this._BIIntouch == null)
                {
                    this._BIIntouch = new BIIntouch();
                }
                return this._BIIntouch;
            }
        }
    }
}

