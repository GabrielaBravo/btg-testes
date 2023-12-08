using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
    public class MediaIdadesTest
    {
        [Fact]
        public void CalcularMedia_ListIdadeMaiorQue18_RetornaMedia()
        {
            //Arrange
            MediaIdades idade = new();

            List<int> listaIdade = new() 
            {
                10,20,30
            };

            //Act
            decimal mediaidades = idade.CalculaMedia(listaIdade);

            //Assert
            Assert.Equal(25, mediaidades);


        }

        [Fact]
        public void CalcularMedia_IdadeMenor18_ListaMenor()
        {
            MediaIdades mediaidades = new();
            List<int> idadeMenor18 = new()
            {
                07, 12, 15, 05
            };

            Action retorno = () => mediaidades.CalculaMedia(idadeMenor18);

            Assert.Throws<DivideByZeroException>(retorno);
        }
    }
}
