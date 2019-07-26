using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace GestionArchive
{
    public partial class FrmAnneeScolaire : Form
    {
        public FrmAnneeScolaire()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var classe = new ClasseDAO().GetClasse(int.Parse(cbc.Text));
            var etudiant = new EtudiantDAO().GetEtudiant(int.Parse(cbe.Text));
            Models.AnneeScolaire anne = new Models.AnneeScolaire(0, cba.Text ,classe , etudiant);
            AnneeScolaireDAO anneeScolaireDAO = new AnneeScolaireDAO();
            int rs= anneeScolaireDAO.InsertAnneeScolaire(anne);

        }

        private void show_Click(object sender, EventArgs e)
        {
            shower();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var delete = new AnneeScolaireDAO();
            delete.DeleteAnneeScolaire(int.Parse(dtgv.CurrentRow.Cells[0].Value.ToString()));
             }
        private void shower(){ 
        dtgv.DataSource = null;
        var anneeScolaire = new AnneeScolaireDAO().GetAnneeScolaires();
        dtgv.DataSource = anneeScolaire;}

        private void FrmAnneeScolaire_Load(object sender, EventArgs e)
        {
            shower();
        }

        private void update_Click(object sender, EventArgs e)
        {

           var UPDATE= new AnneeScolaireDAO();
           var annee = UPDATE.GetAnneeScolaire(int.Parse(dtgv.CurrentRow.Cells[0].Value.ToString()));
            annee.Annee = cba.Text;
            
        }
    }
 
}
