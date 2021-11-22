using PimVIIMPV.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Windows;
using PimVIIMPV.Dao;

namespace PimVIIMPV.Scripts
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btninserir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.setNome(txtnome.Text);
            p.setcpf(txtCPF.Text);

            Endereco pe = new Endereco();
            pe.setlogradouro(txtlog.Text);
            pe.setnumero(txtnum.Text);
            pe.setcep(txtcep.Text);
            pe.setbairro(txtbairro.Text);
            pe.setcidade(txtcidade.Text);
            pe.setestado(DDLestado.Text);

            PessoaDAO c = new PessoaDAO();
            c.inserePessoa(p.getNome(), p.getcpf(), pe.getlogradouro(), pe.getnumero(), pe.getcep(), pe.getbairro(), pe.getcidade(), pe.getestado());
            GridView1.DataBind();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            Pessoa pd = new Pessoa();
            pd.setId(txtID.Text);

            PessoaDAO d = new PessoaDAO();
            d.deletaPessoa(pd.getId());

            GridView1.DataBind();

        }

        protected void btnatualizar_Click(object sender, EventArgs e)
        {
            Pessoa pa = new Pessoa();
            pa.setId(txtID.Text);
            pa.setNome(txtnome.Text);
            pa.setcpf(txtCPF.Text);

            Endereco pea = new Endereco();
            pea.setlogradouro(txtlog.Text);
            pea.setnumero(txtnum.Text);
            pea.setcep(txtcep.Text);
            pea.setbairro(txtbairro.Text);
            pea.setcidade(txtcidade.Text);
            pea.setestado(DDLestado.Text);

            PessoaDAO c = new PessoaDAO();
            c.alteraPessoa(pa.getId(),pa.getNome(), pa.getcpf(), pea.getlogradouro(), pea.getnumero(), pea.getcep(), pea.getbairro(), pea.getcidade(), pea.getestado());
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text;
            txtnome.Text = GridView1.SelectedRow.Cells[2].Text;
            txtCPF.Text = GridView1.SelectedRow.Cells[3].Text;
            txtlog.Text = GridView1.SelectedRow.Cells[4].Text;
            txtnum.Text = GridView1.SelectedRow.Cells[5].Text;
            txtcep.Text = GridView1.SelectedRow.Cells[6].Text;
            txtbairro.Text = GridView1.SelectedRow.Cells[7].Text;
            txtcidade.Text = GridView1.SelectedRow.Cells[8].Text;

        }
    }
}