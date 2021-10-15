using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.Core.Services.Interfaces;
using AngularEshop.DataLayer.Entities.Site;
using AngularEshop.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace AngularEshop.Core.Services.Inplementation
{
    public class SliderService:ISliderService
    {


        #region ctor

        private IGenericRepository<Slider> _sliderRepository;

        public SliderService(IGenericRepository<Slider> slideRepository)
        {
            _sliderRepository = slideRepository;
        }

        #endregion



        #region DosPose

        

        public void Dispose()
        {
            _sliderRepository?.Dispose();
        }
        #endregion

         #region Slider
        public async Task<List<Slider>> GetAllSliders()
        {
          return  await _sliderRepository.GetEntitiesQuery().ToListAsync();
        }

        public async Task<List<Slider>> GetActiveSliders()
        {
            return await _sliderRepository.GetEntitiesQuery().Where(x => !x.IsDelete).ToListAsync();
        }

        public async Task AddSlider(Slider slider)
        {
            await _sliderRepository.AddEntity(slider);
            await _sliderRepository.SaveChange();
        }

        public  async  Task UpdateSlider(Slider slider)
        {
             _sliderRepository.UpdateEntity(slider);
            await _sliderRepository.SaveChange();
        }

        public async Task<Slider> GetSliderById(long sliderId)
        {
            return await _sliderRepository.GetEntityById(sliderId);
        }
        #endregion
    }
}
