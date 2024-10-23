using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Servisleri konteynere ekleyin
builder.Services.AddControllersWithViews(config =>
{
	// Authenticated kullan�c�lar� gerektiren bir kimlik do�rulama politikas� olu�turun
	var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

	// Olu�turulan politikay� kullanarak bir authorize filtresi ekleyin
	config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.LoginPath = "/Login/Index";
		options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Secure �zniteli�i
	});

var app = builder.Build();

// HTTP istek pipeline'�n� yap�land�r�n
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Kimlik do�rulama kullan�m� eklendi
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Category}/{action=Index}/{id?}");

app.Run();
