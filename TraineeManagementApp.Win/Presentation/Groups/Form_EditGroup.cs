using AppGestionStagiaires.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppGestionStagiaires.Entities
{
    public partial class Form_EditGroup : Form
    {
        public Form_EditGroup()
        {
            InitializeComponent();
        }

        public void MiseAjour(Group g) {

            idTextBox.Text = g.Id.ToString();
            nomTextBox.Text = g.Nom;
        }

        private void btMiseAjour_Click(object sender, EventArgs e)
        {
            GroupsService groupsService = new GroupsService();
            Group g = new Group();
            g.Id = int.Parse(idTextBox.Text);
            g.Nom = nomTextBox.Text;
            groupsService.Update(g);
        }
    }
}
