using AgeAPP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeAPP.Forms
{
    public partial class AdminPanelForm : Form
    {
        //Serviços
        private FiresharpData local_Data_service = new FiresharpData();

        public AdminPanelForm(FiresharpData data_service)
        {
            InitializeComponent();
            local_Data_service = data_service;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
