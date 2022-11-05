using Microsoft.VisualStudio.TestTools.UnitTesting;
using VentasBarrio;

namespace VentasBarrioTest
{

    [TestClass]
  
    public class VentasdeBarrioTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int[] pedidosPrueba = new int[] { 0, 1, 2, 3, 4 };




            //act

            Pedido[] arreglosPedidos = new Pedido[5] ;
             string[] arreglosBarrios = new string[5] ;

          int[] actual = Program.TotalizaGalletasBarrio(pedidosPrueba, arreglosPedidos, arreglosBarrios);

            int[] galletasEsperadas = new int[] { 10, 10, 10, 10, 10 };

            //assert

            Assert.AreEqual(galletasEsperadas, actual);

        }
    }
}
