﻿using POO22B_FPA.src.Class.P10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA.src.DlgsPracticas.P10
{
    public partial class DlgMaestros : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        CDataBase @base;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgMaestros()
        {
            InitializeComponent();
            @base = new CDataBase();
            @base.Show_Table(1, Dgv);
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Dgv.CurrentRow.Cells[0].Value != null && Dgv.CurrentRow.Cells[1].Value != null
                    && Dgv.CurrentRow.Cells[2].Value != null && Dgv.CurrentRow.Cells[3].Value != null
                    && Dgv.CurrentRow.Cells[4].Value != null)
                {
                    TxtId.Text = Dgv.CurrentRow.Cells[0].Value.ToString();
                    TxtName.Text = Dgv.CurrentRow.Cells[1].Value.ToString();
                    TxtLastname.Text = Dgv.CurrentRow.Cells[2].Value.ToString();
                    TxtAge.Text = Dgv.CurrentRow.Cells[3].Value.ToString();
                    TxtMail.Text = Dgv.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            @base.Insert_Into(1, Dgv, TxtId, TxtName, TxtLastname, TxtAge, TxtMail, null);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            @base.Update(1, Dgv, TxtId, TxtName, TxtLastname, TxtAge, TxtMail, null);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            @base.Delete(1, Dgv, TxtId, TxtName, TxtLastname, TxtAge, TxtMail, null);
        }
    }
}
