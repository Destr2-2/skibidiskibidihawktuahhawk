/*
 * Created by SharpDevelop.
 * User: moren
 * Date: 20/11/2024
 * Time: 06:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace preciost
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.TXTalto = new System.Windows.Forms.TextBox();
			this.TXTpintura = new System.Windows.Forms.TextBox();
			this.TXTsecos = new System.Windows.Forms.TextBox();
			this.TXTflores = new System.Windows.Forms.TextBox();
			this.TXTagua = new System.Windows.Forms.TextBox();
			this.TXTtrabajadores = new System.Windows.Forms.TextBox();
			this.TXThoras = new System.Windows.Forms.TextBox();
			this.TXTmanobra = new System.Windows.Forms.TextBox();
			this.TXTancho = new System.Windows.Forms.TextBox();
			this.TXTaserrin = new System.Windows.Forms.TextBox();
			this.BTNcalcular = new System.Windows.Forms.Button();
			this.BTNborrar = new System.Windows.Forms.Button();
			this.LBLtotal = new System.Windows.Forms.Label();
			this.BTNtodo = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(145)))), ((int)(((byte)(141)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(298, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(563, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculador de precios";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(73, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(227, 58);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tamaño del tapete \r\nen metros (Alto):";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(634, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(227, 58);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tamaño del tapete \r\nen metros (Ancho):";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(73, 350);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(227, 58);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kg. frutos secos:";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(634, 234);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(227, 71);
			this.label5.TabIndex = 4;
			this.label5.Text = "Litros de pintura:";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(73, 234);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(227, 71);
			this.label6.TabIndex = 5;
			this.label6.Text = "Bultos de aserrín:\r\n";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(73, 571);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(227, 58);
			this.label7.TabIndex = 6;
			this.label7.Text = "Horas trabajadas:";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(634, 350);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(227, 58);
			this.label8.TabIndex = 7;
			this.label8.Text = "Docena de flores:";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label9.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(73, 455);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(227, 58);
			this.label9.TabIndex = 8;
			this.label9.Text = "Num. de trabajadores:";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label10.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(634, 455);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(227, 58);
			this.label10.TabIndex = 9;
			this.label10.Text = "Litros de agua:\r\n";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.label11.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(634, 571);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(227, 58);
			this.label11.TabIndex = 10;
			this.label11.Text = "costo de mano \r\nde obra:\r\n";
			// 
			// TXTalto
			// 
			this.TXTalto.BackColor = System.Drawing.Color.Bisque;
			this.TXTalto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTalto.Location = new System.Drawing.Point(306, 130);
			this.TXTalto.Name = "TXTalto";
			this.TXTalto.Size = new System.Drawing.Size(179, 26);
			this.TXTalto.TabIndex = 11;
			// 
			// TXTpintura
			// 
			this.TXTpintura.BackColor = System.Drawing.Color.Bisque;
			this.TXTpintura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTpintura.Location = new System.Drawing.Point(867, 235);
			this.TXTpintura.Name = "TXTpintura";
			this.TXTpintura.Size = new System.Drawing.Size(179, 26);
			this.TXTpintura.TabIndex = 12;
			// 
			// TXTsecos
			// 
			this.TXTsecos.BackColor = System.Drawing.Color.Bisque;
			this.TXTsecos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTsecos.Location = new System.Drawing.Point(306, 350);
			this.TXTsecos.Name = "TXTsecos";
			this.TXTsecos.Size = new System.Drawing.Size(179, 26);
			this.TXTsecos.TabIndex = 13;
			// 
			// TXTflores
			// 
			this.TXTflores.BackColor = System.Drawing.Color.Bisque;
			this.TXTflores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTflores.Location = new System.Drawing.Point(867, 350);
			this.TXTflores.Name = "TXTflores";
			this.TXTflores.Size = new System.Drawing.Size(179, 26);
			this.TXTflores.TabIndex = 14;
			// 
			// TXTagua
			// 
			this.TXTagua.BackColor = System.Drawing.Color.Bisque;
			this.TXTagua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTagua.Location = new System.Drawing.Point(867, 465);
			this.TXTagua.Name = "TXTagua";
			this.TXTagua.Size = new System.Drawing.Size(179, 26);
			this.TXTagua.TabIndex = 15;
			// 
			// TXTtrabajadores
			// 
			this.TXTtrabajadores.BackColor = System.Drawing.Color.Bisque;
			this.TXTtrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTtrabajadores.Location = new System.Drawing.Point(306, 465);
			this.TXTtrabajadores.Name = "TXTtrabajadores";
			this.TXTtrabajadores.Size = new System.Drawing.Size(179, 26);
			this.TXTtrabajadores.TabIndex = 16;
			// 
			// TXThoras
			// 
			this.TXThoras.BackColor = System.Drawing.Color.Bisque;
			this.TXThoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXThoras.Location = new System.Drawing.Point(306, 584);
			this.TXThoras.Name = "TXThoras";
			this.TXThoras.Size = new System.Drawing.Size(179, 26);
			this.TXThoras.TabIndex = 17;
			// 
			// TXTmanobra
			// 
			this.TXTmanobra.BackColor = System.Drawing.Color.Bisque;
			this.TXTmanobra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTmanobra.Location = new System.Drawing.Point(867, 584);
			this.TXTmanobra.Name = "TXTmanobra";
			this.TXTmanobra.Size = new System.Drawing.Size(179, 26);
			this.TXTmanobra.TabIndex = 18;
			// 
			// TXTancho
			// 
			this.TXTancho.BackColor = System.Drawing.Color.Bisque;
			this.TXTancho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTancho.Location = new System.Drawing.Point(867, 130);
			this.TXTancho.Name = "TXTancho";
			this.TXTancho.Size = new System.Drawing.Size(179, 26);
			this.TXTancho.TabIndex = 19;
			// 
			// TXTaserrin
			// 
			this.TXTaserrin.BackColor = System.Drawing.Color.Bisque;
			this.TXTaserrin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TXTaserrin.Location = new System.Drawing.Point(306, 235);
			this.TXTaserrin.Name = "TXTaserrin";
			this.TXTaserrin.Size = new System.Drawing.Size(179, 26);
			this.TXTaserrin.TabIndex = 20;
			// 
			// BTNcalcular
			// 
			this.BTNcalcular.BackColor = System.Drawing.Color.Bisque;
			this.BTNcalcular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BTNcalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNcalcular.ForeColor = System.Drawing.Color.Black;
			this.BTNcalcular.Location = new System.Drawing.Point(395, 689);
			this.BTNcalcular.Name = "BTNcalcular";
			this.BTNcalcular.Size = new System.Drawing.Size(154, 72);
			this.BTNcalcular.TabIndex = 21;
			this.BTNcalcular.Text = "Calcular";
			this.BTNcalcular.UseVisualStyleBackColor = false;
			this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcularClick);
			// 
			// BTNborrar
			// 
			this.BTNborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
			this.BTNborrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BTNborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNborrar.Location = new System.Drawing.Point(230, 698);
			this.BTNborrar.Name = "BTNborrar";
			this.BTNborrar.Size = new System.Drawing.Size(129, 55);
			this.BTNborrar.TabIndex = 22;
			this.BTNborrar.Text = "Borrar";
			this.BTNborrar.UseVisualStyleBackColor = false;
			this.BTNborrar.Click += new System.EventHandler(this.BTNborrarClick);
			// 
			// LBLtotal
			// 
			this.LBLtotal.BackColor = System.Drawing.Color.SeaShell;
			this.LBLtotal.Location = new System.Drawing.Point(919, 756);
			this.LBLtotal.Name = "LBLtotal";
			this.LBLtotal.Size = new System.Drawing.Size(171, 23);
			this.LBLtotal.TabIndex = 24;
			this.LBLtotal.Text = "$$$$$$$$$";
			// 
			// BTNtodo
			// 
			this.BTNtodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BTNtodo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BTNtodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNtodo.Location = new System.Drawing.Point(1008, 655);
			this.BTNtodo.Name = "BTNtodo";
			this.BTNtodo.Size = new System.Drawing.Size(95, 64);
			this.BTNtodo.TabIndex = 25;
			this.BTNtodo.Text = "Borrar precios";
			this.BTNtodo.UseVisualStyleBackColor = false;
			this.BTNtodo.Click += new System.EventHandler(this.BTNtodoClick);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(306, 104);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(200, 23);
			this.label14.TabIndex = 26;
			this.label14.Text = "Costo por metro: 30$";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Red;
			this.label16.Location = new System.Drawing.Point(306, 209);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(223, 23);
			this.label16.TabIndex = 28;
			this.label16.Text = "costo de bulto 20kl : 100$";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Red;
			this.label17.Location = new System.Drawing.Point(306, 324);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(179, 23);
			this.label17.TabIndex = 29;
			this.label17.Text = "Costo por kl: 235$";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Red;
			this.label18.Location = new System.Drawing.Point(867, 209);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(179, 23);
			this.label18.TabIndex = 30;
			this.label18.Text = "Costo por litro: 60$";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.Red;
			this.label19.Location = new System.Drawing.Point(867, 327);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(208, 23);
			this.label19.TabIndex = 31;
			this.label19.Text = "Costo por docena: 200$";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.Red;
			this.label20.Location = new System.Drawing.Point(867, 439);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(179, 23);
			this.label20.TabIndex = 32;
			this.label20.Text = "Costo por litro: 10$";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(867, 104);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(208, 23);
			this.label15.TabIndex = 33;
			this.label15.Text = "Costo por metro: 30$";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.SeaShell;
			this.label12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(872, 722);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(231, 72);
			this.label12.TabIndex = 23;
			this.label12.Text = "el total \r\nes:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1153, 806);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.BTNtodo);
			this.Controls.Add(this.LBLtotal);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.BTNborrar);
			this.Controls.Add(this.BTNcalcular);
			this.Controls.Add(this.TXTaserrin);
			this.Controls.Add(this.TXTancho);
			this.Controls.Add(this.TXTmanobra);
			this.Controls.Add(this.TXThoras);
			this.Controls.Add(this.TXTtrabajadores);
			this.Controls.Add(this.TXTagua);
			this.Controls.Add(this.TXTflores);
			this.Controls.Add(this.TXTsecos);
			this.Controls.Add(this.TXTpintura);
			this.Controls.Add(this.TXTalto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.MaximumSize = new System.Drawing.Size(1175, 862);
			this.MinimumSize = new System.Drawing.Size(1175, 862);
			this.Name = "MainForm";
			this.Text = "preciost";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button BTNtodo;
		private System.Windows.Forms.Label LBLtotal;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button BTNborrar;
		private System.Windows.Forms.Button BTNcalcular;
		private System.Windows.Forms.TextBox TXTaserrin;
		private System.Windows.Forms.TextBox TXTancho;
		private System.Windows.Forms.TextBox TXTmanobra;
		private System.Windows.Forms.TextBox TXThoras;
		private System.Windows.Forms.TextBox TXTtrabajadores;
		private System.Windows.Forms.TextBox TXTagua;
		private System.Windows.Forms.TextBox TXTflores;
		private System.Windows.Forms.TextBox TXTsecos;
		private System.Windows.Forms.TextBox TXTpintura;
		private System.Windows.Forms.TextBox TXTalto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
