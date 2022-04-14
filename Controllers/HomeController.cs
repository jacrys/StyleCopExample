// <copyright file="HomeController.cs" company="stuffAndStuff">
// Copyright (c) stuffAndStuff. All rights reserved.
// </copyright>

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StyleCopExample.Models;

namespace StyleCopExample.Controllers
{
    /// <summary>
    /// blah.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">A logger.</param>
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// blah.
        /// </summary>
        /// <returns>A View.</returns>
        public IActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// blah.
        /// </summary>
        /// <returns>A View.</returns>
        public IActionResult Privacy()
        {
            return this.View();
        }

        /// <summary>
        /// blah.
        /// </summary>
        /// <returns>A View.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}