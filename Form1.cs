using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class InsuranceSystem : Form
    {
        private readonly string FilePath = $"{Environment.CurrentDirectory}/patient.txt";

        private readonly string[] states = new List<string>() {
                                                    "AL",
                                                    "AK",
                                                    "AZ",
                                                    "AR",
                                                    "CA",
                                                    "CO",
                                                    "CT",
                                                    "DE",
                                                    "DC",
                                                    "FL",
                                                    "GA",
                                                    "HI",
                                                    "ID",
                                                    "IL",
                                                    "IN",
                                                    "IA",
                                                    "KS",
                                                    "KY",
                                                    "LA",
                                                    "ME",
                                                    "MD",
                                                    "MA",
                                                    "MI",
                                                    "MN",
                                                    "MS",
                                                    "MO",
                                                    "MT",
                                                    "NE",
                                                    "NV",
                                                    "NH",
                                                    "NJ",
                                                    "NM",
                                                    "NY",
                                                    "NC",
                                                    "ND",
                                                    "OH",
                                                    "OK",
                                                    "OR",
                                                    "PA",
                                                    "RI",
                                                    "SC",
                                                    "SD",
                                                    "TN",
                                                    "TX",
                                                    "UT",
                                                    "VT",
                                                    "VA",
                                                    "WA",
                                                    "WV",
                                                    "WI",
                                                    "WY "
                            }.ToArray();

        public InsuranceSystem()
        {
            InitializeComponent();
            PopulateStateDropDown();
            DefaultPatientType();
            PopulateResultsView();
        }

        private void PopulateResultsView()
        {
            var fileExists = File.Exists(FilePath);
            if (fileExists)
            {
                resultListView.AllowUserToAddRows = true;
                resultListView.DataSource = null;
                var patients = File.ReadAllLines(FilePath);
                var ok = patients.Select(c => new { Patients = c }).ToList();

                var bindingSource = new BindingSource() { DataSource = ok.ToList() };
                resultListView.DataSource = bindingSource;
            }
            else
            {
                File.Create(FilePath);
            }
        }

        private void DefaultPatientType()
        {
            isOutPatient.Checked = true;
            hospitalInput.Enabled = false;
            hospitalPhoneInput.Enabled = false;
        }

        private void PopulateStateDropDown()
        {
            statePicker.Items.AddRange(states);

            statePicker.SelectedIndex = states.Length - 1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ageInput.Text = (DateTime.Now.Year - dateTimePicker1.Value.Year).ToString();
        }

        private void expensesInputValue_ValueChanged(object sender, EventArgs e)
        {
            var formattedExpense = expensesInputValue.Value;
            var formattedCopay = decimal.Parse(coPayInput.Text);
            var percentValue = formattedExpense * (formattedCopay / 100);
            var insureValue = formattedExpense - (formattedExpense * (formattedCopay / 100));
            percentageValue.Text = $"{percentValue:C}";
            InsuranceInputValue.Text = $"{insureValue:C}";
        }

        private void isOutPatient_CheckedChanged(object sender, EventArgs e)
        {
            contactFirstNameInput.Enabled = isOutPatient.Checked;
            contactLastNameInput.Enabled = isOutPatient.Checked;
            contactPhoneValue.Enabled = isOutPatient.Checked;
            hospitalInput.Enabled = isResidentPatient.Checked;
            hospitalPhoneInput.Enabled = isResidentPatient.Checked;
        }

        private void isResidentPatient_CheckedChanged(object sender, EventArgs e)
        {
            contactFirstNameInput.Enabled = isOutPatient.Checked;
            contactLastNameInput.Enabled = isOutPatient.Checked;
            contactPhoneValue.Enabled = isOutPatient.Checked;
            hospitalInput.Enabled = isResidentPatient.Checked;
            hospitalPhoneInput.Enabled = isResidentPatient.Checked;
        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            var patient = new Patient()
            {
                FirstName = firstNameInput.Text,
                LastName = lastNameInput.Text,
                Gender = isMale.Checked ? "Mr" : isFemale.Checked ? "Ms" : "",
                Status = marriedInput.Checked ? "Married" : "Single",
                Expenses = expensesInputValue.Value,
                Age = ageInput.Text,
                Address = addressInput.Text,
                City = cityInput.Text,
                ZipCode = zipcodeInput.Text,
                PatientType = isOutPatient.Checked ? "Patient" : isResidentPatient.Checked ? "Resident" : "",
                HomePhone = homePhoneInput.Text,
                MobilePhone = mobilePhoneInput.Text,
                Insurance = InsuranceInputValue.Text,
                CopayValue = percentageValue.Text,
                CopayPercent = coPayInput.Text,
                ContactFirstName = contactFirstNameInput.Text,
                ContactLastName = contactLastNameInput.Text,
                ContactPhone = contactPhoneValue.Text,
                HospitalName = hospitalInput.Text,
                State = states[statePicker.SelectedIndex],
                HopsitalPhone = hospitalPhoneInput.Text,
            };

            Task.Run(() => SavePatient(patient));
            clearForm_Click(new { }, EventArgs.Empty);
            PopulateResultsView();
            resultListView.Refresh();
        }

        private async Task SavePatient(Patient data)
        {
            string input;
            if (data.PatientType.StartsWith("P"))
            {
                input = FormatForPatient(data);
            }
            else
            {
                input = FormatForResident(data);
            }

            await File.AppendAllTextAsync(FilePath, input);
        }

        private string FormatForResident(Patient data)
        {
            return $"{data.Gender} {data.LastName}, {data.FirstName}, Resident, {data.Status}, Age: {data.Age}," +
                  $"Expenses : ${data.Expenses}, Copay: ${data.CopayValue}, Coverage: {data.Insurance}, {data.Address} " +
                  $"{data.City} {data.State.ToUpper()}. {data.HomePhone}/{data.MobilePhone}.  Hospital: {data.HospitalName} " +
                  $"/ {data.HopsitalPhone} {Environment.NewLine} ";
        }

        private string FormatForPatient(Patient data)
        {
            return $"{data.Gender} {data.LastName}, {data.FirstName}, Patient, {data.Status}, Age: {data.Age}," +
                 $"Expenses : ${data.Expenses}, Copay: ${data.CopayValue}, Coverage: ${data.Insurance}, {data.Address} " +
                 $"{data.City} {data.State.ToUpper()}. {data.HomePhone}/{data.MobilePhone}.  Contact: {data.ContactLastName},  {data.ContactFirstName} " +
                 $" {data.ContactPhone} {Environment.NewLine} ";
        }

        private void clearForm_Click(object sender, EventArgs e)
        {
            firstNameInput.Text = string.Empty;
            lastNameInput.Text = string.Empty;
            isMale.Checked = false;
            isFemale.Checked = false;
            marriedInput.Checked = false;
            expensesInputValue.Value = 0;
            ageInput.Text = string.Empty;
            addressInput.Text = string.Empty;
            cityInput.Text = string.Empty;
            zipcodeInput.Text = string.Empty;
            DefaultPatientType();
            homePhoneInput.Text = string.Empty;
            mobilePhoneInput.Text = string.Empty;
            InsuranceInputValue.Text = "$0.0";
            percentageValue.Text = "$0.0";
            contactFirstNameInput.Text = string.Empty;
            contactLastNameInput.Text = string.Empty;
            contactPhoneValue.Text = string.Empty;
            hospitalInput.Text = string.Empty;
            hospitalPhoneInput.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void resultListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}