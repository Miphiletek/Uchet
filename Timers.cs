using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Uchet
{
    public partial class Timers : Form
    {

        BD.TimeUchetEntities2 entities;
        List<BD.Rabotniki> rabotniki;
        TimeSpan time1;
        DateTime initial_time = DateTime.Now;
        string currentTime = DateTime.Now.TimeOfDay.ToString();

        
        public Timers()
        {
            InitializeComponent();
            
            
            
           
        }
        public int hour = 9;
        public int minutes = 0;
        public int secundes = 0;
       
           

            private void Start_Click(object sender, EventArgs e)
        {
            couldown.Start();
            couldown2.Start();
            
        }

        private void Stop_Click(object sender, EventArgs e)
        {
           
            couldown.Stop();
            
        }

        private void couldown_Tick(object sender, EventArgs e)
        {
            secundes = secundes - 1;
            if (secundes == -1)
            {
                minutes = minutes - 1;
                secundes = 59;
            }

            if (minutes == -1)
            {
                hour = hour - 1;
                minutes = 59;


            }



            hourlabel.Text = Convert.ToString(hour);
            minuteslabel.Text = Convert.ToString(minutes);
            secundeslabel.Text = Convert.ToString(secundes);
            string currentTime = DateTime.Now.TimeOfDay.ToString();
            string today = "den" + DateTime.Today.ToString("dd");
            if (hour == 0 && minutes == 0 && secundes == 0)
            {
                couldown.Stop();
                string konec = "9ч";
               
                char[] mass = today.ToCharArray();
                
                if (mass[3]=='0')
                {
                    mass[3] = mass[4];
                    string today2 = new string(mass);
                    string today3 = today2.Substring(0, 3);
                    BD.WorkTime workTime = new BD.WorkTime();
                    
                   switch(today3)
                    {
                        case "den1":
                            workTime.den1 = "9ч";
                            break;
                        case "den2":
                            workTime.den2 = "9ч";
                            break;
                        case "den3":
                            workTime.den3 = "9ч";
                            break;
                        case "den4":
                            workTime.den4 = "9ч";
                            break;
                        case "den5":
                            workTime.den5 = "9ч";
                            break;
                        case "den6":
                            workTime.den6 = "9ч";
                            break;
                        case "den7":
                            workTime.den7 = "9ч";
                            break;
                        case "den8":
                            workTime.den8 = "9ч";
                            break;
                        case "den9":
                            workTime.den9 = "9ч";
                            break;
                        


                    }
                    
                    





                }
                else
                {
                    BD.WorkTime workTime = new BD.WorkTime();
                    switch (today)
                    {
                        
                        case "den10":
                            workTime.den10 = "9ч";
                            break;
                        case "den11":
                            workTime.den11 = "9ч";
                            break;
                        case "den12":
                            workTime.den12 = "9ч";
                            break;
                        case "den13":
                            workTime.den13 = "9ч";
                            break;
                        case "den14":
                            workTime.den14 = "9ч";
                            break;
                        case "den15":
                            workTime.den15 = "9ч";
                            break;
                        case "den16":
                            workTime.den16 = "9ч";
                            break;
                        case "den17":
                            workTime.den17 = "9ч";
                            break;
                        case "den18":
                            workTime.den18 = "9ч";
                            break;
                        case "den19":
                            workTime.den19 = "9ч";
                            break;
                        case "den20":
                            workTime.den20 = "9ч";
                            break;
                        case "den21":
                            workTime.den21 = "9ч";
                            break;
                        case "den22":
                            workTime.den22= "9ч";
                            break;
                        case "den23":
                            workTime.den23 = "9ч";
                            break;
                        case "den24":
                            workTime.den24= "9ч";
                            break;
                        case "den25":
                            workTime.den25 = "9ч";
                            break;
                        case "den26":
                            workTime.den26 = "9ч";
                            
                            break;
                        case "den27":
                            workTime.den27 = "9ч";
                            break;
                        case "den28":
                            workTime.den28 = "9ч";
                            break;
                        case "den29":
                            workTime.den29 = "9ч";
                            break;
                        case "den30":
                            workTime.den30 = "9ч";
                            break;
                        case "den31":
                            workTime.den31 = "9ч";
                            break;
                    }
                }


            }
            else if (currentTime=="18:00")
            {
                konec();
                Application.Exit();
            }
           

        }

        private void Vixodswork_Click(object sender, EventArgs e)
        {
            couldown2.Stop();
            

            konec();
        
            




            








        }

        public void konec()
        {
            couldown.Stop();
            couldown2.Stop();
            DateTime current_time = DateTime.Now;
            time1 = current_time - initial_time;
            string vrem = time1.Hours.ToString() + " ч " + time1.Minutes.ToString() + "м";
            string currentTime = DateTime.Now.TimeOfDay.ToString();
            string today = "den" + DateTime.Today.ToString("dd");
            char[] mass = today.ToCharArray();

            if (mass[3] == '0')
            {
                mass[3] = mass[4];
                string today2 = new string(mass);
                string today3 = today2.Substring(0, 3);
                BD.WorkTime workTime = new BD.WorkTime();

                switch (today3)
                {
                    case "den1":
                        workTime.den1 = vrem;
                        break;
                    case "den2":
                        workTime.den2 = vrem;
                        break;
                    case "den3":
                        workTime.den3 = vrem;
                        break;
                    case "den4":
                        workTime.den4 = vrem;
                        break;
                    case "den5":
                        workTime.den5 = vrem;
                        break;
                    case "den6":
                        workTime.den6 = vrem;
                        break;
                    case "den7":
                        workTime.den7 = vrem;
                        break;
                    case "den8":
                        workTime.den8 = vrem;
                        break;
                    case "den9":
                        workTime.den9 = vrem;
                        break;



                }







            }
            else
            {
                BD.WorkTime workTime = new BD.WorkTime();
                switch (today)
                {

                    case "den10":
                        workTime.den10 = vrem;
                        break;
                    case "den11":
                        workTime.den11 = vrem;
                        break;
                    case "den12":
                        workTime.den12 = vrem;
                        break;
                    case "den13":
                        workTime.den13 = vrem;
                        break;
                    case "den14":
                        workTime.den14 = vrem;
                        break;
                    case "den15":
                        workTime.den15 = vrem;
                        break;
                    case "den16":
                        workTime.den16 = vrem;
                        break;
                    case "den17":
                        workTime.den17 = vrem;
                        break;
                    case "den18":
                        workTime.den18 = vrem;
                        break;
                    case "den19":
                        workTime.den19 = vrem;
                        break;
                    case "den20":
                        workTime.den20 = vrem;
                        break;
                    case "den21":
                        workTime.den21 = vrem;
                        break;
                    case "den22":
                        workTime.den22 = vrem;
                        break;
                    case "den23":
                        workTime.den23 = vrem;
                        break;
                    case "den24":
                        workTime.den24 = vrem;
                        break;
                    case "den25":
                        workTime.den25 = vrem;
                        break;
                    case "den26":
                        workTime.den26 = vrem;

                        break;
                    case "den27":
                        workTime.den27 = vrem;
                        break;
                    case "den28":
                        workTime.den28 = vrem;
                        break;
                    case "den29":
                        workTime.den29 = vrem;
                        break;
                    case "den30":
                        workTime.den30 = vrem;
                        break;
                    case "den31":
                        workTime.den31 = vrem;
                        break;
                }
            }



        }
       
       
       

        private void couldown2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
