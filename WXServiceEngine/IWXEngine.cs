using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WheaterSettings;

namespace WXServiceEngine
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IWXEngine" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IWXEngine
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        bool AdicionaMetar(string[] arrayMETAR);

        [OperationContract]
        object[] LerFicheiroTexto(string path);

        [OperationContract]
        bool ChamaProcessoPY();

        [OperationContract]
        bool CriaFicheiroXML(Wheater wx);   
    }

    

}
