﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Class
{
    abstract class Persona
    {
        private int _codigo;
        private string _nombre;
        private string _apellido;
        private string _sexo;
        private DateTime _fechaNacimiento;
        private string _tipoDocumento;
        private int _numeroDocumento;
        private string _mail;
        private string _direccion;
        private int _telefono;
        private string _tipo;

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string tipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }
        public int numeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; }
        }
        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public int telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}