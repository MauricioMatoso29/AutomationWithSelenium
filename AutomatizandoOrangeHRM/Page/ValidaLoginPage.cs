using AutomatizandoOrangeHRM.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizandoOrangeHRM.Page
{
    class ValidaLoginPage : Begin
    {
        //Preenchendo campos
        public void PreencheUser(string username)
        {
            EscreveTexto("//*[@id=\'app\']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input", username, " o campo Username com " + username);
        }

        public void PreencheSenha(string password)
        {
            EscreveTexto("//*[@id=\'app\']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/div[2]/input", password, " o campo Password com " + password);
        }

        public void PreencheNomeUser(string username)
        {
            EscreveTexto("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/div/div/input", username, " o campo de busca com " + username);
        }
        public void PreencheFirstName(string username)
        {
            EscreveTexto("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[2]/div[1]/div[1]/div/div/div[2]/div[1]/div[2]/input", username, " o nome user com " + username);
        }
        public void PreencheMiddleName(string username)
        {
            EscreveTexto("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[2]/div[1]/div[1]/div/div/div[2]/div[2]/div[2]/input", username, " o nome do meio com " + username);
        }
        public void PreencheLastName(string username)
        {
            EscreveTexto("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[2]/input", username, " o nome final com " + username);
        }
        public void PreencheID()
        {
            EscreveTexto("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/input", "038521", " o id do user com 038912345");
        }

        //Clicando em butoes
        public void ClicaBtnLogin()
        {
            ClicaElemento("//*[@id=\'app\']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button");
        }
        public void ClicaBtnPerfil()
        {
            ClicaElemento("//*[@id=\'app\']/div[1]/div[1]/header/div[1]/div[2]/ul/li/span/p");
        }

        public void ClicaBtnLogout()
        {
            ClicaElemento("//*[@id=\'app\']/div[1]/div[1]/header/div[1]/div[2]/ul/li/ul/li[4]/a");
        }
        public void ClicaBtnTelaAdmin()
        {
            ClicaElemento("//*[@id=\'app\']/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a");
        }

        public void ClicaBtnBuscaUser()
        {
            ClicaElemento("//*[@id='app']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]");
        }

        public void ClicaBtnAddUser()
        {
            ClicaElemento("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div[2]/div[1]/button");
        }
        public void ClicaBtnSaveUser()
        {
            ClicaElemento("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[2]/button[2]");
        }

        //validando elementos
        public void ValidaPaginaInicial()
        {
            ValidaURL("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index", "Página Inicial");
        }
        public void ValidaPaginaLogin()
        {
            ValidaURL("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login", "Página Login");
        }
        public void ValidaPaginaDetailsUser()
        {
            ValidaURLContains("https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewPersonalDetails/empNumber/", "Página de Detalhes Pessoais");
        }

        public void ValidaUserGrid(string username)
        {
            ValidaDados("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[2]/div/div/div[3]/div", username, "Nome user");
        }

        public void SelecionaTipoTrabalho(string tipoTrab)
        {
            MenuDropDown("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]", tipoTrab, "tipo do Trabalho: " + tipoTrab);
        }

    }
}
