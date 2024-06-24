using System;
using System.Windows.Forms;


namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private Plan_sot planSotForm;
        public Form1()
        {
            InitializeComponent();
            planSotForm = new Plan_sot();
            planSotForm.TaskAdded += PlanSotForm_TaskAdded;
        }
        //Для обновления списка планов сотрудников
        private void PlanSotForm_TaskAdded(object sender, EventArgs e)
        {
            UpdateForsotrTasksList();
        }
        private void UpdateForsotrTasksList()
        {
            Forsotr forsotr = new Forsotr();
            forsotr.Show(); 

            if (planSotForm != null)
            {
                forsotr.UpdateTasksList(planSotForm.GetTasks()); 
            }
        }
        //Запуск формы планирования работы сотрудников
        private void button1_Click(object sender, EventArgs e)
        {
            planSotForm = new Plan_sot();
            planSotForm.TaskAdded += PlanSotForm_TaskAdded;
            planSotForm.Show();
        }
        //Все кнопки для запуска форм
        private void button2_Click(object sender, EventArgs e)
        {
            Naem_sot naem_sot = new Naem_sot();
            naem_sot.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Obuch_sot obuch_sot = new Obuch_sot();
            obuch_sot.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Forsotr forsotr = new Forsotr();
            forsotr.UpdateTasksList(planSotForm.GetTasks());
            forsotr.Show();
        }
    }
}
