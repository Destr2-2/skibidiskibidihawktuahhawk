/*
 * Created by SharpDevelop.
 * User: moren
 * Date: 20/11/2024
 * Time: 06:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace preciost
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		// altura 
		string altura = "";
		double alto = 0;
		string altur = "";
		double ancho = 0;
		
		//bultos aserrin
		string bultos ="";
		double bulaserrin = 0;
		
		//pintura
		string pintura = "";
		double Lpintura = 0;
		
		//frutos secos
		string frutos = "";
		double secos = 0;
		
		//flores
		string flores = "";
		double docenas = 0;
		
		//trabajadores
		string trabajadores = "";
		double numtra = 0;
		
		//agua
		string agua = "";
		double Lagua = 0;
		
		//horas trabajadas 
		string horas = "";
		double Htrabajo  = 0;
		
		//coston mano de obra
		string obra = "";
		double mobra = 0;
		
		//suma total
		double resultado;
		
		
		
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
		
	
		
		void BTNborrarClick(object sender, EventArgs e)
		{
			TXTagua.Text = "";
			TXTalto.Text = "";
			TXTancho.Text = "";
			TXTaserrin.Text = "";
			TXTflores.Text = "";
			TXThoras.Text = "";
			TXTmanobra.Text = "";
			TXTpintura.Text = "";
			TXTsecos.Text = "";
			TXTtrabajadores.Text = "";
		}
		
		void BTNcalcularClick(object sender, EventArgs e)
		{
			// alto y ancho
			altura = TXTalto.Text;
			alto = double.Parse(altura);
			altur=TXTancho.Text;  
			ancho = double.Parse(altur);
			//bulto de aserrin
			bultos = TXTaserrin.Text;
			bulaserrin = double.Parse(bultos);
			//litros de pintura
			pintura = TXTpintura.Text;
			Lpintura = double.Parse(pintura);
			//frutos secos
			frutos = TXTsecos.Text;
			secos = double.Parse(frutos);
			//docena de flores
			flores = TXTflores.Text;
			docenas = double.Parse(flores);
			//num. de trabajadores
			trabajadores = TXTtrabajadores.Text;
			numtra = double.Parse(trabajadores);
			//Litros de agua
			agua = TXTagua.Text;
			Lagua = double.Parse(agua);
			//horas trabajadas
			horas = TXThoras.Text;
			Htrabajo = double.Parse(horas);
			//costo de mano de obra
			obra = TXTmanobra.Text;
			mobra = double.Parse(obra);
			
			//procedimiento para sacar el resultado
			resultado = ((alto + ancho)*30) + (bulaserrin*100) + (Lpintura * 60) + (secos * 235) + (docenas * 200)+ (Lagua * 10) + ((mobra * Htrabajo)*numtra);
			LBLtotal.Text =resultado.ToString();
		}
		
		void BTNtodoClick(object sender, EventArgs e)
		{
			LBLtotal.Text = "$$$$$$$$$";
			TXTagua.Text = "";
			TXTalto.Text = "";
			TXTancho.Text = "";
			TXTaserrin.Text = "";
			TXTflores.Text = "";
			TXThoras.Text = "";
			TXTmanobra.Text = "";
			TXTpintura.Text = "";
			TXTsecos.Text = "";
			TXTtrabajadores.Text = "";
			
		}
	}
}
