/*
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
			this.dgvLogs.Size = new System.Drawing.Size(671, 291);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(695, 485);
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

