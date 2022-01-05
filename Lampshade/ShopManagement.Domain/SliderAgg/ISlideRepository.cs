using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contarcts.Slide;

namespace ShopManagement.Domain.SliderAgg
{
    public interface ISlideRepository:IRepository<long,Slide>
    {
        EditSlide GetDetail(long id);
        List<SlideViewModel> GetList();

    }
}
