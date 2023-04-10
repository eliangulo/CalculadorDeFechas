using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        List<Month> months = new List<Month>();
        public Form1()
        {
            InitializeComponent();
            //lista para meses
            
            months.Add(new Month("Enero", 1, 31));
            months.Add(new Month("Febrero", 2, 28));
            months.Add(new Month("Marzo", 3, 31));
            months.Add(new Month("Abril", 4, 30));
            months.Add(new Month("Mayo", 5, 31));
            months.Add(new Month("Junio", 6, 30));
            months.Add(new Month("Julio", 7, 31));
            months.Add(new Month("Agosto", 8, 31));
            months.Add(new Month("Septiembre", 9, 30));
            months.Add(new Month("Octubre", 10, 31));
            months.Add(new Month("Noviembre", 11, 30));
            months.Add(new Month("Diciembre", 12, 31));

        }

        private void btnCalculateDate_Click(object sender, EventArgs e)
        {
            string day = tbDay.Text.ToString();
            string month = tbMonth.Text.ToString();
            string year = tbYear.Text.ToString();
            string dayError = ("");
            string monthError = ("");
            string yearError = ("");

            bool validationok = true;

            if (day.Equals(""))
            {
                dayError = "Complete el campo";
                validationok = false;
            }
            else
            {
                dayError = "";
            }
            if (month.Equals(""))
            {
                monthError = "Complete el campo";
                validationok = false;
            }
            else
            {
                monthError = "";
            }
            if (year.Equals(""))
            {
                yearError = "Complete el campo";
                validationok = false;
            }
            else
            {
                yearError = "";
            }

            if (!validationok)
            {
                return;
            }

            int dayValue = Int32.Parse(day);
            int monthValue = Int32.Parse(month);  
            
            if (dayValue > 31) {
                dayError = "Dia invalido";
                validationok = false;
            }
            if (monthValue > 12) {
                dayError = "Mes invalido";
                validationok = false;
            }
            if (!validationok){
                return;
            }
            else
            {
                dayError = "";
                monthError = "";
                yearError = "";

            }
           if (monthValue >= months.Count){
                int dayValue2 = 1;
                int monthValue2 = 1;
                Month monthModel2 = months[monthValue2 - 1];
                int yearValue = Int32.Parse(year);
                int newYear = yearValue + 1;
                lblDate.Text = dayValue2 + "de " + monthModel2.Name + "del" + newYear;
                return;
           }
            Month monthModel = months[monthValue - 1];
            if (dayValue >= monthModel.DayLimit){
                lblDate.Text = "01" + "de " + monthModel.Name + "del" + year;
            }
            else{
                int newDay = dayValue + 1;
                lblDate.Text = newDay + "de " + monthModel.Name + "del" + year;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDay.Text = "";
            tbMonth.Text = "";
            tbYear.Text = "";
            //dayError = "";
            //monthError = "";
            //yearError = "";
            lblDate.Text = "";
        }
        
    } 
}

class Month
{
    string name;
    int position;
    int dayLimit;

    public Month(string name, int position, int dayLimit)
    {
        this.name = name;
        this.position = position;
        this.dayLimit = dayLimit;
    }

    public string Name
    {
        get { return name; }
    }
    public int DayLimit
    {
        get { return dayLimit; }
    }
}
