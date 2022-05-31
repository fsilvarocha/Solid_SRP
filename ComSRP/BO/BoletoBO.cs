using Solid_SRP.ComSRP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SRP.ComSRP.BO
{
    public class BoletoBO
    {
        //injeção de dependencia de IEmail
        private readonly IEmail _email;

        //construtor faz a chamada pro email, tirando o acoplamento e responsabilidade do boleto pra enviar email
        public BoletoBO(IEmail email)
        {
            _email = email;
        }

        //gera o boleto
        public void Gerar()
        {
            _email.SendEmail("destinatario@gmail.com");
        }
    }
}
