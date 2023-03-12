using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TestManagement.Admin;

namespace TestManagement.Admin
{
    public partial class Resultgraph : Form
    {
        public Resultgraph()
        {
            InitializeComponent();
        }
        
        public string satwank { get; set; }
        public string rajasank { get; set; }
        public string tamasank { get; set; }
       

        public Resultgraph( string satwank1, string rajasank1, string tamasank1)
        {
            InitializeComponent();
           
            satwank = satwank1;
            rajasank = rajasank1;
            tamasank = tamasank1;
          
        }
        private void Resultgraph_Load(object sender, EventArgs e)
        {
            chart3.Series["सत्व"].Points.AddXY(1, 2.3, 3.75);
            chart3.Series["राजस"].Points.AddXY(2, 1.5, 2.5);
            chart3.Series["तामस"].Points.AddXY(3, 0.7, 1.3);

            

            chart1.Series["P10"].Points.AddXY(1, 53);
            chart1.Series["Q1"].Points.AddXY(1, 11);
            chart1.Series["P40"].Points.AddXY(1, 8);
            chart1.Series["P60"].Points.AddXY(1, 8);
            chart1.Series["Q3"].Points.AddXY(1, 8);
            chart1.Series["P90"].Points.AddXY(1, 9);
            


            chart1.Series["P10"].Points.AddXY(3,78);
            chart1.Series["Q1"].Points.AddXY(3, 18);
            chart1.Series["P40"].Points.AddXY(3, 9);
            chart1.Series["P60"].Points.AddXY(3, 14);
            chart1.Series["Q3"].Points.AddXY(3, 10);
            chart1.Series["P90"].Points.AddXY(3, 15);
           

            chart1.Series["P10"].Points.AddXY(5, 57);
            chart1.Series["Q1"].Points.AddXY(5,13);
            chart1.Series["P40"].Points.AddXY(5,12);
            chart1.Series["P60"].Points.AddXY(5,14);
            chart1.Series["Q3"].Points.AddXY(5, 11);
            chart1.Series["P90"].Points.AddXY(5,16);
           

            chart1.Series["P10"].Points.AddXY(7,13);
            chart1.Series["Q1"].Points.AddXY(7,34);
            chart1.Series["P40"].Points.AddXY(7,24);
            chart1.Series["P60"].Points.AddXY(7,29);
            chart1.Series["Q3"].Points.AddXY(7,20);
            chart1.Series["P90"].Points.AddXY(7,41);
           
            chart1.Series["P10"].Points.AddXY(9,17);
            chart1.Series["Q1"].Points.AddXY(9,4);
            chart1.Series["P40"].Points.AddXY(9,3);
            chart1.Series["P60"].Points.AddXY(9,5);
            chart1.Series["Q3"].Points.AddXY(9, 4);
            chart1.Series["P90"].Points.AddXY(9,9);
            

            



        }
    }
}
