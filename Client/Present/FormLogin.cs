using Client.Data.Service;
using Client.UseCases;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Client.Present
{
    public partial class FormLogin : MaterialForm
    {
       UserUseCases login = new UserCases_Impl();
        Dictionary<string, Color> colors = new Dictionary<string, Color>()
            {
                { "dark", Color.FromArgb(51, 54, 41) },
                { "dark-low", Color.FromArgb(75, 79, 62) },
                { "medium", Color.FromArgb(129, 135, 109) },
                { "light", Color.FromArgb(181, 187, 164)},
                { "very-light", Color.FromArgb(226, 230, 215) },
            };
        public FormLogin()
        {
            InitMaterialSkin();
            InitializeComponent();
        }
        private void InitMaterialSkin()
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
               colors["dark-low"], colors["dark"], colors["light"], colors["medium"], TextShade.WHITE
            );
        }

        private void materialLabelSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            signUp.Show();
        }

        private async void materialButtonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var info = await login.LogIn(materialTextBoxLogin.Text, materialTextBoxPassword.Text);
                Shop user = new Shop(info);
                user.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("Логин или пароль введены неверно", "Ошибка авторизации");
            }
        }
    }
}
