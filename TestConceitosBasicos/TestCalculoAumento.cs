using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceitosBasicos.uteis;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace TestConceitosBasicos
{
    [TestClass]
    public class TestCalculoAumento
    {
       [TestMethod]
        public void TestAumento()
    {
        //cenário
        decimal salario = 1000;
        float percentual = 50;
        decimal resultado;
        CalculaAumento calculaAumento = new CalculaAumento();

        //ação
        resultado = calculaAumento.Calcular(salario, percentual);

         //verificação
         Assert.AreEqual(5400, resultado);
         
        }
    }
}

