using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApp.Models
{
    [Table("Users")]
    public class Users : Common
    {
        //--- transcational variable ----
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? MobileNo { get; set; }
        public int UserRoleId { get; set; }
        public int LoginAttempt { get; set; }
        public bool IsEnable { get; set; }

 






    }
}

//create table Users(
//--- transcational variable ----
//Id int primary key identity(1,1),
//FirstName  nvarchar(100) not null,
//MiddleName nvarchar(100) not null,
//LastName   nvarchar(100) not null,
//UserName   nvarchar(100) not null,
//PassWord   nvarchar(100) not null,
//MobileNo   nvarchar(15) not null,
//Email      nvarchar(100) not null,
//Address    nvarchar(200) not null,
//UserRoleId int ,
//LoginAttempt int not null,
//IsEnable bit not null,
//----- Audit variable -------------
//IsActive bit not null,
//CreatedBy int not null,
//CreatedDate datetime not null,
//UpdatedBy int ,
//UpdatedDate datetime 
//)