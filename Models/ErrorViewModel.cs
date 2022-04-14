// <copyright file="ErrorViewModel.cs" company="stuffAndStuff">
// Copyright (c) stuffAndStuff. All rights reserved.
// </copyright>

namespace StyleCopExample.Models
{
    /// <summary>
    /// blah.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets blah.
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether blah.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
    }
}