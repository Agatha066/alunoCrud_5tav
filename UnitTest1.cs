using System;
using Xunit;
using WebApplication2;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestValidaNomeAluno()
        {
            // Arrange
            Aluno al = new Aluno();

            // Act
            var result = al.ValidaNomeAluno("agatha");
            int esperado = "ok";

            // Assert
            Assert.Equal(esperado, result);
        }
		
		public void TestValidaMatriculaAluno()
        {
            // Arrange
            Aluno al = new Aluno();

            // Act
            var result = al.ValidaNomeAluno("1820478300083");
            int esperado = "ok";

            // Assert
            Assert.Equal(esperado, result);
        }
		
		public void TestValidaCursoAluno()
        {
            // Arrange
            Aluno al = new Aluno();

            // Act
            var result = al.ValidaNomeAluno("analise e desenvolvimento de sistema");
            int esperado = "ok";

            // Assert
            Assert.Equal(esperado, result);
        }

        
    }
}
