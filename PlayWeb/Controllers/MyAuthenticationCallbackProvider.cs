﻿using PlayWeb.DAL;
using PlayWeb.Models.Login;
using SimpleAuthentication.Mvc;
using System.Web;
using System.Web.Mvc;

namespace PlayWeb.Controllers
{
	public class AuthCallbackProvider : IAuthenticationCallbackProvider
	{
		// Returned when successful login authentication is completed.
		public ActionResult Process(HttpContextBase context, AuthenticateCallbackData model)
		{

			// Generate a new user if they haven't logged in before
			var user = new User
			{
				DisplayName = model.AuthenticatedClient.UserInformation.Name,
				ImageUrl = model.AuthenticatedClient.UserInformation.Picture,
				Email = new Email { Email1 = model.AuthenticatedClient.UserInformation.Email }
			};
			user = UserDAL.GetOrCreateUser(user);

			// And dump it into the context so we know who we're talking about.
			if (context.Session != null) context.Session["User"] = user;

			return new RedirectResult("~/");
		}

		public ActionResult OnRedirectToAuthenticationProviderError(HttpContextBase context, string errorMessage)
		{
			return new ViewResult
			{
				ViewName = "LoginError",
				ViewData = new ViewDataDictionary(new AuthenticationProviderError
				{
					ErrorMessage = errorMessage
				})
			};
		}
	}
}