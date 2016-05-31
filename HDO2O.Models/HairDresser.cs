using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HDO2O.Models
{
    public class HairDresser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<HairDresser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        /// <summary>
        /// 昵称
        /// </summary>
        [StringLength(10)]
        public string NickName { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        [StringLength(50)]
        public string Sign { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? BirthDay { get; set; }
        ///// <summary>
        ///// 年龄，不生成数据库字段，根据BirthDay计算
        ///// </summary>
        //[NotMapped]
        //public int? Age { get; set; }

        public virtual ICollection<BarbershopHairDresser> BarberShops { get; set; }
        public virtual ICollection<Follower> Followers { get; set; }
        public virtual ICollection<MyHairDressLibrary> MyHairDressLibraries { get; set; }
    }
}
