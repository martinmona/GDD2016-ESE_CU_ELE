﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Config;
using ClinicaFrba.Class;
using System.Data.SqlClient;

namespace ClinicaFrba.DataAccess
{
    class profesionalDataAccess
    {

        public static List<Profesional> ObtenerProfesionales(string where)
        {
            List<Profesional> listaProfesionals = new List<Profesional>();
            SqlConnection conn = BD.conectar();
            SqlCommand MiComando = new SqlCommand();
            MiComando.Connection = conn;
            MiComando.CommandText = " SELECT CONCAT(pers_nombre, ' ',pers_apellido) as nombre, CONCAT(pers_tipo_documento, ' ',pers_numero_documento) as documento,pers_direccion, pers_telefono, pers_mail, pers_fecha_nacimiento, pers_sexo,  prof_codigo_matricula, prof_codigo_persona FROM ESE_CU_ELE.Profesional, ESE_CU_ELE.Persona WHERE pers_codigo = prof_codigo_persona " + where;
            SqlDataReader reader = MiComando.ExecuteReader();
            while (reader.Read())
            {
                Profesional Profesional = new Profesional();
                Profesional.codigoPersona = (decimal)reader["prof_codigo_persona"];
                Profesional.matricula = (decimal)reader["prof_codigo_matricula"];
                Profesional.nombre = (string)reader["nombre"];
                Profesional.documento = (string)reader["documento"];
                Profesional.direccion = (string)reader["pers_direccion"];
                Profesional.telefono = (decimal)reader["pers_telefono"];
                Profesional.mail = (string)reader["pers_mail"];
                Profesional.fechaNacimiento = (DateTime)reader["pers_fecha_nacimiento"];
                Profesional.sexo = (string)reader["pers_sexo"];
                listaProfesionals.Add(Profesional);
            }
            reader.Close();
            conn.Close();
            return listaProfesionals;
        }

        public static List<Profesional> ObtenerProfesionalesXEspecialidad(decimal codigoEspecialidad)
        {
            List<Profesional> listaProfesionales = new List<Profesional>();
            SqlConnection conn = BD.conectar();
            SqlCommand MiComando = new SqlCommand();
            MiComando.Connection = conn;
            MiComando.CommandText = " SELECT CONCAT(pers_nombre, ' ',pers_apellido) as nombre, CONCAT(pers_tipo_documento, ' ',pers_numero_documento) as documento,pers_direccion, pers_telefono, pers_mail, pers_fecha_nacimiento, pers_sexo,  prof_codigo_matricula, prof_codigo_persona FROM ESE_CU_ELE.Profesional, ESE_CU_ELE.Persona, ESE_CU_ELE.EspecialidadXProfesional  WHERE pers_codigo = prof_codigo_persona  AND prof_codigo_persona = espexp_codigo_profesional and espexp_codigo_especialidad = " + codigoEspecialidad;
            SqlDataReader reader = MiComando.ExecuteReader();
            while (reader.Read())
            {
                Profesional Profesional = new Profesional();
                Profesional.codigoPersona = (decimal)reader["prof_codigo_persona"];
                Profesional.matricula = (decimal)reader["prof_codigo_matricula"];
                Profesional.nombre = (string)reader["nombre"];
                Profesional.documento = (string)reader["documento"];
                Profesional.direccion = (string)reader["pers_direccion"];
                Profesional.telefono = (decimal)reader["pers_telefono"];
                Profesional.mail = (string)reader["pers_mail"];
                Profesional.fechaNacimiento = (DateTime)reader["pers_fecha_nacimiento"];
                Profesional.sexo = (string)reader["pers_sexo"];
                listaProfesionales.Add(Profesional);
            }
            reader.Close();
            conn.Close();
            return listaProfesionales;
        }
    }
}
