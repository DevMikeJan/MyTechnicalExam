using System;
using System.Windows.Forms;

namespace APIEmployeeInfo.App.Views
{
    public partial class EmployeeViews : Form, IEmployeeViews
    {
        public EmployeeViews()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public Form motherForm
        {
            get { return this; }
        }

        public DataGridView DgvListEmp
        {
            get { return dgvMain; }
            set { dgvMain = value; }
        }

        public Button newBtn
        {
            get { return btnNew; }
            set { btnNew = value; }
        }
        public Button editBtn
        {
            get { return btnEdit; }
            set { btnEdit = value; }
        }
        public Button saveBtn
        {
            get { return btnSave; }
            set { btnSave = value; }
        }
        public Button deleteBtn
        {
            get { return btnDel; }
            set { btnDel = value; }
        }
        public Button closeBtn
        {
            get { return btnClose; }
            set { btnClose = value; }
        }
        public Panel entryPnl
        {
            get { return pnlEntry; }
            set { pnlEntry = value; }
        }
        public BindingSource mainBS
        {
            get { return bsMain; }
            set { bsMain = value; }
        }

        public TextBox EmpIDtxt
        {
            get { return txtEmpID; }
            set { txtEmpID = value; }
        }
        public TextBox EmpFNametxt
        {
            get { return txtEmpName; }
            set { txtEmpName = value; }
        }
        public TextBox EmpMNametxt
        {
            get { return txtMName; }
            set { txtMName = value; }
        }
        public TextBox EmpLNametxt
        {
            get { return txtLName; }
            set { txtLName = value; }
        }
        public TextBox EmpAddtxt
        {
            get { return txtAddress; }
            set { txtAddress = value; }
        }
        public TextBox EmpAgetxt
        {
            get { return txtAge; }
            set { txtAge = value; }
        }

        public RadioButton maleRB
        {
            get { return rbMale; }
            set { rbMale = value; }
        }
        public RadioButton fMaleRB
        {
            get { return rbFMale; }
            set { rbFMale = value; }
        }

        public event EventHandler BtnNewClick;
        public event EventHandler BtnEditClick;
        public event EventHandler BtnSaveClick;
        public event EventHandler BtnDeleteClick;
        public event EventHandler BtnCloseClick;
        public event EventHandler RbMaleCheckChanged;
        public event EventHandler RbFmaleCheckChanged;
        public event EventHandler BSMainCurrentChanged;

        public event KeyPressEventHandler TxtAgeKeyPress;

        private void AssociateAndRaiseViewEvents()
        {
            btnNew.Click += delegate { BtnNewClick?.Invoke(this, EventArgs.Empty); };
            btnEdit.Click += delegate { BtnEditClick?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { BtnSaveClick?.Invoke(this, EventArgs.Empty); };
            btnDel.Click += delegate { BtnDeleteClick?.Invoke(this, EventArgs.Empty); };
            btnClose.Click += delegate { BtnCloseClick?.Invoke(this, EventArgs.Empty); };
            rbMale.CheckedChanged += delegate { RbMaleCheckChanged?.Invoke(rbMale, EventArgs.Empty); };
            rbFMale.CheckedChanged += delegate { RbFmaleCheckChanged?.Invoke(rbFMale, EventArgs.Empty); };
            bsMain.CurrentChanged += delegate { BSMainCurrentChanged?.Invoke(bsMain, EventArgs.Empty); };

            txtAge.KeyPress += (s, e) => TxtAgeKeyPress?.Invoke(txtAge, e);
        }


    }
}
