using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    static class AddingUser
    {
        static public void addNewUser(User user, ref List<User> users, string filePath)
        {
            if (!userHaveInBase.userHaveInJSON(user.Name, ref users))
            {
                users.Add(user);
                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
                File.WriteAllText(filePath, json);

                MessageBox.Show("Аккаунт успешно создан.");
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже есть");
            }
        }
    }
}
