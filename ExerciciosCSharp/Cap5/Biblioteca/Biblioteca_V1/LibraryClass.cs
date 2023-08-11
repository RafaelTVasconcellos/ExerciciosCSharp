using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace que irá conter a classe de controle de livros e seus métodos
namespace Libraryclass
{
    //Principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Autor; //recebe o nome do autor do Livro
        private string _Titulo; //recebe o titulo do livro
        private int _Paginas; //recebe o número de páginas que o Livro contém
        private bool _Status; //recebe saindo (FALSE) ou entrando(TRUE) na biblioteca

        public Biblioteca() //Construtor sem parametros
        {
        }
        //Construtor com parametros
        public Biblioteca(string Autor, string Titulo, int Paginas, bool Status)
        {
            _Autor = Autor;
            _Titulo = Titulo;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Autor //Metodo para acesso a propriedade Autor da classe
        {
            get { return _Autor; }
            set { _Autor = value; }
        }
        public string Titulo //Metodo para acesso a propriedade Titulo da classe
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }
        public int Paginas //Metodo para acesso a propriedade Páginas da classe
        {
            get { return _Paginas; }
            set { _Paginas = value; }
        }
        public bool Status //Metodo para acesso a propriedade Status da classe
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}