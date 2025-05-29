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
        public AddingUser(User user, string filePath, ref List<User> users)
        {
            if (!userHaveInJSON(user.Name, users))
            {
                string jsonStrUser = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });

                users.Add(user);
                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                MessageBox.Show("Вы зарегистрировались");
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже есть");
            }
        }

        private bool userHaveInJSON(string usernameInput, List<User> users)
        {
            foreach (User user in users)
            {
                if (usernameInput == user.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
