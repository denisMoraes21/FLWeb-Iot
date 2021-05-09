using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace WebApplication7
{
    /// <summary>
    /// Webservice REST para upload de arquivos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class WebService1 : System.Web.Services.WebService
    {
        public void main(string[] args)
        {
        }
        [WebMethod]
        public string Upload(String Arquivo1, byte[] tamanho)
        {
            string arquivoPC = @"C:\Users\denis\Documents\1.txt";
            if (File.Exists(arquivoPC))
            {
                try
                {
                    String arquivoWeb = Server.MapPath(arquivoPC) + Arquivo1;
                    File.WriteAllBytes(arquivoWeb, tamanho);
                }
                catch
                {
                    return "Erro de upload!";
                }
            }
            else
            {
                return "Arquivo inexistente!";
            }

                return "Upload feito!";
        }
    }
}
