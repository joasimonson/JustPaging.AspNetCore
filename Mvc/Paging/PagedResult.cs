﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.Paging
{
    /// <summary>
    /// Generic class of paged results.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedResult<T> where T : class
    {
        /// <summary>Gets or sets the collection.</summary>
        public T[] Collection { get; set; }
        /// <summary>Gets or sets the pagination information.</summary>
        public PagingInfo Pagination { get; set; }
    }


    /// <summary>
    /// Non-generic class of paged results.
    /// </summary>
    public class PagedResult
    {
        /// <summary>Gets or sets the collection.</summary>
        public object Collection { get; set; }
        /// <summary>Gets or sets the pagination information.</summary>
        public PagingInfo Pagination { get; set; }
    }
}
