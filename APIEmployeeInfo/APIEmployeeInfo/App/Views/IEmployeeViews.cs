using System;
using System.Windows.Forms;

namespace APIEmployeeInfo.App.Views
{
    public interface IEmployeeViews
    {
        event EventHandler BtnNewClick;
        event EventHandler BtnEditClick;
        event EventHandler BtnSaveClick;
        event EventHandler BtnDeleteClick;
        event EventHandler BtnCloseClick;
        event EventHandler RbMaleCheckChanged;
        event EventHandler RbFmaleCheckChanged;
        event EventHandler BSMainCurrentChanged;

        event KeyPressEventHandler TxtAgeKeyPress;



        Form motherForm { get; }


        DataGridView DgvListEmp { get; }

        Button newBtn { get; set; }
        Button editBtn { get; set; }
        Button saveBtn { get; set; }
        Button deleteBtn { get; set; }
        Button closeBtn { get; set; }

        TextBox EmpIDtxt { get; set; }
        TextBox EmpFNametxt { get; set; }
        TextBox EmpMNametxt { get; set; }
        TextBox EmpLNametxt { get; set; }
        TextBox EmpAddtxt { get; set; }
        TextBox EmpAgetxt { get; set; }


        Panel entryPnl { get; set; }

        RadioButton maleRB { get; set; }
        RadioButton fMaleRB { get; set; }

        BindingSource mainBS { get; set; }
    }
}


