using Modele.Entities.Entity;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    [ServiceContract]
    public interface IServiceCommerce
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   UriTemplate = "GetProduits")]
        List<DataProduct> GetProduits();

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   UriTemplate = "getOrder")]
        List<DataOrder> GetOrders();

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   UriTemplate = "getProductStockt?code={code}")]
        int GetProductStock(String code);
    }
}
