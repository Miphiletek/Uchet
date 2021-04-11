using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Uchet
{
    public partial class Form1 : Form
    {
        Thread novayaform;
        BD.TimeUchetEntities2 entities;
        List<BD.Rabotniki> rabotniki;
        
        public Form1()
        {
            

            InitializeComponent();
            
            

        }
        

        private void Open_Click(object sender, EventArgs e)
        {
            entities = new BD.TimeUchetEntities2();
            rabotniki = new List<BD.Rabotniki>(entities.Rabotniki.ToList());
           
            Logics.Value =Convert.ToString(Login.Text);
            Logics2.Value2 = Convert.ToString(Password.Text);
            bool proverka = rabotniki.Any(x => x.Name == Logics.Value);
            bool proverka2 = rabotniki.Any(x => x.Surname == Logics2.Value2);
            
            if (proverka == true && proverka2 == true)
            {

                this.Close();
                novayaform = new Thread(open);
                novayaform.SetApartmentState(ApartmentState.STA);
                novayaform.Start();
            }
            else
            {
                MessageBox.Show("Ошибка входа,Логин или Пароль указан не верно,вы уволены!!!");
            }
        }
       
        public void open(object obj)
        {
            Application.Run(new Timers());

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
