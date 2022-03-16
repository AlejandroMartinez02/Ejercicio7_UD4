using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7_UD4
{
    public partial class Form1 : Form
    {
        Guy Bob = new Guy("Bob", 100);
        Guy Joe = new Guy("Joe", 50);
        int banco = 100;

        public Form1()
        {
            InitializeComponent();
        }

        public class Guy
        {
            public String nombre;
            public int saldo;


            public void recibirCash()
            {
                saldo = saldo + 10;
               
            }


            public void darCash()
            {
                saldo = saldo - 5;
            }

            public Guy()
            {

            }

            public Guy(String name, int cash)
            {
                saldo = cash;
                nombre = name;
            }
           

        }

        public void actualizaForm()
        {
            Bob_saldo.Text = "Bob tiene " + Bob.saldo + "eur";
            Joe_saldo.Text = "Joe tiene " + Joe.saldo + "eur";
        }

        private void aJoe10e_Click(object sender, EventArgs e)
        {
           
            if(banco == 0)
            {
                MessageBox.Show("Estamos en BANCA ROTA");
            }
            else
            {
                
                Joe.recibirCash();
                banco -= 10;
                actualizaForm();
                banca.Text = "La banca tiene " + banco + "eur";
            }
            
            

        }

        private void BobAJoe_Click(object sender, EventArgs e)
        {
            if (Bob.saldo == 0)
            {
                MessageBox.Show("No puedo darle más dinero a Joe");
            }
            else
            {
                Joe.saldo += 5;
                Bob.saldo -= 5;
                actualizaForm();
            }
        }

        private void aBob5e_Click(object sender, EventArgs e)
        {



            if(Bob.saldo == 0)
            {
                MessageBox.Show("No tengo saldo suficiente como para darte 5");
            }
            else
            {
                Bob.darCash();
                banco += 5;
                banca.Text = "La banca tiene " + banco + "eur";
                actualizaForm();

            }


        }
        private void JoeABob_Click(object sender, EventArgs e)
        {
            

            if(Joe.saldo == 0)
            {
                MessageBox.Show("No puedo darle más dinero a Bob");
            }
            else
            {
                Joe.saldo -= 10;
                Bob.saldo += 10;
                actualizaForm();
            }

 
         
        }
    }

  
}
