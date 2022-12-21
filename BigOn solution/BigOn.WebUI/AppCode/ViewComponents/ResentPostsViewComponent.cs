using BigOn.Domain.Business.BlogPostModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BigOn.WebUI.AppCode.ViewComponents
{
    public class ResentPostsViewComponent:ViewComponent
    {
        private readonly IMediator mediator;

        public ResentPostsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task <IViewComponentResult> InvokeAsync()
        {
            var query = new BlogPostRecentQuery() { Size = 4 };
            var posts = await mediator.Send(query);
            return View(posts);
        }
    }
}
