using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Biblioteca.Dados
{
    public class DadosBuscaCEP
    {
        public class CEP
        {
            public string Logradouro { get; set; }
            public string TipoLogradouro { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string Resultado { get; set; }
            public string ResultadoMensagem { get; set; }
        }

        public CEP RetornarCEP(string CEP)
        {
            CEP modeloRetorno = new CEP();

            string caminhoXML = "http://cep.republicavirtual.com.br/web_cep.php?cep=" + CEP + "&formato=xml";
            XDocument documentoXML = XDocument.Load(caminhoXML);

            modeloRetorno.Logradouro = documentoXML.Descendants().Elements("logradouro").First().Value;
            modeloRetorno.TipoLogradouro = documentoXML.Descendants().Elements("tipo_logradouro").First().Value;
            modeloRetorno.Bairro = documentoXML.Descendants().Elements("bairro").First().Value;
            modeloRetorno.Cidade = documentoXML.Descendants().Elements("cidade").First().Value;
            modeloRetorno.UF = documentoXML.Descendants().Elements("uf").First().Value;
            modeloRetorno.Resultado = documentoXML.Descendants().Elements("resultado").First().Value;
            modeloRetorno.ResultadoMensagem = documentoXML.Descendants().Elements("resultado_txt").First().Value;

            return modeloRetorno;
        }
      }

}

