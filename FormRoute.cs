using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticPlatformMVP
{
    public partial class FormRoute : Form
    {

        int m_iSelectionNumber = 0;

        public FormRoute()
        {
            InitializeComponent();
            // Populate the rows.
            string[] row0 = new string[] { "Богдана Хмельницкого просп., 137T, Белгородская обл.", "0", "0","0" };
            string[] row1 = new string[] { "ул. Попова, 12, Белгород", "9", "9","8" };
            string[] row2 = new string[] { "Театральный пр-д, 1, Белгородская обл.", "1","10", "15" };
            string[] row3 = new string[] { "ул. Победы, Белгородская обл.", "1", "11", "20" };
            string[] row4 = new string[] { "ул. Костюкова, 46, Белгородская обл.", "10", "21", "25" };
            string[] row5 = new string[] { "ул. Королева, 2а, 2, Белгородская обл.", "8", "29", "30" };
            string[] row6 = new string[] { "Олимпийская улица, 8, Белгородская область", "26", "55", "45" };
            string[] row7 = new string[] { "Богдана Хмельницкого просп., 137T, Белгородская обл.", "10", "65", "0" };
            object[] rows = new object[] { row0, row1, row2, row3, row4, row5, row6, row7 };
            foreach (string[] rowArray in rows)
            {
                dgvHierarchyRoute.Rows.Add(rowArray);
            }
            //dgvRoute.EnableHeadersVisualStyles = false;            
            dgvHierarchyRoute.ClearSelection();
            row0 = new string[] { "Богдана Хмельницкого просп., 137T, Белгородская обл.", "0", "0", "0" };
            row1 = new string[] { "ул. Попова, 12, Белгород", "10", "10", "45" };
            row2 = new string[] { "Театральный пр-д, 1, Белгородская обл.", "19", "29", "20" };
            row3 = new string[] { "ул. Победы, Белгородская обл.", "1", "30", "8" };
            row4 = new string[] { "ул. Костюкова, 46, Белгородская обл.", "1", "31", "15" };
            row5 = new string[] { "ул. Королева, 2а, 2, Белгородская обл.", "8", "39", "30" };
            row6 = new string[] { "Олимпийская улица, 8, Белгородская область", "10", "49", "25" };
            row7 = new string[] { "Богдана Хмельницкого просп., 137T, Белгородская обл.", "17", "66", "0" };
            rows = new object[] { row0, row1, row2, row3, row4, row5, row6, row7 };
            foreach (string[] rowArray in rows)
            {
                dgvQuickRoute.Rows.Add(rowArray);
            }
           
        }
        private void RandomGraph()
        {

        }
        private void SelectLates()
        {
            for (int i = 0; i < dgvQuickRoute.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvQuickRoute.Rows[i].Cells[3].Value) < Convert.ToInt32(dgvQuickRoute.Rows[i].Cells[2].Value))
                {
                    dgvQuickRoute[3, i].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvQuickRoute[3, i].Style.BackColor = Color.Green;
                }
            }
            for (int i = 0; i < dgvHierarchyRoute.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvHierarchyRoute.Rows[i].Cells[3].Value) < Convert.ToInt32(dgvHierarchyRoute.Rows[i].Cells[2].Value))
                {
                    dgvHierarchyRoute[3, i].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvHierarchyRoute[3, i].Style.BackColor = Color.Green;
                }
            }
        }
      

        private void DgvRoute_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHierarchyRoute.SelectedRows.Count>0 && dgvHierarchyRoute.SelectedRows[0].Index!=m_iSelectionNumber)
            {
                dgvHierarchyRoute.ClearSelection();
                dgvHierarchyRoute.Rows[m_iSelectionNumber].Selected = true;
            }

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            m_iSelectionNumber++;
            if (m_iSelectionNumber == dgvHierarchyRoute.Rows.Count)
            {
               
                MessageBox.Show("Маршрут завершен!");
            }
            else
            {
                dgvHierarchyRoute.Rows[m_iSelectionNumber].Selected = true;
            }
        }
    }
}
