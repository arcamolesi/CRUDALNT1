using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


public class AccountController : Controller
{
    private readonly SignInManager<IdentityUser> _signInManager;

    public AccountController(SignInManager<IdentityUser> signInManager)
    {
        _signInManager = signInManager;
    }

    // A rota "/sair" será mapeada para essa ação
    [HttpGet("/sair")]
    public async Task<IActionResult> LogoutDireto()
    {
        // Desloga o usuário imediatamente
        await _signInManager.SignOutAsync();
        
        // Redireciona para a página inicial
        return RedirectToAction("Index", "Home");
    }
}