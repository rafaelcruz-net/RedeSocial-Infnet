﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Services.Account;

namespace RedeSocial.Web.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService AccountService { get; set; }

        public AccountController(IAccountService accountService)
        {
            this.AccountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}