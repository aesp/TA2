using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TA2_Evolucion;
using NUnit.Framework;

namespace NUnitTestProject
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void TestSumar()
        {
            TestClass objeto = new TestClass();
            Assert.AreEqual(7, objeto.Sumar(3, 4));
        }

        [Test]
        public void TestMayorA10()
        {
            TestClass objeto = new TestClass();
            Assert.AreEqual("Mayor", objeto.MayorA10(15));
        }

        [Test]
        public void TestRestar()
        {
            TestClass objeto = new TestClass();
            Assert.AreNotEqual(4, objeto.Restar(8, 2));
        }

        [Test]
        public void TestGetLetra()
        {
            TestClass objeto = new TestClass();
            Assert.AreNotEqual("Per", objeto.SepararCadena("Perro", 2));
        }

        [Test]
        public void TestGetDato()
        {
            TestClass objeto = new TestClass();
            Assert.IsNull(objeto.BuscarDato("canario"));
        }

        [Test]
        public void TestNumeroEncontrado()
        {
            TestClass objeto = new TestClass();
            Assert.IsTrue(objeto.NumeroEncontrado(8));
        }

        [Test]
        public void TestGetLista()
        {
            TestClass objeto = new TestClass();
            List<double> lista = new List<double>();
            lista.Add(15.5);
            lista.Add(20.3);
            lista.Add(30.3);

            CollectionAssert.AreEqual(lista, objeto.GetLista());
        }

        [Test]
        public void TestGetListaNombres()
        {
            TestClass objeto = new TestClass();
            List<string> lista = new List<string>();
            lista.Add("lapicero");
            lista.Add("borrador");
            lista.Add("tinta");

            List<string> actual = objeto.GetListaNombres();

            CollectionAssert.AreEqual(lista, actual);
        }

        [Test]
        public void TestBuscarProductoPorCodigo()
        {
            TestClass objeto = new TestClass();
            Producto esperado = new Producto();
            esperado.Codigo = 1; esperado.Nombre = "Lapicero"; esperado.Descripcion = "Pilot"; esperado.Precio = 3.5;

            Producto actual = objeto.BuscarProductoPorCodigo(1);

            Assert.AreEqual(esperado.Codigo, actual.Codigo);
            Assert.AreEqual(esperado.Nombre, actual.Nombre);
            Assert.AreEqual(esperado.Descripcion, actual.Descripcion);
            Assert.AreEqual(esperado.Precio, actual.Precio);
        }

        [Test]
        public void TestBuscarProductoPorNombre()
        {
            TestClass objeto = new TestClass();
            Producto esperado = new Producto();
            esperado.Codigo = 1; esperado.Nombre = "Lapicero"; esperado.Descripcion = "Pilot"; esperado.Precio = 3.5;

            Producto actual = objeto.BuscarProductoPorNombre("Lapicero");

            Assert.AreEqual(esperado.Codigo, actual.Codigo);
            Assert.AreEqual(esperado.Nombre, actual.Nombre);
            Assert.AreEqual(esperado.Descripcion, actual.Descripcion);
            Assert.AreEqual(esperado.Precio, actual.Precio);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIngresoDato()
        {
            TestClass objeto = new TestClass();
            Producto producto = new Producto();
            producto.Codigo = 2;
            producto.Nombre = null;
            producto.Descripcion = "prueba";
            try
            {
                objeto.IngresoDatos(producto);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Nombre no existe", ex.Message);
                throw;
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivision()
        {
            try
            {
                TestClass objeto = new TestClass();
                double resultado = objeto.Division(5, 0);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No se puede dividir entre cero", ex.Message);
                throw;
            }
        }

        [Test]
        public void TestGetProductoPorCodigo()
        {
            TestClass objeto = new TestClass();
            Producto producto = objeto.GetProductoPorCodigo(1);

            Assert.AreEqual(1, producto.Codigo);
            Assert.AreEqual("Lapicero", producto.Nombre);
            Assert.AreEqual("Pilot", producto.Descripcion);
        }

        [Test]
        public void TestGetCantidadProductos()
        {
            TestClass objeto = new TestClass();
            int cantidad = objeto.GetCantidadProductos();
            Assert.AreEqual(6, cantidad);
        }

        [Test]
        public void TestProductoExiste()
        {
            TestClass objeto = new TestClass();
            List<Producto> productos = objeto.GetProductoPorNombre("Celular");
            Assert.IsEmpty(productos);
        }

        [Test]
        public void TestValidarNombre()
        {
            try
            {
                TestClass objeto = new TestClass();
                objeto.ModificarProducto(4, null, "Nuevo Producto",6);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Ingrese un nombre", ex.Message);
            }

        }

        [Test]
        public void TestValidarDescripcion()
        {
            try
            {
                TestClass objeto = new TestClass();
                objeto.ModificarProducto(5, "Compas", null, 15);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Ingrese una descripcion", ex.Message);
            }
        }

        [Test]
        public void TestSeModificoProducto()
        {
            try
            {
                TestClass objeto = new TestClass();
                objeto.ModificarProducto(5, "Compas", "zafiro",15);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Producto modificado", ex.Message);
            }
        }
    }
}
