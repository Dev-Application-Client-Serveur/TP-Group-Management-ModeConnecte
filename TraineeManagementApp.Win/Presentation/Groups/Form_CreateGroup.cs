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
    public partial class Form_CreateGroup : Form
    {
        public Form_CreateGroup()
        {
            InitializeComponent();
        }

        private void brEnregistrer_Click(object sender, EventArgs e)
        {
            GroupsService groupService = new GroupsService();
            Group g = new Group();
            g.Id = int.Parse(idTextBox.Text);
            g.Nom = nomTextBox.Text;
            groupService.Add(g);

        }

        private void FormGroupe_Load(object sender, EventArgs e)
        {

        }
    }
}
