using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace WorkedTogether
{
    public partial class FormTask : Form
    {
        private List<string> columnNames = null;

        private string fullFileName = "";

        private DataTable dataTable = null;

        public FormTask()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTask_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;

            this.Text = "WorkedTogether v." + version;

            dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[4] { new DataColumn("EmployeeID1", typeof(string)),
                                                           new DataColumn("EmployeeID2", typeof(string)),
                                                           new DataColumn("ProjectID", typeof(string)),
                                                           new DataColumn("DaysWorked",typeof(string)) });            
            //DataRow dr = dataTable.Rows.Add("1", "2", "3", "4");
            this.dataGridViewRoot.DataSource = new DataView(dataTable);
            this.dataGridViewRoot.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRoot.AllowUserToAddRows = false;

            initToolStripComboBoxSort();
            initToolStripComboBoxFilter();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Title = "Please select an data file ...";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fullFileName = dialog.FileName;
                Thread newThread = new Thread(() => LoadAndPreview(fullFileName));
                newThread.Start();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                saveDialog.Title = "Save an CSV file as ...";
                saveDialog.InitialDirectory = Directory.GetCurrentDirectory();
                saveDialog.FileName = Path.ChangeExtension(fullFileName, "out");
                if ((saveDialog.ShowDialog() == DialogResult.OK) && (saveDialog.FileName != ""))
                {
                    Thread newThread = new Thread(() => SaveAs(saveDialog.FileName));
                    newThread.Start();                    
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FullFileName"></param>
        private void SaveAs(string FullFileName)
        {
            using (TextWriter tw = new StreamWriter(FullFileName))
            {
                for (int i = 0; i < dataGridViewRoot.Rows.Count - 1; i++)
                {
                    tw.WriteLine($"{dataGridViewRoot.Rows[i].Cells[0].Value.ToString()},{dataGridViewRoot.Rows[i].Cells[1].Value.ToString()},{dataGridViewRoot.Rows[i].Cells[3].Value.ToString()}");
                }
            }
            MessageBox.Show("File '"+ FullFileName + "' is saved!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FullFileName"></param>
        private void LoadAndPreview(string FullFileName)
        {
            if (Common.projects.Count > 0)
            {
                Common.projects.Clear();
                while (dataGridViewRoot.Rows.Count > 1) dataGridViewRoot.Rows.RemoveAt(dataGridViewRoot.Rows.Count - 1);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            foreach (string line in File.ReadLines(FullFileName))
            {
                ProjectObject projectObj = new ProjectObject(line);
                if (!Common.projects.ContainsKey(projectObj.projectID))
                    Common.projects.Add(projectObj.projectID, projectObj);
                else
                {
                    projectObj = Common.projects[projectObj.projectID];
                    projectObj.Update(line);
                }
            }

            dataTable.Rows.Clear();
            foreach (KeyValuePair<string, ProjectObject> project in Common.projects)
            {
                ProjectObject po = (ProjectObject)project.Value;
                DataRow dr = dataTable.Rows.Add(po.Employe1, po.Employe2, project.Key, po.Period);
            }

            Invoke(new Action(() => {
                dataGridViewRoot.DataSource = new DataView(dataTable);
                toolStripComboBoxFilter.Items.AddRange(Common.projects.Keys.ToArray());
                toolStripComboBoxFilter.SelectedIndex = 0;
                toolStripComboBoxSort.Enabled = true;
                toolStripButtonSort.Enabled = true;
                toolStripComboBoxFilter.Enabled = true;
                toolStripButtonSave.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
            }));            
        }        

        /// <summary>
        /// 
        /// </summary>
        private void initToolStripComboBoxSort()
        {
            columnNames = new List<string>();
            for (int i = 0; i < dataGridViewRoot.Columns.Count; i++)
                columnNames.Add(dataGridViewRoot.Columns[i].Name);

            toolStripComboBoxSort.Items.Clear();
            toolStripComboBoxSort.Items.AddRange(columnNames.ToArray());
            toolStripComboBoxSort.SelectedIndex = 2;
        }

        /// <summary>
        /// 
        /// </summary>
        private void initToolStripComboBoxFilter()
        {
            toolStripComboBoxFilter.Items.Add("*");
            toolStripComboBoxFilter.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (toolStripComboBoxFilter.Text != "*")
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("{0} = '{1}'", toolStripComboBoxSort.Text, toolStripComboBoxFilter.Text);
                dataGridViewRoot.DataSource = dv;
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewRoot.Sort(dataGridViewRoot.Columns[toolStripComboBoxSort.Text], toolStripButtonSort.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending);
            if (toolStripComboBoxSort.Text == "ProjectID")
            {
                toolStripComboBoxFilter.Enabled = true;
            } else
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = "";
                dataGridViewRoot.DataSource = dv;
                toolStripComboBoxFilter.SelectedIndex = 0;
                toolStripComboBoxFilter.Enabled = false;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSort_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripButtonSort.Checked)
            {
                toolStripButtonSort.Text = "Descending";
            }
            else
            {
                toolStripButtonSort.Text = "Ascending";
            }
            dataGridViewRoot.Sort(dataGridViewRoot.Columns[toolStripComboBoxSort.Text], toolStripButtonSort.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewRoot_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((e.RowIndex % 2) == 1) 
                dataGridViewRoot.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            else
                dataGridViewRoot.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }
    }
}
