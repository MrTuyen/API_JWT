using DS.BusinessObject.API;
using System.Web.Http;

namespace Invoice.API.Controllers
{
    public class BaseApiController : ApiController
    {
        protected PartnerOAuthBO partnerObject = PartnerOAuthBO.Current.CurrentPartner();

        public BaseApiController()
        {

        }
    }
}
