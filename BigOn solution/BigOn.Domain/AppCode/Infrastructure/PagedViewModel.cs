﻿//using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;

namespace BigOn.Domain.AppCode.Infrastructure
{
    public class PagedViewModel<T>
        where T : IPageable
    {

        const int maxPaginationButtonCount = 10;

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int MaxPageSize
        {
            get
            {
                double count = Math.Ceiling(this.TotalCount * 1D / this.PageSize);

                return (int)count;
            }
        }

        public IEnumerable<T> Items { get; set; }

        public PagedViewModel(IQueryable<T> query, PaginateModel model)
        {
            this.TotalCount = query.Count();

            if (this.MaxPageSize<model.PageIndex)
            {
                this.PageIndex = this.MaxPageSize;
            }
            else
            {
                this.PageIndex = model.PageIndex;
            }
            this.PageSize = model.PageSize;

            this.Items = query
                .Skip((this.PageIndex - 1) * this.PageSize)
                .Take(this.PageSize)
                .ToList(); ;
        }

        //public IHtmlContent GetPager(IUrlHelper urlHelper)
        //{
        //    /*  <ul class='blog-pagination ptb-20'>

        //            <li><a href='#'><i class='fa fa-angle-right'></i></a></li>

        //            @for(int i =1; i<= Model.MaxPageSize; i++)
        //            {
        //                <li class='@(i==Model.PageIndex?'active':'')'>
        //                    <a asp-route-pageIndex='@i' asp-route-pageSize='@Model.PageSize'>@i</a></li>
        //            }

        //            <li><a href='#'><i class='fa fa-angle-right'></i></a></li>
        //        </ul>*/

        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("<ul class='blog-pagination ptb-20'>");
        //    for (int i = 1; i <= this.MaxPageSize; i++)
        //    {
        //        string link = urlHelper.Action("index", values: new
        //        {
        //            PageIndex = i,
        //            PageSize = this.PageSize
        //        });
        //        sb.Append(@$"<li class='{((i==this.PageIndex?"active":""))}'>
        //                    <a href='{link}' >{i}</a></li>");

        //    }
        //    sb.Append("</ul>");
        //    return new HtmlString(sb.ToString());
        //}

        public HtmlString GetPager(IUrlHelper urlHelper, string action, string area = "", string paginateFunction = "")
        {
            if (this.PageSize >= TotalCount)
                return HtmlString.Empty;


            StringBuilder builder = new StringBuilder();
            bool hasPaginationFunction = !string.IsNullOrWhiteSpace(paginateFunction);

            builder.Append("<ul class='blog-pagination ptb-20'>");

            if (this.PageIndex > 1)
            {
                var link = hasPaginationFunction
                    ? $"javascript:{paginateFunction}({this.PageIndex - 1},{this.PageSize})"
                    : urlHelper.Action(action, values: new
                    {
                        pageindex = this.PageIndex - 1,
                        pagesize = PageSize,
                        area
                    });

                builder.Append($@"<li class='prev'>
                                <a href='{link}'><i class='fa fa-angle-left'></i></a>
                                </li>");
            }
            else
            {
                builder.Append("<li class='prev disabled'><a><i class='fa fa-angle-left'></i></a></li>");
            }

            int min = 1, max = this.MaxPageSize;

            if (this.PageIndex > (int)Math.Floor(maxPaginationButtonCount / 2D))
            {
                min = this.PageIndex - (int)Math.Floor(maxPaginationButtonCount / 2D);
            }

            max = min + maxPaginationButtonCount - 1;

            if (max > this.MaxPageSize)
            {
                max = this.MaxPageSize;
                min = max - maxPaginationButtonCount + 1;
            }

            for (int i = (min < 1 ? 1 : min); i <= max; i++)
            {
                if (i == this.PageIndex)
                {
                    builder.Append($"<li class='active'><a>{i}</a></li>");
                    continue;
                }

                var link = hasPaginationFunction
                    ? $"javascript:{paginateFunction}({i},{PageSize})"
                    : urlHelper.Action(action, values: new
                    {
                        pageindex = i,
                        pagesize = PageSize,
                        area
                    });

                builder.Append($"<li><a href='{link}'>{i}</a></li>");

            }


            if (this.PageIndex < this.MaxPageSize)
            {
                var link = hasPaginationFunction
                    ? $"javascript:{paginateFunction}({this.PageIndex + 1},{this.PageSize})"
                    : urlHelper.Action(action, values: new
                    {
                        pageindex = this.PageIndex + 1,
                        pagesize = PageSize,
                        area
                    });

                builder.Append($@"<li class='next'>
                                <a href='{link}'><i class='fa fa-angle-right'></i></a>
                                </li>");
            }
            else
            {
                builder.Append("<li class='next disabled'><a><i class='fa fa-angle-right'></i></a></li>");
            }


            builder.Append("</ul>");

            return new HtmlString(builder.ToString());
        }
    }
}