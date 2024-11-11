using HermesChat.Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HermesChat.Web.Controllers
{
    public class ChatController : Controller
    {
        //private readonly HermesChatContext _context;

        //public ChatController(HermesChatContext context)
        //{
        //    _context = context;
        //}
        //[Authorize]
        //public async Task<IActionResult> Chat()
        //{
        //    var chats = await _context.Chat.ToListAsync();
        //    return View(chats);
        //}


    }
}
