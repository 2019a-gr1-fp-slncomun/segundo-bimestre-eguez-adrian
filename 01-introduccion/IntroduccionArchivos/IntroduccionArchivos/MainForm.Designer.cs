﻿/*
 * Created by SharpDevelop.
 * User: USRGAM
 * Date: 26/06/2019
 * Time: 10:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IntroduccionArchivos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvLogs;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn log;
		private System.Windows.Forms.Button btnAnadirLog;
		private System.Windows.Forms.Button btnLeerDirectorio;
		private System.Windows.Forms.TextBox txbLeerDirectorio;
		private System.Windows.Forms.Button btnListarDirectorio;
		private System.Windows.Forms.TextBox txbListarDirectorio;
		private System.Windows.Forms.TextBox txbCrearArchivo;
		private System.Windows.Forms.Button btnCrearArchivo;
		private System.Windows.Forms.TextBox txbCrearDirectorio;
		private System.Windows.Forms.Button btnCrearDirectorio;
		private System.Windows.Forms.TextBox txbIniciaCopia;
		private System.Windows.Forms.TextBox txbFinalizaCopia;
		private System.Windows.Forms.Button btnCopiarDirectorio;
		private System.Windows.Forms.TextBox txbStreamW;
		private System.Windows.Forms.Button btnStreamW;
		private System.Windows.Forms.Button btnStreamR;
		private System.Windows.Forms.TextBox txbArreglo;
		private System.Windows.Forms.Button btnOrdenarArregloBs;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvLogs = new System.Windows.Forms.DataGridView();
			this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.log = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAnadirLog = new System.Windows.Forms.Button();
			this.btnLeerDirectorio = new System.Windows.Forms.Button();
			this.txbLeerDirectorio = new System.Windows.Forms.TextBox();
			this.btnListarDirectorio = new System.Windows.Forms.Button();
			this.txbListarDirectorio = new System.Windows.Forms.TextBox();
			this.txbCrearArchivo = new System.Windows.Forms.TextBox();
			this.btnCrearArchivo = new System.Windows.Forms.Button();
			this.txbCrearDirectorio = new System.Windows.Forms.TextBox();
			this.btnCrearDirectorio = new System.Windows.Forms.Button();
			this.txbIniciaCopia = new System.Windows.Forms.TextBox();
			this.txbFinalizaCopia = new System.Windows.Forms.TextBox();
			this.btnCopiarDirectorio = new System.Windows.Forms.Button();
			this.txbStreamW = new System.Windows.Forms.TextBox();
			this.btnStreamW = new System.Windows.Forms.Button();
			this.btnStreamR = new System.Windows.Forms.Button();
			this.txbArreglo = new System.Windows.Forms.TextBox();
			this.btnOrdenarArregloBs = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLogs
			// 
			this.dgvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.tipo,
			this.log});
			this.dgvLogs.Location = new System.Drawing.Point(12, 134);
			this.dgvLogs.Name = "dgvLogs";
			this.dgvLogs.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvLogs.RowTemplate.Height = 24;
			this.dgvLogs.Size = new System.Drawing.Size(1048, 231);
			this.dgvLogs.TabIndex = 0;
			this.dgvLogs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLogsCellDoubleClick);
			// 
			// tipo
			// 
			this.tipo.HeaderText = "Tipo Log";
			this.tipo.Name = "tipo";
			this.tipo.ReadOnly = true;
			// 
			// log
			// 
			this.log.HeaderText = "Descripcion";
			this.log.Name = "log";
			this.log.ReadOnly = true;
			// 
			// btnAnadirLog
			// 
			this.btnAnadirLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.btnAnadirLog.Location = new System.Drawing.Point(12, 441);
			this.btnAnadirLog.Name = "btnAnadirLog";
			this.btnAnadirLog.Size = new System.Drawing.Size(187, 32);
			this.btnAnadirLog.TabIndex = 1;
			this.btnAnadirLog.Text = "Anadir log";
			this.btnAnadirLog.UseVisualStyleBackColor = true;
			this.btnAnadirLog.Click += new System.EventHandler(this.BtnAnadirLogClick);
			// 
			// btnLeerDirectorio
			// 
			this.btnLeerDirectorio.Location = new System.Drawing.Point(12, 78);
			this.btnLeerDirectorio.Name = "btnLeerDirectorio";
			this.btnLeerDirectorio.Size = new System.Drawing.Size(135, 32);
			this.btnLeerDirectorio.TabIndex = 2;
			this.btnLeerDirectorio.Text = "Leer Directorio";
			this.btnLeerDirectorio.UseVisualStyleBackColor = true;
			this.btnLeerDirectorio.Click += new System.EventHandler(this.BtnLeerDirectorioClick);
			// 
			// txbLeerDirectorio
			// 
			this.txbLeerDirectorio.Location = new System.Drawing.Point(12, 37);
			this.txbLeerDirectorio.Name = "txbLeerDirectorio";
			this.txbLeerDirectorio.Size = new System.Drawing.Size(135, 22);
			this.txbLeerDirectorio.TabIndex = 3;
			// 
			// btnListarDirectorio
			// 
			this.btnListarDirectorio.Location = new System.Drawing.Point(166, 78);
			this.btnListarDirectorio.Name = "btnListarDirectorio";
			this.btnListarDirectorio.Size = new System.Drawing.Size(126, 32);
			this.btnListarDirectorio.TabIndex = 4;
			this.btnListarDirectorio.Text = "Listar Directorio";
			this.btnListarDirectorio.UseVisualStyleBackColor = true;
			this.btnListarDirectorio.Click += new System.EventHandler(this.BtnListarDirectorioClick);
			// 
			// txbListarDirectorio
			// 
			this.txbListarDirectorio.Location = new System.Drawing.Point(166, 37);
			this.txbListarDirectorio.Name = "txbListarDirectorio";
			this.txbListarDirectorio.Size = new System.Drawing.Size(126, 22);
			this.txbListarDirectorio.TabIndex = 5;
			// 
			// txbCrearArchivo
			// 
			this.txbCrearArchivo.Location = new System.Drawing.Point(313, 37);
			this.txbCrearArchivo.Name = "txbCrearArchivo";
			this.txbCrearArchivo.Size = new System.Drawing.Size(126, 22);
			this.txbCrearArchivo.TabIndex = 6;
			// 
			// btnCrearArchivo
			// 
			this.btnCrearArchivo.Location = new System.Drawing.Point(313, 78);
			this.btnCrearArchivo.Name = "btnCrearArchivo";
			this.btnCrearArchivo.Size = new System.Drawing.Size(126, 32);
			this.btnCrearArchivo.TabIndex = 7;
			this.btnCrearArchivo.Text = "Crear Archivo";
			this.btnCrearArchivo.UseVisualStyleBackColor = true;
			this.btnCrearArchivo.Click += new System.EventHandler(this.BtnCrearArchivoClick);
			// 
			// txbCrearDirectorio
			// 
			this.txbCrearDirectorio.Location = new System.Drawing.Point(456, 37);
			this.txbCrearDirectorio.Name = "txbCrearDirectorio";
			this.txbCrearDirectorio.Size = new System.Drawing.Size(126, 22);
			this.txbCrearDirectorio.TabIndex = 8;
			// 
			// btnCrearDirectorio
			// 
			this.btnCrearDirectorio.Location = new System.Drawing.Point(456, 78);
			this.btnCrearDirectorio.Name = "btnCrearDirectorio";
			this.btnCrearDirectorio.Size = new System.Drawing.Size(126, 32);
			this.btnCrearDirectorio.TabIndex = 9;
			this.btnCrearDirectorio.Text = "Crear Directorio";
			this.btnCrearDirectorio.UseVisualStyleBackColor = true;
			this.btnCrearDirectorio.Click += new System.EventHandler(this.BtnCrearDirectorioClick);
			// 
			// txbIniciaCopia
			// 
			this.txbIniciaCopia.Location = new System.Drawing.Point(605, 37);
			this.txbIniciaCopia.Name = "txbIniciaCopia";
			this.txbIniciaCopia.Size = new System.Drawing.Size(126, 22);
			this.txbIniciaCopia.TabIndex = 10;
			// 
			// txbFinalizaCopia
			// 
			this.txbFinalizaCopia.Location = new System.Drawing.Point(748, 37);
			this.txbFinalizaCopia.Name = "txbFinalizaCopia";
			this.txbFinalizaCopia.Size = new System.Drawing.Size(126, 22);
			this.txbFinalizaCopia.TabIndex = 11;
			// 
			// btnCopiarDirectorio
			// 
			this.btnCopiarDirectorio.Location = new System.Drawing.Point(605, 78);
			this.btnCopiarDirectorio.Name = "btnCopiarDirectorio";
			this.btnCopiarDirectorio.Size = new System.Drawing.Size(269, 32);
			this.btnCopiarDirectorio.TabIndex = 12;
			this.btnCopiarDirectorio.Text = "Copiar Directorio";
			this.btnCopiarDirectorio.UseVisualStyleBackColor = true;
			this.btnCopiarDirectorio.Click += new System.EventHandler(this.BtnCopiarDirectorioClick);
			// 
			// txbStreamW
			// 
			this.txbStreamW.Location = new System.Drawing.Point(880, 12);
			this.txbStreamW.Name = "txbStreamW";
			this.txbStreamW.Size = new System.Drawing.Size(126, 22);
			this.txbStreamW.TabIndex = 13;
			// 
			// btnStreamW
			// 
			this.btnStreamW.Location = new System.Drawing.Point(880, 40);
			this.btnStreamW.Name = "btnStreamW";
			this.btnStreamW.Size = new System.Drawing.Size(126, 32);
			this.btnStreamW.TabIndex = 14;
			this.btnStreamW.Text = "Stream W";
			this.btnStreamW.UseVisualStyleBackColor = true;
			this.btnStreamW.Click += new System.EventHandler(this.BtnStreamWClick);
			// 
			// btnStreamR
			// 
			this.btnStreamR.Location = new System.Drawing.Point(880, 78);
			this.btnStreamR.Name = "btnStreamR";
			this.btnStreamR.Size = new System.Drawing.Size(126, 32);
			this.btnStreamR.TabIndex = 15;
			this.btnStreamR.Text = "Stream R";
			this.btnStreamR.UseVisualStyleBackColor = true;
			this.btnStreamR.Click += new System.EventHandler(this.BtnStreamRClick);
			// 
			// txbArreglo
			// 
			this.txbArreglo.Location = new System.Drawing.Point(226, 398);
			this.txbArreglo.Name = "txbArreglo";
			this.txbArreglo.Size = new System.Drawing.Size(237, 22);
			this.txbArreglo.TabIndex = 16;
			// 
			// btnOrdenarArregloBs
			// 
			this.btnOrdenarArregloBs.Location = new System.Drawing.Point(226, 441);
			this.btnOrdenarArregloBs.Name = "btnOrdenarArregloBs";
			this.btnOrdenarArregloBs.Size = new System.Drawing.Size(126, 32);
			this.btnOrdenarArregloBs.TabIndex = 17;
			this.btnOrdenarArregloBs.Text = "Ordenar Arreglo Bs";
			this.btnOrdenarArregloBs.UseVisualStyleBackColor = true;
			this.btnOrdenarArregloBs.Click += new System.EventHandler(this.BtnOrdenarArregloBsClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(1072, 485);
			this.Controls.Add(this.btnOrdenarArregloBs);
			this.Controls.Add(this.txbArreglo);
			this.Controls.Add(this.btnStreamR);
			this.Controls.Add(this.btnStreamW);
			this.Controls.Add(this.txbStreamW);
			this.Controls.Add(this.btnCopiarDirectorio);
			this.Controls.Add(this.txbFinalizaCopia);
			this.Controls.Add(this.txbIniciaCopia);
			this.Controls.Add(this.btnCrearDirectorio);
			this.Controls.Add(this.txbCrearDirectorio);
			this.Controls.Add(this.btnCrearArchivo);
			this.Controls.Add(this.txbCrearArchivo);
			this.Controls.Add(this.txbListarDirectorio);
			this.Controls.Add(this.btnListarDirectorio);
			this.Controls.Add(this.txbLeerDirectorio);
			this.Controls.Add(this.btnLeerDirectorio);
			this.Controls.Add(this.btnAnadirLog);
			this.Controls.Add(this.dgvLogs);
			this.Name = "MainForm";
			this.Text = "IntroduccionArchivos";
			((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
	}

