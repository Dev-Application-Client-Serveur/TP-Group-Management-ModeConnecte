using AppGestionStagiaires.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGestionStagiaires.Services
{
    /// <summary>
    /// Les données sont enregistrer dans une liste des groupes
    /// La minipulation des données est gérer avec Linq
    /// </summary>
    public class GroupsService
    {
        private static List<Group> Data_Groups = new List<Group>();

        static GroupsService() {
            Data_Groups.Add(new Group(1, "Madani"));
            Data_Groups.Add(new Group(2,"Chami"));
        }

        /// <summary>
        /// Add new Group
        /// </summary>
        /// <param name="g"> le Groupe à ajouter</param>
        public void Add(Group g) {
            Data_Groups.Add(g);
        }

        /// <summary>
        /// Supprimer un groupe par Id
        /// </summary>
        /// <param name="id"> Id de groupe à supprimer</param>
        public void Delete(int id) {

            Group group = this.FindAll().Find(g => g.Id == id);
            if (group != null)
                this.FindAll().Remove(group);

        }

        /// <summary>
        /// Mise à jour un objet Groupe
        /// </summary>
        /// <param name="g">un objet de type groupe contenant les information à mettre à jour</param>
        public void Update(Group group_data) {

            Group group = this.FindAll().Find(g => g.Id == group_data.Id);
            group.Nom = group_data.Nom;
             
        }
        /// <summary>
        /// Retourne la liste des groupes à afficher
        /// </summary>
        /// <returns></returns>
        public List<Group> FindAll() {
            return Data_Groups;
        }
    }
}
