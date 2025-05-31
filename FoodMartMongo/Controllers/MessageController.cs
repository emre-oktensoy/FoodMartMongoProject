using FoodMartMongo.Services.EmailService;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
    public class MessageController : Controller
    {
        private readonly IEmailService _emailService;

        public MessageController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendDiscountCode(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                TempData["Message"] = "E-posta adresi giriniz.";
                return RedirectToAction("Index");
            }

            await _emailService.SendEmailAsync(
                email,
                "İndirim Kodu",
                "Teşekkürler %10 indirim kodunuz: ABC123"
            );

            TempData["Message"] = "E-posta başarıyla gönderildi!";
            return RedirectToAction("Index", "Default");
        }

    }
}
