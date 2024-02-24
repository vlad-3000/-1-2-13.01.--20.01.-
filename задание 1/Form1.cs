namespace задание_1;
using Npgsql;


public partial class Form1 : Form
{
    private string connectionString = "Host=localhost; Port=5432 ; Database=R7-571 ; Username=postgres; Password=780213;";

    public Form1()
    {
        InitializeComponent();
    }

    private bool UserExists(string username)
    {
        bool userExists = false;

     
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

           
            string sql = "SELECT COUNT(*) FROM логин_пароль WHERE логин = @login";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
              
                command.Parameters.AddWithValue("@login", username);

                
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    userExists = true;
                }
            }
        }

        return userExists;
    }
    private bool ValidatePassword(string password)
    {
        bool letters = false;
        bool numbers = false;
        bool signs = false;
        string symb1 = "ABCDEFGHIJKLMNOPRSTUVWXYZqwertyuiopasdfghjklzxcvbnm";
        string symb2 = "123456789";
        string symb = "@,!";
        foreach (char c in password)
        {

            if (symb1.Contains(c))
            {
                letters = true;
            }
            else if (symb2.Contains(c))
            {
                numbers = true;
            }
            else if (symb.Contains(c))
            {
                signs = true;
            }
        }

        return letters && numbers && signs;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void registrationButton_Click(object sender, EventArgs e)
    {
        string username = loginBox.Text;
        string password = passBox.Text;
        
        if (UserExists(username))
        {
            MessageBox.Show("Пользователь с таким именем уже существует!");
            return;
        }
        else if (username.Length < 4)
        {
            MessageBox.Show("логин слишком короткий");
            return;
        }


        if (password.Length < 8)
        {
            MessageBox.Show("пароль слишком короткий");
            return;
        }
        else if (!ValidatePassword(password))
        {
            MessageBox.Show("Пароль не соответствует требованиям! пароль должен содержать буквы, цифры и символы (@,!)");
            return;
        }
        

       
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

          
            string sql = "INSERT INTO логин_пароль (логин, пароль) VALUES (@login, @pass)";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
               
                command.Parameters.AddWithValue("@login", username);
                command.Parameters.AddWithValue("@pass", password);

               
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Регистрация успешно завершена!");
                    loginBox.Clear();
                    passBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации!");
                }
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        string username = loginBox.Text;
        string password = passBox.Text;

        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            
            string sql1 = "SELECT COUNT(*) FROM логин_пароль WHERE логин = @login AND пароль = @pass";

            using (NpgsqlCommand command = new NpgsqlCommand(sql1, connection))
            {
             
                command.Parameters.AddWithValue("@login", username);
                command.Parameters.AddWithValue("@pass", password);

                
                int rowsAffected = Convert.ToInt32(command.ExecuteScalar());
               

                if (rowsAffected > 0)
                {
                    MessageBox.Show("успешный вход");

                }
                else
                {
                    MessageBox.Show("Ошибка входа");
                }
            }

        }
    }
    

   

}

