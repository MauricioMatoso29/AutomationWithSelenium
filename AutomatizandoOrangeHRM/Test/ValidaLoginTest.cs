using AutomatizandoOrangeHRM.Page;

namespace AutomatizandoOrangeHRM.Test
{
    class ValidaLoginTest : ValidaLoginPage
    {
        [Test]
        public void ValidaLogin()
        {
            //Arrange
            PreencheUser("Admin");
            PreencheSenha("admin123");
            //Act
            ClicaBtnLogin();
            //Assert
            ValidaPaginaInicial();
        }

        [Test]
        public void ValidaLogout()
        {
            //Arrange
            PreencheUser("Admin");
            PreencheSenha("admin123");
            ClicaBtnLogin();
            ClicaBtnPerfil();
            //Act
            Espere(2000);
            ClicaBtnLogout();
            //Arrange
            ValidaPaginaLogin();
        }
    }
}
