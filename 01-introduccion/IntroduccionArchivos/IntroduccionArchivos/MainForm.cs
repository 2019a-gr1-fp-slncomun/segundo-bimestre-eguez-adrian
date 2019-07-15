﻿/*
 * Created by SharpDevelop.
 * User: USRGAM
 * Date: 26/06/2019
 * Time: 10:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace IntroduccionArchivos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnAnadirLogClick(object sender, EventArgs e)
		{
			string tipo = "info";
			string log = "Prueba Prueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logPrueba de logde log";
			
			EscribirLog(tipo, log, dgvLogs);
			

		}
		void DgvLogsCellDoubleClick(object sender, 
		                            DataGridViewCellEventArgs e)
		{
			
			// string a =""; // Primitivo 
			
			    
			// Sintaxis
			// Clase instancia = new Clase();
			
			// double dPi = 3.14;

			// int iValue = (int)dPi;   // CASTING
			
			// int iValue2 = Convert.ToInt32(dPi);
			
			// int iValue3 = int.Parse(Dpi);
			
			// CASTEO 
			// DOUBLE -> INT   (quieroQueLeas)Variable;
			
			// TYPESCRIPT -> number entero = pi as number;
			
						
			//instancia = dgvLogs.Rows[e.RowIndex].Cells[0]
			
			
			
				DataGridViewTextBoxCell celdaTipo = 
				(DataGridViewTextBoxCell)dgvLogs.Rows[e.RowIndex].Cells[0];
			
				DataGridViewTextBoxCell celdaLog = 
					(DataGridViewTextBoxCell)dgvLogs.Rows[e.RowIndex].Cells[1];
				
				if(celdaTipo.Value != null){
					string tipo = celdaTipo.Value.ToString();
					string log = celdaLog.Value.ToString();
					
					// Mensaje
					// titulo
					// Botones
					// Icono
					
					MessageBoxIcon icono;
					
					if(tipo == "error")
					{
						icono = MessageBoxIcon.Error;
					}
					else
					{
						icono = MessageBoxIcon.Information;
					}
					
					MessageBoxButtons botones = MessageBoxButtons.OK;
					MessageBox.Show(log, tipo, botones, icono);
				}
				
			
			
			
		}
		void BtnLeerDirectorioClick(object sender, EventArgs e)
		{
			try
			{ // OK
				string path = txbLeerDirectorio.Text;
				
				// Directory
				
				DirectoryInfo infoDirectorio = new DirectoryInfo(@path);
				
				string fechaCreacion = infoDirectorio.CreationTime.ToString();
				string nombreCompleto = infoDirectorio.FullName.ToString();
				string directorioPadre = infoDirectorio.Parent.ToString();
				string directorioRaiz = infoDirectorio.Root.ToString();
				
				EscribirLog("info", "Leyendo Directorio: " + fechaCreacion, dgvLogs);
				EscribirLog("info", "Leyendo Directorio: " + nombreCompleto, dgvLogs);
				EscribirLog("info", "Leyendo Directorio: " + directorioPadre, dgvLogs);
				EscribirLog("info", "Leyendo Directorio: " + directorioRaiz, dgvLogs);
				
				FileInfo[] archivosDeDirectorio = infoDirectorio.GetFiles();
				
				foreach(FileInfo archivo in archivosDeDirectorio)
				{
					EscribirLog("info","Archivo: " + archivo.CreationTime, dgvLogs);
					EscribirLog("info","Archivo: " + archivo.FullName, dgvLogs);
					EscribirLog("info","Archivo: " + archivo.Extension, dgvLogs);
					EscribirLog("info","Archivo: " + archivo.LastAccessTime, dgvLogs);
					EscribirLog("info","Archivo: " + archivo.IsReadOnly, dgvLogs);
				}
				
				
				
				
			}
			
			catch(Exception error) // ERROR
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
		}
		
		void EscribirLog(string tipo,string log, DataGridView dgv){
			
			int posicionNuevoLog =  dgv.Rows.Add();
			
			// dgv.Rows.Add();
			
			// 1) AGREGAR UNA FILA
			// 2) Devolver la posicion de la nueva FILEA
			
			dgv.Rows[posicionNuevoLog].Cells[0].Value = tipo;
			dgv.Rows[posicionNuevoLog].Cells[1].Value = log;
			
			if(tipo == "error")
			{
				dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.Red;
			}
			else
			{
				dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.AliceBlue;
			}
			
			
			
		}
		void BtnListarDirectorioClick(object sender, EventArgs e)
		{
			try
			{
				string path = txbListarDirectorio.Text;
				
				string[] arregloDirectorios = Directory.GetDirectories(@path);
				
				int numeroDirectorios = arregloDirectorios.Length;
				
				EscribirLog("info","Numero Directorios: " + numeroDirectorios.ToString(), dgvLogs);
				
				foreach(string directorio in arregloDirectorios)
				{
					EscribirLog("info","Directorio: " + directorio, dgvLogs);
				}
				
				
			}                                                                                    
			catch (Exception error){
				EscribirLog("error",error.ToString(), dgvLogs);
			}
		}
		void BtnCrearArchivoClick(object sender, EventArgs e)
		{
			try 
			{
				string path = txbCrearArchivo.Text;
				
				
				
				StreamWriter escritura =  File.CreateText(@path);
				
				FileStream lectura = File.OpenRead(@path);
				
				StreamReader lecturaArchivo = File.OpenText(@path);         
				
				string textoLeido = File.ReadAllText(@path);
				
				escritura.WriteLine("Hola archivo");
				escritura.WriteLine("Segunda linea");
				escritura.WriteLine("Tercera linea");
				
				
				// Siempre cerrar el archivo despues de usarlo
				
				escritura.Close();
				
				
				
				using(StreamWriter escrituraDos =  File.CreateText(@path))             
				{
					escrituraDos.WriteLine("Hola archivo");
					escrituraDos.WriteLine("Segunda linea");
					escrituraDos.WriteLine("Tercera linea");
				}
				
				
				
				
				
				
				
				
				
				EscribirLog("info","Escritura Archivo: se escribio el archivo",dgvLogs);
				
			} 
			catch (Exception error) 
			{
				EscribirLog("error", error.ToString() ,dgvLogs);
			}
		}
		void BtnCrearDirectorioClick(object sender, EventArgs e)
		{
			
			try
			{
				string path = txbCrearDirectorio.Text;
				
				Directory.CreateDirectory(@path);
				
				EscribirLog("info","Crear Directorio: Se creo el directorio" + path, dgvLogs);
				
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
			
		}
		void BtnCopiarDirectorioClick(object sender, EventArgs e)
		{
			try {
				string pathInicio = txbIniciaCopia.Text;
				string pathFin = txbFinalizaCopia.Text;
				
				char[] cadenaInicio = pathInicio.ToCharArray();
				
				
				bool existeDirectorioInicio = Directory.Exists(@pathInicio);
				
				if(existeDirectorioInicio == true)
				{
					string[] directoriosInicio =  Directory.GetDirectories(@pathInicio);
					
					// ARCHIVOS 
					string[] archivosEncontrados = Directory.GetFiles(@pathInicio);
					
					// File.Copy()
					
					foreach(string directorio in directoriosInicio)
					{
						
						
						int inicioSubstring = pathInicio.Length;
						int finSubstring = directorio.Length;
						
				        string nombreDirectorio = directorio.Substring(inicioSubstring,finSubstring);
				        
						EscribirLog("info", nombreDirectorio, dgvLogs);
						
					    //char a = cadenaInicio[1];
						
					}
					
					
				}
				else
				{
					EscribirLog("error","No existe directorio.",dgvLogs);
				}
				
				
				
				
			} catch (Exception error) {
				EscribirLog("error", error.ToString(), dgvLogs);
			}
		}
		void BtnStreamWClick(object sender, EventArgs e)
		{
			string path = txbStreamW.Text;
            Stream writingStream = new FileStream(@path,FileMode.Create);  //
				
			try{
				
				
				
				if(writingStream.CanWrite){
					byte[] miNombreEnBytes = new byte[] {
						65, //A
						100, //d
						100, //d
						100, //d
						100, //d
						100, //d
						100, //d
						100, //d
						100, //d
						100, //d
						100, //d
						100, //d
					};
					
					writingStream.Write(
						miNombreEnBytes,
						0,
						miNombreEnBytes.Length
					);
					writingStream.WriteByte(33); // !
					
					EscribirLog("info","Escribimos archivo", dgvLogs);
					
					
					
				}else{
					EscribirLog("error", "No se puede escribir.", dgvLogs);
				}
				
				
				
				
				
				
			} catch(Exception error){
				
				EscribirLog("error", error.ToString(), dgvLogs);
				
			}
			finally{
				writingStream.Close();
			}
			
		}
		void BtnStreamRClick(object sender, EventArgs e)
		{
			string path = txbStreamW.Text;
			try{
				
				using(Stream readingStream = new FileStream(@path, FileMode.Open)){       
					byte[] arregloTemporal = new byte[3];
					UTF8Encoding codificacion = new UTF8Encoding(true);
					
					// readingStream.Seek  -> Moverse de posiciones
					
					
					int posicion = 0;
					
					while( (posicion = readingStream.Read(
						arregloTemporal, 
						0, 
						arregloTemporal.Length
					)) > 0){
					
						String caracter = codificacion.GetString(
							arregloTemporal,
							0,
							arregloTemporal.Length
						);
						
						EscribirLog("info","Caracter: " + caracter, dgvLogs);
						
					}
					
					
					
					
				}
				
			}
			catch(Exception error) { 
				EscribirLog("error", error.ToString(), dgvLogs);
			}
			
		}
		void BtnOrdenarArregloBsClick(object sender, EventArgs e)
		{
			string arregloTexto = txbArreglo.Text;
			
			string[] elementosString = arregloTexto.Split(',');
			
			int longitudArreglo = elementosString.Length;
			
			int[] elementos = new int[longitudArreglo];
			
			int contador = 0;
			
			foreach(string elementoString in elementosString){
				
				elementos[contador] = Int32.Parse(elementoString);
				
				EscribirLog("info", elementos[contador].ToString(), dgvLogs);     
				
				contador++;
			}
			
			for(int iPrimerelemento = 0; 
			    iPrimerelemento < longitudArreglo; 
			    iPrimerelemento++){
				
				for(int iSegundolemento = 0; 
			    iSegundolemento < longitudArreglo; 
			    iSegundolemento++){
					
					int primerNumero = elementos[iPrimerelemento];
					int segundoNumero = elementos[iSegundolemento];
					
					if(segundoNumero < primerNumero){
						int valorTemporal = primerNumero;
						elementos[iPrimerelemento] = elementos[iSegundolemento];
						elementos[iSegundolemento] = primerNumero;
						
					}

				}
			
				
			}
			
			
			
		}
	}
}























