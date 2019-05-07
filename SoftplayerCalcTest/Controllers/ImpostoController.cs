using Imposto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoftplayerCalcTest.Controllers
{
    [RoutePrefix("api")]
    public class ImpostoController : ApiController
    {
        [HttpGet]
        [Route("calculajuros")]      
        public decimal CalculaJuros(decimal valorInicial, int meses)
        {
            ICalcula imposto = new Calcula();

            return imposto.JurosCompostos(valorInicial, meses);
        }

        [HttpGet]
        [Route("showmethecode")]
        public string  ShowMeTheCode()
        {
            return ConfigurationManager.AppSettings["git"];
        }
    }
}