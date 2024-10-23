using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Servisleri konteynere ekleyin
builder.Services.AddControllersWithViews(config =>
{
	// Authenticated kullanýcýlarý gerektiren bir kimlik doðrulama politikasý oluþturun
	var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

	// Oluþturulan politikayý kullanarak bir authorize filtresi ekleyin
	config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.LoginPath = "/Login/Index";
		options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Secure özniteliði
	});

var app = builder.Build();

// HTTP istek pipeline'ýný yapýlandýrýn
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Kimlik doðrulama kullanýmý eklendi
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Category}/{action=Index}/{id?}");

app.Run();
