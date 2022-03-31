using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3CrudAluno
{
    public class Alunos
    {
		//Nao numerico
		public string ValidaNomeAluno(string Nome){ //nome, curso
			
			if ((Nome != '') && (Nome.value.length >=2) && (!isNaN(Nome)){
				return "ok";
			}
			else{
				return "erro";
			}
		}
		
		public string ValidaMatriculaAluno(string Matricula){ //matricula
			
			if((Matricula != '') || (isNaN(Matricula)))// string numerica
			{
				return "ok";
			}
			else{
				return "erro";
			}
		}
		
		public string ValidaCursoAluno(string Curso){ //matricula
			
			if(Curso != '')// string numerica
			{
				return "ok";
			}
			else{
				return "erro";
			}
		}
	
    }
}
