using Microsoft.AspNetCore.Identity;

namespace Traversal.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola minimum {length} karakterli olmalıdır!"
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = $"Parola minimum bir büyük karakterli olmalıdır ('A'-'Z')!"
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Parola minimum bir küçük karakterli olmalıdır ('a'-'z')!"
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Parola minimum bir sembol karakterli olmalıdır ('*'-'+')!"
			};
		}
	}
}
