namespace _05Lab1
{
    public partial class FormLab1 : Form
    {
        public FormLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            string getInput;
            getInput = frmFileName.txtFileName.Text;

            string RelativePath = @"..\..\Paguiligan_Kiel.LabStream";
            string docPath = Path.GetFullPath(RelativePath);


            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);

                Close();
            }

        }
    }
}
