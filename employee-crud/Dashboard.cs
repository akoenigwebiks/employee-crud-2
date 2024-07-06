using employee_crud.Models;
using employee_crud.Services;
using static employee_crud.Models.EmployeeModel;

namespace employee_crud
{
    internal partial class Dashboard : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly EmployeeModel _currentEmployee;
        private bool _isEditMode;
        public Dashboard(EmployeeService employeeService, EmployeeModel currentEmployee)
        {
            _employeeService = employeeService;
            _currentEmployee = currentEmployee;
            InitializeComponent();
        }

        public Dashboard(EmployeeService employeeService)
        {
            _isEditMode = false;

            var emp1 = new EmployeeModel();
            emp1.Address = new Address("Hanasih", "Jerusalem", "13");
            emp1.FirstName = "John";
            emp1.LastName = "Doe";
            emp1.PhoneNumber = "123456789";
            emp1.Nat = "123456789";
            emp1.BirthDate = new DateOnly(1986, 1, 1);
            emp1.Gender = EmployeeModel.GenderEnum.Female;
            emp1.MaritalStatus = EmployeeModel.MaritalStatusEnum.Widowed;
            _employeeService = employeeService;
            _currentEmployee = employeeService.InitBlankEmployee();
            InitializeComponent();
            ResetFormControls(this, _isEditMode);
            RenderEmployee(emp1);
        }

        private void RenderEmployee(EmployeeModel employee)
        {
            textBox_id.Text = employee.ID;
            textBox_nat.Text = employee.Nat;
            textBox_firstName.Text = employee.FirstName;
            textBox_lastName.Text = employee.LastName;
            textBox_phoneNumber.Text = employee.PhoneNumber;
            textBox_mobileNumber.Text = employee.PhoneNumber;
            textBox_AddressStreetName.Text = employee.Address.StreetName;
            textBox_AddressCity.Text = employee.Address.City;
            textBox_AddressStreetNumber.Text = employee.Address.HouseNumber;
            dateTimePicker_dob.Value = employee.BirthDate.ToDateTime(TimeOnly.MinValue);

            SetaritalStatusRadioButtonValues(employee.MaritalStatus);
            SetGenderRadioButtonValues(employee.Gender);
        }

        private void SetGenderRadioButtonValues(GenderEnum employeeGender)
        {
            radioButton_genderMale.Checked = employeeGender == EmployeeModel.GenderEnum.Male;
            radioButton_genderFemale.Checked = employeeGender == EmployeeModel.GenderEnum.Female;
        }

        private void SetaritalStatusRadioButtonValues(MaritalStatusEnum employeeMaritalStatus)
        {
            radioButton_status_single.Checked = employeeMaritalStatus == EmployeeModel.MaritalStatusEnum.Single;
            radioButton_status_married.Checked = employeeMaritalStatus == EmployeeModel.MaritalStatusEnum.Married;
            radioButton_status_divorced.Checked = employeeMaritalStatus == EmployeeModel.MaritalStatusEnum.Divorced;
            radioButto_status_widowed.Checked = employeeMaritalStatus == EmployeeModel.MaritalStatusEnum.Widowed;
        }

        private void radioButton_genderMale_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void ResetFormControls(Control control,bool allowEdit)
        {
            foreach (Control c in control.Controls)
            {
                switch (c)
                {
                    case TextBox textBox:
                        textBox.ReadOnly = !allowEdit;
                        textBox.Clear();
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        comboBox.Enabled = allowEdit;
                        break;
                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        checkBox.Enabled = allowEdit;
                        break;
                    case RadioButton radioButton:
                        radioButton.Checked = false;
                        radioButton.Enabled = allowEdit;
                        break;
                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Value = DateTime.Now;
                        dateTimePicker.Enabled = allowEdit;
                        break;
                    case ListBox listBox:
                        listBox.ClearSelected();
                        listBox.Enabled = allowEdit;
                        break;
                    default:
                        if (c.HasChildren)
                        {
                            ResetFormControls(c,allowEdit); // Recursively reset controls within containers
                        }
                        break;
                }
            }
        }


        private void ResetForm(bool allowEdit)
        {
            ResetFormControls(this, allowEdit);
        }

        private void button_crud_create_Click(object sender, EventArgs e)
        {
            // Display confirmation dialog
            var result = MessageBox.Show("Are you sure you want to reset all fields?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            ResetForm(true);
        }
    }
}
