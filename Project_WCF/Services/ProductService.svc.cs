using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Project_WCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ProductService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ProductService.svc ou ProductService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ProductService : IProductService
    {

        private dbTesteEntities _db ;
        public List<TB_PRODUCT> getProducts()
        {
            using (_db = new dbTesteEntities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                List<TB_PRODUCT> products = _db.TB_PRODUCT.ToList();
                return products;
            }
        }
    }
}
