using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
   
    public class LucroTest
    {
        [Fact]
        public void Calcular_ValorProduto_RetornaPercentualAplicado()
        {
            //Arrange
            Lucro lucro = new();
            decimal valorProduto45 = 15;

            //Act
            decimal resultado45 = lucro.Calcular(valorProduto45);

            //Assert
            decimal esperado45 = 15 * 1.45M;
            Assert.Equal(esperado45, resultado45);

            //Arrange
            decimal valorProduto30 = 25;

            //Act
            decimal resultado30 = lucro.Calcular(valorProduto30);

            //Assert
            decimal esperado30 = 25 * 1.30M;
            Assert.Equal(esperado30, resultado30);

        }
        

    }
}
