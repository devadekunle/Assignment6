
namespace Assignment6
{
    partial class InsuranceSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TextBox mobilePhonInput;
            System.Windows.Forms.Label labelcopyV;
            this.percentageValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isMale = new System.Windows.Forms.RadioButton();
            this.isFemale = new System.Windows.Forms.RadioButton();
            this.marriedLabel = new System.Windows.Forms.Label();
            this.marriedInput = new System.Windows.Forms.CheckBox();
            this.expensesInput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.zipcodeInput = new System.Windows.Forms.TextBox();
            this.statePicker = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.homePhoneInput = new System.Windows.Forms.TextBox();
            this.mobilePhoneInput = new System.Windows.Forms.Label();
            this.coPayInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.InsuranceInputValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.expensesInputValue = new System.Windows.Forms.NumericUpDown();
            this.isOutPatient = new System.Windows.Forms.RadioButton();
            this.outPatientForm = new System.Windows.Forms.GroupBox();
            this.contactPhoneValue = new System.Windows.Forms.TextBox();
            this.contactPhoneInput = new System.Windows.Forms.Label();
            this.contactLastNameInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.contactFirstNameInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.isResidentPatient = new System.Windows.Forms.RadioButton();
            this.AddPatient = new System.Windows.Forms.Button();
            this.deletePatient = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.hospitalInput = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.hospitalPhoneInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearForm = new System.Windows.Forms.Button();
            this.resultListView = new System.Windows.Forms.DataGridView();
            mobilePhonInput = new System.Windows.Forms.TextBox();
            labelcopyV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expensesInputValue)).BeginInit();
            this.outPatientForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultListView)).BeginInit();
            this.SuspendLayout();
            // 
            // mobilePhonInput
            // 
            mobilePhonInput.Location = new System.Drawing.Point(352, 195);
            mobilePhonInput.Name = "mobilePhonInput";
            mobilePhonInput.Size = new System.Drawing.Size(152, 23);
            mobilePhonInput.TabIndex = 26;
            // 
            // labelcopyV
            // 
            labelcopyV.AutoSize = true;
            labelcopyV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelcopyV.ForeColor = System.Drawing.Color.Black;
            labelcopyV.Location = new System.Drawing.Point(529, 134);
            labelcopyV.Name = "labelcopyV";
            labelcopyV.Size = new System.Drawing.Size(61, 15);
            labelcopyV.TabIndex = 31;
            labelcopyV.Text = "Copay ($):";
            // 
            // percentageValue
            // 
            this.percentageValue.BackColor = System.Drawing.SystemColors.MenuBar;
            this.percentageValue.Enabled = false;
            this.percentageValue.Location = new System.Drawing.Point(600, 130);
            this.percentageValue.Name = "percentageValue";
            this.percentageValue.Size = new System.Drawing.Size(176, 23);
            this.percentageValue.TabIndex = 32;
            this.percentageValue.Text = "$0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(90, 13);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(152, 23);
            this.firstNameInput.TabIndex = 1;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(347, 13);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(176, 23);
            this.lastNameInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(272, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(560, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type:";
            // 
            // typeInput
            // 
            this.typeInput.BackColor = System.Drawing.SystemColors.MenuBar;
            this.typeInput.Enabled = false;
            this.typeInput.Location = new System.Drawing.Point(602, 14);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(176, 23);
            this.typeInput.TabIndex = 6;
            this.typeInput.Text = "Patient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender:";
            // 
            // isMale
            // 
            this.isMale.AutoSize = true;
            this.isMale.CausesValidation = false;
            this.isMale.Location = new System.Drawing.Point(91, 50);
            this.isMale.Name = "isMale";
            this.isMale.Size = new System.Drawing.Size(51, 19);
            this.isMale.TabIndex = 8;
            this.isMale.TabStop = true;
            this.isMale.Text = "Male";
            this.isMale.UseVisualStyleBackColor = true;
            // 
            // isFemale
            // 
            this.isFemale.AutoSize = true;
            this.isFemale.CausesValidation = false;
            this.isFemale.Location = new System.Drawing.Point(148, 50);
            this.isFemale.Name = "isFemale";
            this.isFemale.Size = new System.Drawing.Size(63, 19);
            this.isFemale.TabIndex = 9;
            this.isFemale.TabStop = true;
            this.isFemale.Text = "Female";
            this.isFemale.UseVisualStyleBackColor = true;
            // 
            // marriedLabel
            // 
            this.marriedLabel.AutoSize = true;
            this.marriedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.marriedLabel.ForeColor = System.Drawing.Color.Black;
            this.marriedLabel.Location = new System.Drawing.Point(288, 55);
            this.marriedLabel.Name = "marriedLabel";
            this.marriedLabel.Size = new System.Drawing.Size(57, 15);
            this.marriedLabel.TabIndex = 10;
            this.marriedLabel.Text = "Married: ";
            // 
            // marriedInput
            // 
            this.marriedInput.AutoSize = true;
            this.marriedInput.Location = new System.Drawing.Point(351, 55);
            this.marriedInput.Name = "marriedInput";
            this.marriedInput.Size = new System.Drawing.Size(15, 14);
            this.marriedInput.TabIndex = 11;
            this.marriedInput.UseVisualStyleBackColor = true;
            // 
            // expensesInput
            // 
            this.expensesInput.AutoSize = true;
            this.expensesInput.CausesValidation = false;
            this.expensesInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expensesInput.ForeColor = System.Drawing.Color.Black;
            this.expensesInput.Location = new System.Drawing.Point(532, 55);
            this.expensesInput.Name = "expensesInput";
            this.expensesInput.Size = new System.Drawing.Size(61, 15);
            this.expensesInput.TabIndex = 12;
            this.expensesInput.Text = "Expenses:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Birth Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ageInput
            // 
            this.ageInput.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ageInput.Enabled = false;
            this.ageInput.Location = new System.Drawing.Point(431, 88);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(69, 23);
            this.ageInput.TabIndex = 16;
            this.ageInput.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(388, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Address:";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(96, 120);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(405, 23);
            this.addressInput.TabIndex = 19;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(96, 149);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(115, 23);
            this.cityInput.TabIndex = 20;
            // 
            // zipcodeInput
            // 
            this.zipcodeInput.Location = new System.Drawing.Point(365, 149);
            this.zipcodeInput.Name = "zipcodeInput";
            this.zipcodeInput.Size = new System.Drawing.Size(135, 23);
            this.zipcodeInput.TabIndex = 21;
            // 
            // statePicker
            // 
            this.statePicker.FormattingEnabled = true;
            this.statePicker.Location = new System.Drawing.Point(224, 149);
            this.statePicker.Name = "statePicker";
            this.statePicker.Size = new System.Drawing.Size(121, 23);
            this.statePicker.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Home Phone:";
            // 
            // homePhoneInput
            // 
            this.homePhoneInput.Location = new System.Drawing.Point(104, 195);
            this.homePhoneInput.Name = "homePhoneInput";
            this.homePhoneInput.Size = new System.Drawing.Size(152, 23);
            this.homePhoneInput.TabIndex = 24;
            // 
            // mobilePhoneInput
            // 
            this.mobilePhoneInput.AutoSize = true;
            this.mobilePhoneInput.CausesValidation = false;
            this.mobilePhoneInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mobilePhoneInput.ForeColor = System.Drawing.Color.Black;
            this.mobilePhoneInput.Location = new System.Drawing.Point(263, 199);
            this.mobilePhoneInput.Name = "mobilePhoneInput";
            this.mobilePhoneInput.Size = new System.Drawing.Size(86, 15);
            this.mobilePhoneInput.TabIndex = 25;
            this.mobilePhoneInput.Text = "Mobile Phone:";
            // 
            // coPayInput
            // 
            this.coPayInput.BackColor = System.Drawing.SystemColors.MenuBar;
            this.coPayInput.Enabled = false;
            this.coPayInput.Location = new System.Drawing.Point(600, 88);
            this.coPayInput.Name = "coPayInput";
            this.coPayInput.Size = new System.Drawing.Size(176, 23);
            this.coPayInput.TabIndex = 29;
            this.coPayInput.Text = "2.5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(529, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Copay (%):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(626, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 30;
            // 
            // InsuranceInputValue
            // 
            this.InsuranceInputValue.BackColor = System.Drawing.SystemColors.MenuBar;
            this.InsuranceInputValue.Enabled = false;
            this.InsuranceInputValue.Location = new System.Drawing.Point(600, 170);
            this.InsuranceInputValue.Name = "InsuranceInputValue";
            this.InsuranceInputValue.Size = new System.Drawing.Size(176, 23);
            this.InsuranceInputValue.TabIndex = 35;
            this.InsuranceInputValue.Text = "$0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(529, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Insurance:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(626, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 15);
            this.label14.TabIndex = 33;
            // 
            // expensesInputValue
            // 
            this.expensesInputValue.Location = new System.Drawing.Point(602, 52);
            this.expensesInputValue.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.expensesInputValue.Name = "expensesInputValue";
            this.expensesInputValue.Size = new System.Drawing.Size(176, 23);
            this.expensesInputValue.TabIndex = 36;
            this.expensesInputValue.ThousandsSeparator = true;
            this.expensesInputValue.ValueChanged += new System.EventHandler(this.expensesInputValue_ValueChanged);
            // 
            // isOutPatient
            // 
            this.isOutPatient.AutoSize = true;
            this.isOutPatient.Location = new System.Drawing.Point(22, 236);
            this.isOutPatient.Name = "isOutPatient";
            this.isOutPatient.Size = new System.Drawing.Size(45, 19);
            this.isOutPatient.TabIndex = 37;
            this.isOutPatient.TabStop = true;
            this.isOutPatient.Text = "Out";
            this.isOutPatient.UseVisualStyleBackColor = true;
            this.isOutPatient.CheckedChanged += new System.EventHandler(this.isOutPatient_CheckedChanged);
            // 
            // outPatientForm
            // 
            this.outPatientForm.Controls.Add(this.contactPhoneValue);
            this.outPatientForm.Controls.Add(this.contactPhoneInput);
            this.outPatientForm.Controls.Add(this.contactLastNameInput);
            this.outPatientForm.Controls.Add(this.label16);
            this.outPatientForm.Controls.Add(this.contactFirstNameInput);
            this.outPatientForm.Controls.Add(this.label15);
            this.outPatientForm.Location = new System.Drawing.Point(104, 236);
            this.outPatientForm.Name = "outPatientForm";
            this.outPatientForm.Size = new System.Drawing.Size(685, 100);
            this.outPatientForm.TabIndex = 38;
            this.outPatientForm.TabStop = false;
            this.outPatientForm.Text = "Out Patient";
            // 
            // contactPhoneValue
            // 
            this.contactPhoneValue.Location = new System.Drawing.Point(128, 55);
            this.contactPhoneValue.Name = "contactPhoneValue";
            this.contactPhoneValue.Size = new System.Drawing.Size(160, 23);
            this.contactPhoneValue.TabIndex = 44;
            // 
            // contactPhoneInput
            // 
            this.contactPhoneInput.AutoSize = true;
            this.contactPhoneInput.CausesValidation = false;
            this.contactPhoneInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactPhoneInput.ForeColor = System.Drawing.Color.Black;
            this.contactPhoneInput.Location = new System.Drawing.Point(6, 58);
            this.contactPhoneInput.Name = "contactPhoneInput";
            this.contactPhoneInput.Size = new System.Drawing.Size(91, 15);
            this.contactPhoneInput.TabIndex = 43;
            this.contactPhoneInput.Text = "Contact Phone:";
            // 
            // contactLastNameInput
            // 
            this.contactLastNameInput.Location = new System.Drawing.Point(480, 22);
            this.contactLastNameInput.Name = "contactLastNameInput";
            this.contactLastNameInput.Size = new System.Drawing.Size(178, 23);
            this.contactLastNameInput.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.CausesValidation = false;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(358, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 15);
            this.label16.TabIndex = 41;
            this.label16.Text = "Contact Last Name:";
            // 
            // contactFirstNameInput
            // 
            this.contactFirstNameInput.Location = new System.Drawing.Point(128, 22);
            this.contactFirstNameInput.Name = "contactFirstNameInput";
            this.contactFirstNameInput.Size = new System.Drawing.Size(160, 23);
            this.contactFirstNameInput.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.CausesValidation = false;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "Contact First Name:";
            // 
            // isResidentPatient
            // 
            this.isResidentPatient.AutoSize = true;
            this.isResidentPatient.Location = new System.Drawing.Point(22, 362);
            this.isResidentPatient.Name = "isResidentPatient";
            this.isResidentPatient.Size = new System.Drawing.Size(70, 19);
            this.isResidentPatient.TabIndex = 39;
            this.isResidentPatient.TabStop = true;
            this.isResidentPatient.Text = "Resident";
            this.isResidentPatient.UseVisualStyleBackColor = true;
            this.isResidentPatient.CheckedChanged += new System.EventHandler(this.isResidentPatient_CheckedChanged);
            // 
            // AddPatient
            // 
            this.AddPatient.CausesValidation = false;
            this.AddPatient.Location = new System.Drawing.Point(22, 456);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Padding = new System.Windows.Forms.Padding(5);
            this.AddPatient.Size = new System.Drawing.Size(120, 41);
            this.AddPatient.TabIndex = 43;
            this.AddPatient.Text = "Add";
            this.AddPatient.UseVisualStyleBackColor = true;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // deletePatient
            // 
            this.deletePatient.CausesValidation = false;
            this.deletePatient.Location = new System.Drawing.Point(456, 456);
            this.deletePatient.Name = "deletePatient";
            this.deletePatient.Padding = new System.Windows.Forms.Padding(5);
            this.deletePatient.Size = new System.Drawing.Size(120, 41);
            this.deletePatient.TabIndex = 44;
            this.deletePatient.Text = "Delete";
            this.deletePatient.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.CausesValidation = false;
            this.updateButton.Location = new System.Drawing.Point(246, 456);
            this.updateButton.Name = "updateButton";
            this.updateButton.Padding = new System.Windows.Forms.Padding(5);
            this.updateButton.Size = new System.Drawing.Size(120, 41);
            this.updateButton.TabIndex = 45;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.CausesValidation = false;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 15);
            this.label19.TabIndex = 39;
            this.label19.Text = "Hospital Name:";
            // 
            // hospitalInput
            // 
            this.hospitalInput.Location = new System.Drawing.Point(103, 36);
            this.hospitalInput.Name = "hospitalInput";
            this.hospitalInput.Size = new System.Drawing.Size(236, 23);
            this.hospitalInput.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.CausesValidation = false;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(358, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 15);
            this.label18.TabIndex = 41;
            this.label18.Text = "Hospital Phone:";
            // 
            // hospitalPhoneInput
            // 
            this.hospitalPhoneInput.Location = new System.Drawing.Point(457, 36);
            this.hospitalPhoneInput.Name = "hospitalPhoneInput";
            this.hospitalPhoneInput.Size = new System.Drawing.Size(201, 23);
            this.hospitalPhoneInput.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hospitalPhoneInput);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.hospitalInput);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(104, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 77);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident";
            // 
            // clearForm
            // 
            this.clearForm.CausesValidation = false;
            this.clearForm.Location = new System.Drawing.Point(656, 456);
            this.clearForm.Name = "clearForm";
            this.clearForm.Padding = new System.Windows.Forms.Padding(5);
            this.clearForm.Size = new System.Drawing.Size(120, 41);
            this.clearForm.TabIndex = 46;
            this.clearForm.Text = "Clear";
            this.clearForm.UseVisualStyleBackColor = true;
            this.clearForm.Click += new System.EventHandler(this.clearForm_Click);
            // 
            // resultListView
            // 
            this.resultListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultListView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultListView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultListView.CausesValidation = false;
            this.resultListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultListView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.resultListView.Location = new System.Drawing.Point(32, 540);
            this.resultListView.Name = "resultListView";
            this.resultListView.RowTemplate.Height = 25;
            this.resultListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.resultListView.Size = new System.Drawing.Size(787, 214);
            this.resultListView.TabIndex = 47;
            this.resultListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultListView_CellContentClick);
            // 
            // InsuranceSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(868, 775);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.clearForm);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deletePatient);
            this.Controls.Add(this.AddPatient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.isResidentPatient);
            this.Controls.Add(this.outPatientForm);
            this.Controls.Add(this.isOutPatient);
            this.Controls.Add(this.expensesInputValue);
            this.Controls.Add(this.InsuranceInputValue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.percentageValue);
            this.Controls.Add(labelcopyV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.coPayInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(mobilePhonInput);
            this.Controls.Add(this.mobilePhoneInput);
            this.Controls.Add(this.homePhoneInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statePicker);
            this.Controls.Add(this.zipcodeInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expensesInput);
            this.Controls.Add(this.marriedInput);
            this.Controls.Add(this.marriedLabel);
            this.Controls.Add(this.isFemale);
            this.Controls.Add(this.isMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.label1);
            this.Name = "InsuranceSystem";
            this.Text = "CCHI Insurance Coverage System";
            ((System.ComponentModel.ISupportInitialize)(this.expensesInputValue)).EndInit();
            this.outPatientForm.ResumeLayout(false);
            this.outPatientForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox typeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton isMale;
        private System.Windows.Forms.RadioButton isFemale;
        private System.Windows.Forms.Label marriedLabel;
        private System.Windows.Forms.CheckBox marriedInput;
        private System.Windows.Forms.Label expensesInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox zipcodeInput;
        private System.Windows.Forms.ComboBox statePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox homePhoneInput;
        private System.Windows.Forms.Label mobilePhoneInput;
        public System.Windows.Forms.TextBox coPayInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelcopyV;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox InsuranceInputValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown expensesInputValue;
        private System.Windows.Forms.TextBox percentageValue;
        private System.Windows.Forms.RadioButton isOutPatient;
        private System.Windows.Forms.GroupBox outPatientForm;
        private System.Windows.Forms.TextBox contactFirstNameInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox contactLastNameInput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox contactPhoneValue;
        private System.Windows.Forms.Label contactPhoneInput;
        private System.Windows.Forms.RadioButton isResidentPatient;
        private System.Windows.Forms.Button AddPatient;
        private System.Windows.Forms.Button deletePatient;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox hospitalInput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox hospitalPhoneInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.DataGridView resultListView;
    }
}

