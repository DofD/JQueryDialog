using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Entities
{
    public class DataBase
    {
        internal List<UserViewModel> Users { get; set; } = new List<UserViewModel> { new UserViewModel { UserID = 1, Name = "Пользователь 1", Address = "Москва" }, new UserViewModel { UserID = 1, Name = "Пользователь 1", Address = "Нижний новгород" } };
    }
}