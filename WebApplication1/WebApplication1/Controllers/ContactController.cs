﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;


namespace WebApplication1.Controllers
{
    public class ContactController : ApiController
    {
        // GET: Contact
        
        public string[] Get()
        {
            return new string[]
            {
            "Hello",
            "World"
            };
        }
    }
}