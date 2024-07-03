using System.Text;
using System;

namespace PasswordBuilder.Management
{
    public class PasswordBuilderManagement
    {
        public string PasswordBuilder()
        {
            string character = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            byte length = 16;

            Random random = new Random();
            StringBuilder builder = new StringBuilder();
            builder.Append(character[random.Next(0, 25)]);
            builder.Append(character[random.Next(26, 51)]);
            builder.Append(character[random.Next(52, 61)]);
            
            for (int i = 0; i < (length - 3); i++)
                builder.Append(character[random.Next(0, 61)]);

            return builder.ToString();
        }
    }
}