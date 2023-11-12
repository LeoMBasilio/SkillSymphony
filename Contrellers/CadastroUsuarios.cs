using SkilsSymphony.Model;
using System.Collections.Generic;

namespace SkilsSymphony.Contrellers
{
    public class CadastroUsuarios
    {
        private static List<Usuarios> usuarios = new List<Usuarios>();
        private static int id = 0;

        public static void Cadastrar(Usuarios usuario)//ao passar o usuario passar o objeto completo
        {
            usuario.Id = id++;
            usuarios.Add(usuario);
        }

        public static void Editar(Usuarios usuario)
        {
            Usuarios u = usuarios.Find(x => x.Id == usuario.Id);
            u.Nome = usuario.Nome;
            u.Senha = usuario.Senha;
            u.Email = usuario.Email;
            u.Idade = usuario.Idade;
            u.Curso = usuario.Curso;
        }

        public static void Excluir(Usuarios usuario)
        {
            usuarios.Remove(usuario);
        }

    }
}
