namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      //  StudentInfoClass studentInfoClass = new StudentInfoClass();
       FrmConfirm fcon = new FrmConfirm();
        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = txtfn.Text.ToString();
            StudentInfoClass.LastName = txtln.Text.ToString();
            StudentInfoClass.MiddleName = txtmn.Text.ToString();
            StudentInfoClass.Address = ttxtaddress.Text.ToString();
            StudentInfoClass.Program = comboBox1program.Text.ToString();

            StudentInfoClass.Age = Convert.ToInt64(txtage.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(txtcnt.Text.ToString());
            StudentInfoClass.StudentNo = Convert.ToInt64(txtage.Text.ToString());

            fcon.Show();

            fcon.label9.Text = txtfn.Text.ToString();



        }

        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);


        public class StudentInfoClass
        {
            public static string FirstName = " ";
            public static string LastName = " ";
            public static string MiddleName = " ";
            public static string Address = " ";
            public static string Program = " ";

            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;



            public static string GetFirstName(string FirstName)
            {
                return FirstName;

            }

            public static string GetLastName(string LastName)
            {

                return LastName;

            }

            public static string GetMiddleName(string Middlename)
            {
                return Middlename;

            }

            public static string GetAddress(string Address)
            {
                return Address;

            }

            public static string GetProgram(string Program)
            {
                return Program;

            }

            public static long GetAge(long Age)
            {
                return Age;

            }

            public static long GetContactNo(long ContactNo)
            {
                return ContactNo;

            }

            public static long GetStudentNo(long StudentNo)
            {
                return StudentNo;

            }
        }
    }
}