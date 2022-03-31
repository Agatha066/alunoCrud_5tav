using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3CrudAluno.ViewModel
{
    public class AlunoViewModel
    {
        public string Nome;
        public string Matricula;
		public string Curso;
		
		
		public string getNome() {
			return Nome;
		}
		public void setNome(string Nome) {
			this.Nome = Nome;
		}
		
		public string getMatricula() {
			return Matricula;
		}
		public void setMatricula(string Matricula) {
			this.Matricula = Matricula;
		}
		
		public string getCurso() {
			return Curso;
		}
		public void setCurso(string Curso) {
			this.Curso = Curso;
		}
    }
}
