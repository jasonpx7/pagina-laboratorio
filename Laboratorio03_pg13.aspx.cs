using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorios_Practicas
{
    public partial class Laboratorio03_pg13 : System.Web.UI.Page
    {
        static double sueldo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                cbocargo.Items.Add("Seleccione...");
                cbocargo.Items.Add("Administracion");
                cbocargo.Items.Add("Contabilidad");
                cbocargo.Items.Add("Sistemas");
                cbocargo.Items.Add("Mantenimiento");
                cbocargo.Items.Add("Caja");

                cboec.Items.Add("Selecione...");
                cboec.Items.Add("Casado");
                cboec.Items.Add("Viudo");
                cboec.Items.Add("Divorciado");
                cboec.Items.Add("Soltero");

                for(int i = 0; i <= 20; i++)
                {
                    cbohijos.Items.Add("" + i);
                }
            }
        }

        //protected void cbocargo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int index;
        //    index = cbocargo.SelectedIndex;

        //    if(index == 1)
        //    {
        //        sueldo = 2000;
        //    }

        //    if (index == 2)
        //    {
        //        sueldo = 2500;
        //    }

        //    if (index == 3)
        //    {
        //        sueldo = 3000;
        //    }

        //    if (index == 4)
        //    {
        //        sueldo = 1000;
        //    }

        //    if (index == 5)
        //    {
        //        sueldo = 1500;
        //    }

        //    txtsueldo.Text = "" + sueldo;
        //}

        //protected void cboec_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    double boni = 0, tb = 0;
        //    int index;
        //    index = cboec.SelectedIndex;

        //    if(index == 1)
        //    {
        //        boni = 15;
        //        tb = sueldo * 0.15;
        //    }

        //    if (index == 2)
        //    {
        //        boni = 10;
        //        tb = sueldo * 0.10;
        //    }

        //    if (index == 3)
        //    {
        //        boni = 8;
        //        tb = sueldo * 0.08;
        //    }

        //    if (index == 4)
        //    {
        //        boni = 5;
        //        tb = sueldo * 0.05;
        //    }

        //    txtpec.Text = "" + boni;
        //    txttec.Text = "" + tb;
        //}

        protected void cbohijos_SelectedIndexChanged(object sender, EventArgs e)
        {
            double bhi = 0, pbh = 0;
            int ch = Int32.Parse(cbohijos.Text);

            if(ch >=1 && ch <= 3)
            {
                bhi = 5;
                pbh = (sueldo * bhi) / 100;
            }

            if (ch >= 4 && ch <= 6)
            {
                bhi = 10;
                pbh = (sueldo * bhi) / 100;
            }

            if (ch >= 7 && ch <= 10)
            {
                bhi = 15;
                pbh = (sueldo * bhi) / 100;
            }

            if (ch >= 11)
            {
                bhi = 20;
                pbh = (sueldo * bhi) / 100;
            }

            txtph.Text = "" + bhi;
            txttphijos.Text = "" + pbh;
        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtpec.Text = "";
            txtph.Text = "";
            txtsueldo.Text = "";
            txttec.Text = "";
            txttp.Text = "";
            txttphijos.Text = "";

            cbocargo.SelectedIndex = 0;
            cboec.SelectedIndex = 0;
            cbohijos.SelectedIndex = 0;
        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            double totalec, totalbh, p;
            totalec = double.Parse(txttec.Text);
            totalbh = double.Parse(txttphijos.Text);
            p = totalec + totalbh + sueldo;
            txttp.Text = "" + p;
        }
    }
}