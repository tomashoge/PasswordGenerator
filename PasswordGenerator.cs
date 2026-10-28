using System.Text;

class PasswordGenerator
{
    private static Random random = new Random();

    /// <summary>
    /// Generates the alphanumeric password.
    /// </summary>
    /// <param name="length">The length.</param>
    /// <returns>new password</returns>
    public string GenerateAlphanumericPassword(int length = 40)
    {
        const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";

        string validCharacters = lowercase + uppercase + digits;
        return GeneratePassword(length, validCharacters);
    }

    /// <summary>
    /// Generates the password.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <param name="validCharacters">The valid characters.</param>
    /// <returns>new password</returns>
    public string GeneratePassword(int size, string validCharacters)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            char ch = validCharacters[random.Next(validCharacters.Length)];
            builder.Append(ch);
        }

        return builder.ToString();
    }
}