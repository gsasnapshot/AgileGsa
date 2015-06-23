using FaNgMvcBs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebGrease.Css.Extensions;

namespace FaNgMvcBs.Controllers
{
    public class SampleController : ApiController
    {
        public List<SampleModel> Get()
        {
            var session = HttpContext.Current.Session;
            if (session["Data"] == null)
            {
                session["Data"] = SampleModel.BuildModels();
            }
            return (List<SampleModel>)session["Data"];
        }

        public SampleModel Get(int id)
        {
            var session = HttpContext.Current.Session;
            var result = (List<SampleModel>)session["Data"];
            return result.FirstOrDefault(d => d.Id == id);
        }

        public object Post(SampleModel item)
        {
            var session = HttpContext.Current.Session;
            var result = (List<SampleModel>)session["Data"];
            var success = false;
            try
            {
                item.Created = DateTime.UtcNow;
                item.Id = result.Max(r => r.Id) + 1;
                result.Add(item);
                success = true;
            }
            catch
            {
                success = false;
            }
            return new { Successful = success };
        }

        public object Delete(int id)
        {
            var session = HttpContext.Current.Session;
            var result = (List<SampleModel>)session["Data"];
            var success = false;
            try
            {
                result.Where(r => r.ParentId == id).ForEach(r =>
                {
                    r.ParentId = 0;
                });
                result.Remove(result.FirstOrDefault(d => d.Id == id));
                success = true;
            }
            catch
            {
                success = false;
            }
            return new { Successful = success };
        }
    }
}
