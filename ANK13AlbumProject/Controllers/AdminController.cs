using ANK13AlbumProject.Context;
using ANK13AlbumProject.Entities;
using ANK13AlbumProject.Functions;
using Microsoft.AspNetCore.Mvc;

namespace ANK13AlbumProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly AlbumDbContext _db;

        public AdminController(AlbumDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()   //şifresi doğru girilen kullanıcının karşılanma sayfası için
        {
            return View();
        }

        public IActionResult Register()  //Burası kayıt ekranına gitmek için
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Admin admin)  
        {

            if (admin.Password != admin.PasswordConfirmation)
            {
                TempData["Hata"] = "Şifreler uyuşmamaktadır.";
                return View();
            }

            if (!Methods.PasswordControl(admin.Password))
            {
                TempData["Hata"] = "Şifreniz kriterlere uymamaktadır.";
                return View();
            }

           
            //herşey doğru ise KAYDET!!!!
            admin.Password=Methods.Sha256Hash(admin.Password);
            _db.Admins.Add(admin);
            _db.SaveChanges();
            TempData["Basari"] = "Yönetici başarıyla eklenmiştir";
            return RedirectToAction("Index","Home");
        }

        public IActionResult Login(Admin admin)
        {
            //Login kontrolleri burada yapılaca
            //Eğer db'de böyle bir kullanıcı yoksa veya şifresi yanlış ise hata ver
            if (_db.Admins.Find(admin.UserName) == null ||
               Methods.Sha256Hash(admin.Password) != _db.Admins.Find(admin.UserName).Password)
            {
                TempData["Hata"] = "Kullanıcı adı/şifresi hatalıdır";
                return RedirectToAction("Index", "Home");
            }
            else   //Girişe izin ver
                return View("Index", admin);
        }




    }
}
