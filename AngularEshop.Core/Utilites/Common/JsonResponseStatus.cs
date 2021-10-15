using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularEshop.Core.Utilites.Common
{
    public static class JsonResponseStatus
    {
        public static JsonResult Success()
        {
            return new JsonResult(new {status = "Success"});
        }


        public static JsonResult Success(Object returnData)
        {
            return new JsonResult(new { status = "Success" ,data=returnData});
        }


        public static JsonResult NotFount()
        {
            return new JsonResult(new { status = "NotFount" });
        }


        public static JsonResult NotFount(Object returnData)
        {
            return new JsonResult(new { status = "NotFount", data = returnData });
        }


        public static JsonResult Error()
        {
            return new JsonResult(new { status = "Error" });
        }


        public static JsonResult Error(Object returnData)
        {
            return new JsonResult(new { status = "Error", data = returnData });
        }
    }
}
