using Go_Blogs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Go_Blogs.Controllers
{
    public class MobilController : Controller
    {
        public IActionResult Index()
        {
            //var mobils = new List<Mobil>();

            //mobils.Add(new Mobil
            //{
            //    IdRegistrasi = 1,
            //    Tipe = "Sedan",
            //    Merk = "Toyota",
            //    Varian = "TF86"
            //});

            //mobils.Add(new Mobil
            //{
            //    IdRegistrasi = 2,
            //    Tipe = "SUV",
            //    Merk = "",
            //    Varian = "Naga"
            //});

            string nama = "Yoga";
            ViewBag.namaSaya = nama;
            //ViewBag.mobilnya = mobils;
            var banyakMobil = new Mobil[]
            {
                new Mobil{IdRegistrasi = 1, Tipe="Sedan", Merk = "Toyota", Varian = "FT86"},
                new Mobil{IdRegistrasi = 2, Tipe="SUV", Merk = "Honda", Varian = "RAV4"},
                new Mobil{IdRegistrasi = 3, Tipe="Sedan", Merk = "BMW", Varian = "Accord"},
                new Mobil{IdRegistrasi = 4, Tipe="SUV", Merk = "Toyota", Varian = "CRV"},
                new Mobil{IdRegistrasi = 5, Tipe="Sedan", Merk = "Lambo", Varian = "City"},
            };

            return View(banyakMobil);
        }
    }
}
