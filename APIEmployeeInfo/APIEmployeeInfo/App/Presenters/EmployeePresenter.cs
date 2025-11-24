using APIEmployeeInfo.App.Models;
using APIEmployeeInfo.App.Views;
using APIEmployeeInfo.Public;
using System;
using System.Data;
using System.Windows.Forms;
using static APIEmployeeInfo.Public.CustomEnums;

namespace APIEmployeeInfo.App.Presenters
{

    public class EmployeePresenter
    {
        IEmployeeRepository repository;
        IEmployeeViews view;
        Trans trans;
        string gender;

        public EmployeePresenter(IEmployeeViews view, IEmployeeRepository repository)
        {
            this.view = view;
            this.repository = repository;

            trans = Trans.Browse;
            InitEvents();
            LoadList();

        }

        #region Methods
        #region Init
        void InitEvents()
        {
            this.view.BtnNewClick += BtnNewClick;
            this.view.BtnEditClick += BtnEditClick;
            this.view.BtnSaveClick += BtnSaveClick;
            this.view.BtnDeleteClick += BtnDeleteClick;
            this.view.TxtAgeKeyPress += TxtAgeKeyPress;
            this.view.RbMaleCheckChanged += RbMaleCheckChanged;
            this.view.RbFmaleCheckChanged += RbFmaleCheckChanged;
            this.view.BSMainCurrentChanged += BSMainCurrentChanged;
            this.view.BtnCloseClick += BtnCloseClick;

        }
        #endregion
        async void LoadList()
        {
            this.view.mainBS.DataSource = await repository.LoadList();
            this.view.DgvListEmp.Focus();
            this.view.mainBS.MoveLast();
            this.view.entryPnl.Enabled = false;
            this.view.saveBtn.Enabled = false;
            this.view.deleteBtn.Enabled = true;
        }

        void LoadInfo()
        {
            BindingSource bs = this.view.mainBS;

            if (bs == null)
                return;

            var currInfo = (DataRowView)bs.Current;

            this.view.EmpIDtxt.Text = currInfo["empID"].NullAlphaM();
            this.view.EmpFNametxt.Text = currInfo["empFName"].NullAlphaM();
            this.view.EmpMNametxt.Text = currInfo["empMName"].NullAlphaM();
            this.view.EmpLNametxt.Text = currInfo["empLName"].NullAlphaM();
            this.view.EmpAddtxt.Text = currInfo["empAdd"].NullAlphaM();
            this.view.EmpAgetxt.Text = currInfo["empAge"].NullAlphaM();

            gender = currInfo["empGender"].NullAlphaM();

            if (gender == "M")
                this.view.maleRB.Checked = true;
            else if (gender == "F")
                this.view.fMaleRB.Checked = true;


        }

        void ResetInput()
        {
            foreach (Control ctrl in this.view.entryPnl.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }
        }

        async void BtnNewClick(object sender, EventArgs e)
        {
            if (trans != Trans.Browse)
                return;

            EnableEntry(Trans.New);
            ResetInput();
            this.view.EmpIDtxt.Text = await repository.GetEmpID();
            this.view.deleteBtn.Enabled = false;
        }
        void BtnEditClick(object sender, EventArgs e)
        {
            if (trans != Trans.Browse)
                return;
            EnableEntry(Trans.Edit);
            this.view.deleteBtn.Enabled = false;
        }

        void EnableEntry(Trans trans)
        {
            this.trans = trans;

            if (!this.view.entryPnl.Enabled)
                this.view.entryPnl.Enabled = true;

            this.view.EmpFNametxt.Focus();
            this.view.EmpFNametxt.Select();
            this.view.saveBtn.Enabled = true;
        }

        void TxtAgeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        #region Transaction
        async void BtnSaveClick(object sender, EventArgs e)
        {
            EmployeeModel InitInput = null;

            InitInput = ListInput();

            if (!await repository.SaveInfo(InitInput, this.trans))
                return;

            trans = Trans.Browse;
            LoadList();
        }


        EmployeeModel ListInput()
        {
            EmployeeModel mainModel = new EmployeeModel();

            mainModel.empID = this.view.EmpIDtxt.Text.NullAlphaM();
            mainModel.empFName = this.view.EmpFNametxt.Text.NullAlphaM();
            mainModel.empMName = this.view.EmpMNametxt.Text.NullAlphaM();
            mainModel.empLName = this.view.EmpLNametxt.Text.NullAlphaM();
            mainModel.empAdd = this.view.EmpAddtxt.Text.NullAlphaM();
            mainModel.empAge = this.view.EmpAgetxt.Text.NullInt();
            mainModel.empGender = gender.NullAlphaM();


            return mainModel;

        }
        #endregion

        void RbMaleCheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
                return;
            if (rb.Checked)
                gender = "M";
        }
        void RbFmaleCheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
                return;

            if (rb.Checked)
                gender = "F";
        }

        void BSMainCurrentChanged(object sender, EventArgs e)
        {
            LoadInfo();
        }

        async void BtnDeleteClick(object sender, EventArgs e)
        {
            DialogResult confirmation;
            var current = (DataRowView)this.view.mainBS.Current;
            string empID = current["empID"].ToString();


            confirmation = MessageBox.Show("Are you sure you want to remove/delete this Empoloyee? " + empID,
                                           "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No)
                return;

            bool isSuccess = await repository.DelEmp(empID);

            if (!isSuccess)
                return;

            MessageBox.Show("Employee has been removed/deleted successfully",
                            "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadList();
        }


        void BtnCloseClick(object sender, EventArgs e)
        {
            if (trans != Trans.Browse)
            {
                trans = Trans.Browse;
                LoadList();
                LoadInfo();
                this.view.entryPnl.Enabled = false;
                this.view.saveBtn.Enabled = false;
                this.view.deleteBtn.Enabled = true;

                return;
            }

            this.view.motherForm.Close();

        }
        #endregion

    }
}

