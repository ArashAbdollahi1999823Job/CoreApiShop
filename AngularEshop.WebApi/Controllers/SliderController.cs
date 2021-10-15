using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularEshop.Core.Services.Interfaces;
using AngularEshop.Core.Utilites.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AngularEshop.WebApi.Controllers
{
    public class SliderController : SiteBaseController
    {

        #region ctor
        private ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        #endregion

        #region ActiveAliders

        
        [HttpGet("GetActiveSlider")]
        public async Task<JsonResult> GetActiveSlider()
        {
            var Sliders = await _sliderService.GetActiveSliders();
            return JsonResponseStatus.Success(Sliders);
        }
        #endregion

    }

}
