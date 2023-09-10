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

            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelfirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);


            labelpro.Text = DelProgram(StudentInfoClass.Program.ToString());
            labelfm.Text = DelfirstName(StudentInfoClass.FirstName);
            labelmn.Text = DelMiddleName(StudentInfoClass.MiddleName);
            labelln.Text = DelLastName(StudentInfoClass.LastName);
            labeladd.Text = DelAddress(StudentInfoClass.Address);

            // labelage.Text = DelProgram(StudentInfoClass.Age);
            //  long newage = Convert.ToInt64(StudentInfoClass.Age);

            // labelpro.Text = StudentInfoClass.Program;
             // labelage.Text = DelNumAge(Convert.ToInt64(newage));

        }


    }

}
