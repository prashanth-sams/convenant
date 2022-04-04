// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CovenantUser
    {
        /// <summary>
        /// Initializes a new instance of the CovenantUser class.
        /// </summary>
        public CovenantUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CovenantUser class.
        /// </summary>
        public CovenantUser(int? themeId = default(int?), Theme theme = default(Theme), string id = default(string), string userName = default(string), string normalizedUserName = default(string), string email = default(string), string normalizedEmail = default(string), bool? emailConfirmed = default(bool?), string passwordHash = default(string), string securityStamp = default(string), string concurrencyStamp = default(string), string phoneNumber = default(string), bool? phoneNumberConfirmed = default(bool?), bool? twoFactorEnabled = default(bool?), System.DateTime? lockoutEnd = default(System.DateTime?), bool? lockoutEnabled = default(bool?), int? accessFailedCount = default(int?))
        {
            ThemeId = themeId;
            Theme = theme;
            Id = id;
            UserName = userName;
            NormalizedUserName = normalizedUserName;
            Email = email;
            NormalizedEmail = normalizedEmail;
            EmailConfirmed = emailConfirmed;
            PasswordHash = passwordHash;
            SecurityStamp = securityStamp;
            ConcurrencyStamp = concurrencyStamp;
            PhoneNumber = phoneNumber;
            PhoneNumberConfirmed = phoneNumberConfirmed;
            TwoFactorEnabled = twoFactorEnabled;
            LockoutEnd = lockoutEnd;
            LockoutEnabled = lockoutEnabled;
            AccessFailedCount = accessFailedCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "themeId")]
        public int? ThemeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "theme")]
        public Theme Theme { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "normalizedUserName")]
        public string NormalizedUserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "normalizedEmail")]
        public string NormalizedEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailConfirmed")]
        public bool? EmailConfirmed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "passwordHash")]
        public string PasswordHash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "securityStamp")]
        public string SecurityStamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "concurrencyStamp")]
        public string ConcurrencyStamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumberConfirmed")]
        public bool? PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "twoFactorEnabled")]
        public bool? TwoFactorEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lockoutEnd")]
        public System.DateTime? LockoutEnd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lockoutEnabled")]
        public bool? LockoutEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessFailedCount")]
        public int? AccessFailedCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Theme != null)
            {
                Theme.Validate();
            }
        }
    }
}
