using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Interfaces
{
    internal interface IConstantLoginSystem
    {
        internal const string DEFAULT_PROGRAM_NAME = "Sistema de Login",
                              DEFAULT_ERROR_NAME_OR_EMAIL_EMPTY = "Insira o nome ou o e-mail",
                              DEFAULT_ERROR_PASSWORD_EMPTY = "Insira a senha",
                              DEFAULT_ERROR_CONFIRM_PASSWORD_EMPTY = "Confirme a senha",
                              DEFAULT_ERROR_PASSWORD_DIFFERENT = "As senhas não correspondem",
                              DEFAULT_LOGIN_REALIZED = "Login realizado",
                              DEFAULT_REGISTER_REALIZED = "Cadastro realizado",
                              DEFAULT_ERROR_USER_NOT_FOUND = "Usuário não encontrado",
                              DEFAULT_USER_REGISTERED = "Usuário já cadastrado";                                    
    }
}
