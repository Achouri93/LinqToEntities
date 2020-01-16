using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToEntities
{
    public partial class UserMangerForm : Form
    {
        private readonly SQlManageUsers sql = new SQlManageUsers();
        private int index = 0;

        public UserMangerForm()
        {
            InitializeComponent();

            RefreshForm();
        }

        #region Navigation

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (MDataGridView.Rows.Count - 1 <= 0) return;

            if (index <= 0) return;

            MDataGridView.Rows[--index].Selected = true;
            ShowData(MDataGridView.Rows[index]);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (index >= MDataGridView.Rows.Count - 1) return;

            MDataGridView.Rows[++index].Selected = true;
            ShowData(MDataGridView.Rows[index]);
        }

        private void GoFirstButton_Click(object sender, EventArgs e)
        {
            index = 0;
            MDataGridView.Rows[index].Selected = true;
            ShowData(MDataGridView.Rows[index]);
        }

        private void GoLastButton_Click(object sender, EventArgs e)
        {
            index = MDataGridView.Rows.Count - 1;
            MDataGridView.Rows[index].Selected = true;
            ShowData(MDataGridView.Rows[index]);
        }

        private void MDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = MDataGridView.SelectedRows[0];

            if (row.Index <= MDataGridView.Rows.Count - 1) ShowData(row);
        }

        #endregion

        #region Helper Method


        private void ResetForm(Control control)
        {
            foreach (var mControl in control.Controls)
            {
                switch (mControl)
                {
                    case TextBox textBox:
                        textBox.Text = "";
                        break;

                    case ComboBox comboBox:
                        comboBox.DataSource = null;
                        comboBox.Items.Clear();
                        break;

                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;

                    case DataGridView dataGridView:
                        dataGridView.DataSource = null;
                        dataGridView.Rows.Clear();
                        dataGridView.Columns.Clear();
                        break;

                    case GroupBox groupBox:
                        ResetForm(groupBox);
                        break;
                }
            }
        }

        private void RefreshForm()
        {
            ResetForm(this);

            // initialize Values 
            InitDataGridView();
            InitSupervisorComboBox();
            InitDepartmentComboBox();
            MaleRadioButton.Checked = true;
            AddCheckBoxColumn();
            AddButtonColumn();
        }

        private void InitDepartmentComboBox()
        {
            DepartmentComboBox.DataSource = sql.GetDepartmentData();
            DepartmentComboBox.DisplayMember = "depname";
            DepartmentComboBox.ValueMember = "IDDEP";
        }

        private void InitSupervisorComboBox()
        {
            SupervisorComboBox.DataSource = sql.GetUserData();
            SupervisorComboBox.DisplayMember = "Name";
            SupervisorComboBox.ValueMember = "ID";
        }

        private void AddButtonColumn()
        {
            var button = new DataGridViewButtonColumn
            {
                Name = "-",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };

            MDataGridView.Columns.Add(button);
        }

        private void AddCheckBoxColumn()
        {
            var checkBox = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
            };

            MDataGridView.Columns.Add(checkBox);
        }

        private void InitDataGridView()
        {
            MDataGridView.DataSource = null;
            MDataGridView.Columns.Clear();

            MDataGridView.DataSource = sql.GetUserData();
        }

        private void ShowData(DataGridViewRow row)
        {
            IDTextBox.Text = row.Cells["ID"].Value.ToString();
            NameTextBox.Text = row.Cells["Name"].Value.ToString();
            SupervisorComboBox.Text = row.Cells["Supervisor"].Value.ToString();
            DepartmentComboBox.Text = row.Cells["Department"].Value.ToString();
            SalaryTextBox.Text = row.Cells["Salary"].Value.ToString();
            BirthdateDateTimePicker.Value = Convert.ToDateTime(row.Cells["Birthdate"].Value);
            if (row.Cells["Gender"].Value.ToString().ToUpper() == "femmale".ToUpper()) FemmaleadioButton.Checked = true;
            else MaleRadioButton.Checked = true;

        }

        #endregion

        #region Manipulate Buttons

        private bool ValidateInput()
        {

            if (String.IsNullOrEmpty(NameTextBox.Text.Trim()) || String.IsNullOrEmpty(SalaryTextBox.Text.Trim()))
            {
                MessageBox.Show("Fill Input");

                return false; ;
            }
            return true;
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            user user = new user
            {
                empname = NameTextBox.Text,
                supervisor = Convert.ToInt32(SupervisorComboBox.SelectedValue),
                salaire = Convert.ToInt32(SalaryTextBox.Text),
                datenaiss = Convert.ToDateTime(BirthdateDateTimePicker.Value.ToShortDateString()),
                sexe = MaleRadioButton.Checked,
                civilite = ""
            };


            foreach (departement item in sql.GetDepartmentData())
            {
                if (item.IDDEP == Convert.ToInt32(DepartmentComboBox.SelectedValue))
                {
                    user.departement = item;
                    break;
                }
            }

            sql.InsertUser(user);
            RefreshForm();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            if (!ValidateInput()) return;
            user user = new user
            {
                empno = Convert.ToInt32(IDTextBox.Text),
                empname = NameTextBox.Text,
                supervisor = Convert.ToInt32(SupervisorComboBox.SelectedValue),
                salaire = Convert.ToInt32(SalaryTextBox.Text),
                datenaiss = Convert.ToDateTime(BirthdateDateTimePicker.Value.ToShortDateString()),
                sexe = MaleRadioButton.Checked,
                civilite = ""
            };

            sql.UpdateUser(user, Convert.ToInt32(DepartmentComboBox.SelectedValue));
            RefreshForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDTextBox.Text))
            {
                MessageBox.Show("Enter ID That You Want to Delete");
            }

            var id = Convert.ToInt32(IDTextBox.Text);

            if (MessageBox.Show($"Do You Want To Delete Employee {id}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql.DeleteUser(id);
                RefreshForm();
            }
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            var ids = new List<int>();

            foreach (DataGridViewRow row in MDataGridView.Rows)
            {
                if (Convert.ToBoolean((row.Cells["Select"] as DataGridViewCheckBoxCell).Value))
                {
                    ids.Add(Convert.ToInt32(row.Cells["ID"].Value));
                }
            }
            sql.DeleteMulti(ids.ToArray());
            RefreshForm();
        }

        private void MDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (sender as DataGridView).Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                sql.DeleteUser(Convert.ToInt32((sender as DataGridView).Rows[e.RowIndex].Cells["ID"].Value));
                RefreshForm();
            }
        }

        #endregion

        #region Search Box

        private bool ValidateSearchInput()
        {
            if (NameCheckBox.Checked)
            {
                if (String.IsNullOrEmpty(SearchByNameTtextBox.Text.Trim()))
                {
                    MessageBox.Show("Enter Employee Name");
                    return false;
                }
            }

            if (DepartmentCheckBox.Checked)
            {
                if (String.IsNullOrEmpty(SearchByDepartmentTextBox.Text.Trim()))
                {
                    MessageBox.Show("Enter Department");
                    return false;
                }
            }

            if (SupervisorCheckBox.Checked)
            {
                if (String.IsNullOrEmpty(SearchBySupervisorextBox.Text.Trim()))
                {
                    MessageBox.Show("Enter Supervisor Name");
                    return false;
                }
            }

            return true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!ValidateSearchInput()) return;

            string name = NameCheckBox.Checked ? SearchByNameTtextBox.Text.Trim() : "";
            string department = DepartmentCheckBox.Checked ? SearchByDepartmentTextBox.Text.Trim() : "";
            string supervisor = SupervisorCheckBox.Checked ? SearchBySupervisorextBox.Text.Trim() : "";

            MDataGridView.DataSource = null;
            MDataGridView.Columns.Clear();

            MDataGridView.DataSource = sql.SearchForUsers(name, supervisor, department);

            AddCheckBoxColumn();
            AddButtonColumn();
        }

        #endregion
    }
}
