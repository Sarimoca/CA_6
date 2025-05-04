using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusquedaAlgoritmos;

namespace BusquedaAlgoritmos.Tests
{
    [TestClass]
    public class BusquedasTests
    {
        private readonly int[] _arregloDesordenado = { 5, 3, 8, 6, 2, 7, 1, 4, 9 };
        private readonly int[] _arregloOrdenado = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        [TestMethod]
        public void Lineal_ElementoExistente_DevuelveIndiceCorrecto()
        {
            int resultado = Busquedas.BusquedaLineal(_arregloDesordenado, 7);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Lineal_ElementoNoExistente_DevuelveMenosUno()
        {
            int resultado = Busquedas.BusquedaLineal(_arregloDesordenado, 10);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Binaria_ElementoExistente_DevuelveIndiceCorrecto()
        {
            int resultado = Busquedas.BusquedaBinaria(_arregloOrdenado, 7);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void Binaria_ElementoNoExistente_DevuelveMenosUno()
        {
            int resultado = Busquedas.BusquedaBinaria(_arregloOrdenado, 10);
            Assert.AreEqual(-1, resultado);
        }
    }
}
