using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;


namespace Project_WCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IProductService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<TB_PRODUCT> getProducts();
    }
}
