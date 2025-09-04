using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Domain.DTO
{
	public class UserDto
	{
		public long UserId { get; set; }
		public int UserTypeId { get; set; }
		public string? UserTypeName { get; set; }
		public string? FullName { get; set; }
		public string? email { get; set; }
		public string? ProfilePicture { get; set; }
		public string? MobileNo { get; set; }
		public string? Username { get; set; }
		public string? Password { get; set; }
		public bool IsActive { get; set; }
		public bool IsTwoFactor { get; set; }
		public bool? IsApprove { get; set; }
		public bool? IsEmailVerified { get; set; }
		public bool? IsMobileVerified { get; set; }
		public bool? IsLocked { get; set; }
		public string? TwoFactorSecret { get; set; }
		public string? RecoveryCodes { get; set; }
	}
}
