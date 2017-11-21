using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WheaterSettings;

namespace WXServiceEngine
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "WXEngine" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez WXEngine.svc ou WXEngine.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class WXEngine : IWXEngine
    {
        public void DoWork()
        {
        }


        bool returnResult;
        string valorTemp;


        public bool ChamaProcessoPY()
        {
            bool returnRes = false;
            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            Process python;
            pythonInfo.FileName = @"C:\Windows\py.exe";
            pythonInfo.Arguments = @"H:\ISI_WX\Crawler\crawler.py";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;



            python = Process.Start(pythonInfo);
            if (python.Start())
                returnRes = true;
            python.WaitForExit();
            python.Close();




            return returnRes;
        }


        public object[] LerFicheiroTexto(string path)
        {
            object[] arrayObjetos = new object[2];
            //@"../../../../../output_metar.txt"
            string text = System.IO.File.ReadAllText(path);
            if (text != "") // temos conteudo para analisar
                returnResult = true;
            else if (text == "")
                returnResult = false;

            arrayObjetos[0] = text;
            arrayObjetos[1] = returnResult;
            return arrayObjetos;
        }
        public bool AdicionaMetar(string[] arrayMETAR)
        {

            Wheater wx;

            try
            {
                // Reconhecer e Adicionar definicoes met. na bib

                //Chamar Metodo Constroi XML e construir XML ??

                // Gravar na base de dados as def.
            }
            catch (Exception ex)
            {

            }
            throw new NotImplementedException();
            return true;
        }
    }
}
