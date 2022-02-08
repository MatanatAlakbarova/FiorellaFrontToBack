using FiorellaFrontToBack.DateAccessLayer;
using FiorellaFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var sliderImages = _dbContext.SliderImages.ToList();
            var slider = _dbContext.Sliders.SingleOrDefault();
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.Include(x=> x.Category).Take(4).ToList();
            var aboutImage = _dbContext.AboutImages.SingleOrDefault();
            var aboutText = _dbContext.AboutTexts.SingleOrDefault();
            var expertContent = _dbContext.ExpertContents.SingleOrDefault();
            var experts = _dbContext.Experts.ToList();
            var devider = _dbContext.Deviders.SingleOrDefault();
            var blogContent = _dbContext.BlogContents.SingleOrDefault();
            var blogCards = _dbContext.BlogCards.ToList();
            var saycorousels = _dbContext.SayCarousels.ToList();
            var instagramImages = _dbContext.InstagramImages.ToList();

            return View(new HomeVM
            {
               Slider=slider,
               SliderImages=sliderImages,
               Categories=categories,
               Products=products,
               AboutImage=aboutImage,
               AboutText=aboutText,
               ExpertContent=expertContent,
               Experts=experts,
               Devider=devider,
               BlogCards=blogCards,
               BlogContent=blogContent,
               SayCarousels=saycorousels,
               InstagramImages=instagramImages

            });
        }
    }
}
