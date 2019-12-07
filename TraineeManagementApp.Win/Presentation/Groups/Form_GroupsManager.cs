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
    public partial class Form_GroupsManager : Form
    {
        public Form_GroupsManager()
        {
            InitializeComponent();
        }

        private void Actualiser(){
            GroupsService groupsService = new GroupsService();
            groupeBindingSource.DataSource = null;
            groupeBindingSource.DataSource = groupsService.FindAll();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            Form_CreateGroup f = new Form_CreateGroup();
            f.ShowDialog();
            this.Actualiser();
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            GroupsService groupsService = new GroupsService();
            Group g = (Group)groupeBindingSource.Current;
            groupsService.Delete(g.Id);
            this.Actualiser();
        }

        private void FormGestionGroupes_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void btMettreAjour_Click(object sender, EventArgs e)
        {
            Group g = (Group)groupeBindingSource.Current;
            Form_EditGroup f = new Form_EditGroup();
            f.MiseAjour(g);
            f.ShowDialog();
            this.Actualiser();
        }
    }
}
