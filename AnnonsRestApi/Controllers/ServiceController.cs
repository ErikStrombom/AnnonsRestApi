using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnnonsRestApi.Controllers
{
    public class ServiceController : ApiController
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        // GET: api/Service
        public ServiceReference1.Service[] Get()
        {
            ServiceReference1.Service[] output = client.GetAllServiceData();
            return output;
        }

        // GET: api/Service/5
        public ServiceReference1.Service Get(int id)
        {
            ServiceReference1.Service output = client.GetServiceById(id);
            return output;
        }

        // POST: api/Service
        public void Post([FromBody]CreateServiceObject serviceInput)
        {
                //List<ServiceReference1.ServiceStatusType> statuses = client.GetServiceStatusTypes().ToList();
                //List<ServiceReference1.SubCategory> subCategories = client.GetSubCategories().ToList();
                //List<ServiceReference1.ServiceType> serviceTypes = client.GetTypes().ToList();
                //List<ServiceReference1.Category> categories = client.GetCategories().ToList();

                client.CreateService(
                    serviceInput.Type,
                    serviceInput.CreatorId,
                    serviceInput.ServiceStatusId,
                    serviceInput.Picture,
                    serviceInput.Title,
                    serviceInput.Description,
                    serviceInput.Price,
                    serviceInput.StartDate,
                    serviceInput.EndDate,
                    serviceInput.TimeNeeded,
                    serviceInput.SubCategoryId);             

        }

        // PUT: api/Service/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Service/5
        public void Delete(int id)
        {
            client.DeleteService(id);
        }
    }
}
