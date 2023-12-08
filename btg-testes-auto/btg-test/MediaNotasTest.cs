using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
    public  class MediaNotasTest
    {
        [Fact]
        public void CalcularMedia_NOtassuperiorA7_RetornaAprovado()
        {
            //Arrange
            List<decimal> notas = new()
            {
                7, 8, 9, 7
            };
            MediaNotas mediaNotas = new();

            //Act
            string resultado = mediaNotas.CalculaMedia(notas, null);

            //Assert
            Assert.Contains("Parabéns, você foi aprovado!", resultado);
            Assert.Contains("7,75", resultado);

        }

        [Fact]
        public void CalcularMedia_NotaInferiorA7_RetornaRecuperacao()
        {
            //Arrange
            List<decimal> notas = new()
            {
                7, 5, 9, 7
            };
            MediaNotas mediaNotas = new();
            decimal notaRecuperacao = 7;

            //Act
            string resultado = mediaNotas.CalculaMedia(notas, null);

            //Assert
            Assert.Contains("Parabéns, você foi aprovado na recuperação!", resultado);
            Assert.Contains("7,37", resultado);
        }

        [Fact]
        public void CalcularMedia_NotaInferiorA7ComRecuperacaoInsuficiente_RetornaRecuperacao()
        {
            //Arrange
            List<decimal> notas = new()
            {
                7, 5, 8, 7
            };
            MediaNotas mediaNotas = new();
            decimal notaRecuperacao = 5;

            //Act
            string resultado = mediaNotas.CalculaMedia(notas, null);

            //Assert
            Assert.Equal($"infelizmente você não foi aprovado na recuperação!{media}");
           
        }

        [Fact]
        public void CalcularMedia_NotaInferiorA7Semrecuperacao_RetornaRecuperacao()
        {
            //Arrange
            List<decimal> notas = new()
            {
                7, 5, 8, 7
            };
            MediaNotas mediaNotas = new();
           

            //Act
            string resultado = mediaNotas.CalculaMedia(notas, null);

            //Assert
            Assert.Equal("infelizmente você não foi aprovado na recuperação!", resultado);
            
        }
    }
}
