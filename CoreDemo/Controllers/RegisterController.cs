﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IWriterService _writerService;

        private readonly WriterCity _writerCity;

        public RegisterController(IWriterService writerService, WriterCity writerCity)
        {
            _writerService = writerService;
            _writerCity = writerCity;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Cities = _writerCity.GetCityList();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer, string passwordAgain, IFormFile imageFile)
        {
            AddProfileImage addProfileImage = new AddProfileImage();
            var validateWriter = _writerService.TGetByFilter(x => x.WriterMail == writer.WriterMail);
            if (ModelState.IsValid && writer.WriterPassword == passwordAgain && validateWriter == null)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Deneme test";
                writer.WriterRegisterDate = DateTime.Now;
                writer.WriterImage = AddProfileImage.ImageAdd(imageFile);
                _writerService.TAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else if (writer.WriterPassword != passwordAgain)
            {
                ModelState.AddModelError("WriterPassword", "Girdiğiniz Şifreler Eşleşmedi Lütfen Tekrar Deneyin");
            }
            else if (validateWriter != null)
            {
                ModelState.AddModelError("ErrorMessage", "Girdiğiniz E-Mail Adresini Kullanan Bir Hesap Mevcut");
            }
            ViewBag.Cities = _writerCity.GetCityList();//dropdown hata vermemesi için Şehir Listesini tekrar gönderdim
            return View(writer);
        }

    }
}
