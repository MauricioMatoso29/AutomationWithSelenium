using AutomatizandoOrangeHRM.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizandoOrangeHRM.Test
{
    class ValidaTelaAdmin : ValidaLoginPage
    {
        [Test]
        public void BuscaUser()
        {
            //Arrange
            PreencheUser("Admin");
            PreencheSenha("admin123");
            ClicaBtnLogin();
            ClicaBtnTelaAdmin();
            //Act
            PreencheNomeUser("Juan Carlos");
            ClicaBtnBuscaUser();
            Espere(2000);
            //Assert
            ValidaUserGrid("Juan Carlos");
        }

        [Test]
        public void AdicionaUser()
        {
            //Arrange
            PreencheUser("Admin");
            PreencheSenha("admin123");
            ClicaBtnLogin();
            ClicaBtnTelaAdmin();
            ClicaBtnAddUser();
            //Act
            PreencheFirstName("Carlos");
            PreencheMiddleName("Matias");
            PreencheLastName("Segundo");
            PreencheID();
            ClicaBtnSaveUser();
            Espere(10000);
            //Assert
            ValidaPaginaDetailsUser();

        }

        [Test]
        public void BuscaUserComMenuDropDown()
        {
            //Arrange
            PreencheUser("Admin");
            PreencheSenha("admin123");
            ClicaBtnLogin();
            ClicaBtnTelaAdmin();
            //Act
            PreencheNomeUser("Carlos Matias");
            SelecionaTipoTrabalho("Freelance");//utilizacao de menu Dropdown como filtro tambem
            ClicaBtnBuscaUser();
            Espere(2000);
            //Assert
            ValidaUserGrid("Carlos Matias");
        }
    }
}
