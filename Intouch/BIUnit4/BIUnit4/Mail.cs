namespace BIUnit4
{
    using System;
    using System.Net;
    using System.Net.Mail;

    public sealed class Mail
    {
        private string _contaAutenticacao;
        private string _corpoMensagem;
        private bool _isHTML;
        private string _mailDestinatario;
        private string _mailRemetente;
        private string _senhaAutenticacao;
        private bool _servidorRequerAutenticacao = false;
        private string _servidorSaida;
        private string _titulo;

        public Mail()
        {
            this.senhaAutenticacao = "unit12345";
            this.contaAutenticacao = "notificacoes@unitfour.com.br";
        }

        public void EnviarEmail()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                NetworkCredential credential = new NetworkCredential();
                message.From = new MailAddress(this.mailRemetente, this.mailRemetente);
                message.To.Add(new MailAddress(this.mailDestinatario, this.mailDestinatario));
                message.IsBodyHtml = this.isHTML;
                message.Subject = this.titulo;
                message.Body = this.corpoMensagem;
                if (this.servidorRequerAutenticacao)
                {
                    credential.UserName = this.contaAutenticacao;
                    credential.Password = this.senhaAutenticacao;
                    client.UseDefaultCredentials = false;
                    client.Credentials = credential;
                }
                client.Host = this.servidorSaida;
                client.Port = 0x24b;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(message);
            }
            catch (Exception)
            {
            }
        }

        public string contaAutenticacao
        {
            get
            {
                return this._contaAutenticacao;
            }
            set
            {
                this._contaAutenticacao = value;
            }
        }

        public string corpoMensagem
        {
            get
            {
                return this._corpoMensagem;
            }
            set
            {
                this._corpoMensagem = value;
            }
        }

        public bool isHTML
        {
            get
            {
                return this._isHTML;
            }
            set
            {
                this._isHTML = value;
            }
        }

        public string mailDestinatario
        {
            get
            {
                return this._mailDestinatario;
            }
            set
            {
                this._mailDestinatario = value;
            }
        }

        public string mailRemetente
        {
            get
            {
                return this._mailRemetente;
            }
            set
            {
                this._mailRemetente = value;
            }
        }

        public string senhaAutenticacao
        {
            get
            {
                return this._senhaAutenticacao;
            }
            set
            {
                if (value.Length > 0)
                {
                    this.servidorRequerAutenticacao = true;
                    this._senhaAutenticacao = value;
                }
            }
        }

        public bool servidorRequerAutenticacao
        {
            get
            {
                return this._servidorRequerAutenticacao;
            }
            set
            {
                this._servidorRequerAutenticacao = value;
            }
        }

        public string servidorSaida
        {
            get
            {
                return this._servidorSaida;
            }
            set
            {
                this._servidorSaida = value;
            }
        }

        public string titulo
        {
            get
            {
                return this._titulo;
            }
            set
            {
                this._titulo = value;
            }
        }
    }
}

