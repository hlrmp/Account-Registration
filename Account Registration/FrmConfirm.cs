using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.Form1;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {


        private DelegateText DelProgram, DelfirstName, DelLastName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetLastName);
            DelfirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelLastName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetAddress);
            DelAddress = new DelegateText(StudentInfoClass.GetProgram);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);


            labelpro.Text = DelProgram(StudentInfoClass.Program);
            labelfm.Text = DelProgram(StudentInfoClass.FirstName);
            labelmn.Text = DelProgram(StudentInfoClass.MiddleName);
            labelln.Text = DelProgram(StudentInfoClass.LastName);
            labeladd.Text = DelProgram(StudentInfoClass.Address);

            //labelage.Text = DelProgram(StudentInfoClass.Age);

            labelage.Text = Convert.ToInt64(StudentInfoClass.Age);

        }


    }
}
