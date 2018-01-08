using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using static Homework1.DAL.HomeworkDAL;
using Homework1.Models;
using System.Web.Script.Services;

namespace Homework3_WebApplication
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void getStudents()
        {
            var result = StudentDAL.getAllStudents();
            Context.Response.Output.Write(JsonConvert.SerializeObject(result));
            
            return;
        }
    }
}
