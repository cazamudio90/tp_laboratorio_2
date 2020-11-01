using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Abstractas;
using Clases_Instanciables;
using Excepciones;
using System.Collections.Generic;

namespace Test_Unitario_TP3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Prueba_Alumno()
        {
            try
            {
                Universidad universidad = new Universidad();
                Alumno alumno = new Alumno("Lionel", "Messi", ENacionalidad.Argentino, 123456, 123, EClase.Programacion, EEstadoCuenta.Aldia );
                universidad += alumno;
                universidad += alumno;
                Assert.Fail("Sin excepción en Alumno_Repetido.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }
        }
       

        [TestMethod]
        public void Prueba_Profesor()
        {
            try
            {
                Universidad universidad = new Universidad();
                universidad += EClase.SPD;
                Profesor prof = universidad == EClase.SPD;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(SinProfesorException));
            }
        }
       
        [TestMethod]
        public void Prueba_Jornadas()
        {
            Universidad universidad = new Universidad();
            Assert.IsInstanceOfType(universidad.Jornadas, typeof(List<Jornada>));
        }
    }
}
