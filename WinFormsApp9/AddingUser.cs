using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp9
{
    internal class AddingUser
    {
        public AddingUser(User user, ref List<User> users, string filePath)
        { 
            if (checkLogin.loginIsHave(user.Name) && checkPassword.passwordIsLength(user.Password))
            {
                if (!userHaveInBase.userHaveInJSON(user.Name, ref users))
                {
                    string jsonStrUser = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });

                    users.Add(user);
                    string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Успешно");
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже есть");
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль не подходят по длине");
            }
        }
    }
}
