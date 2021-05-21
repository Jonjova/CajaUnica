﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Autobuses
    {
        private int ID_AUTOBUS;
        private string NUM_PLACA;
        private int NUM_ASIENTOS;
        private string MARCA;
        private string MODELO;
        private DateTime ANIO_FABRICACION;
        private int ID_EMPRESARIO;
        private int ID_USUARIO_CREA;

        public int id
        {
            get { return ID_AUTOBUS; }
            set { ID_AUTOBUS = value; }
        }

        public string placa
        {
            get { return NUM_PLACA; }
            set { NUM_PLACA = value; }
        }

        public int numAsientos
        {
            get { return NUM_ASIENTOS; }
            set { NUM_ASIENTOS = value; }
        }

        public string marca
        {
            get { return MARCA; }
            set { MARCA = value; }
        }

        public string modelo
        {
            get { return MODELO; }
            set { MODELO = value; }
        }

        public DateTime anioFabricacion
        {
            get { return ANIO_FABRICACION; }
            set { ANIO_FABRICACION = value; }
        }

        public int idEmpresario
        {
            get { return ID_EMPRESARIO; }
            set { ID_EMPRESARIO = value; }
        }

        public int idEUsuarioCrea
        {
            get { return ID_USUARIO_CREA; }
            set { ID_USUARIO_CREA = value; }
        }

    }



}
