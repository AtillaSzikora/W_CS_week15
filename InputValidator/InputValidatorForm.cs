﻿using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InputValidator {
	public partial class InputValidatorForm : Form {
		public InputValidatorForm () {
			InitializeComponent (); }

		private void btnSave_Click (object sender, System.EventArgs e) {
			if (!Regex.IsMatch(txtName.Text, @"^([A-Za-z]*\s*)*$")) 
				MessageBox.Show(@"The name is invalid (only alphabetical characters are allowed)"); 
			if (!Regex.IsMatch(txtPhone.Text, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$")) 
				MessageBox.Show(@"The phone number is not a valid US phone number"); 
			if (!Regex.IsMatch(txtEmail.Text, @"^([a-zA-Z0-9_\-” + @”\.]+)@((\[[0-9]{1,3}" +
				@"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
				@".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")) 
				MessageBox.Show(@"The e-mail address is not valid.");
			txtPhone.Text = ReformatPhone(txtPhone.Text); }

		static string ReformatPhone(string s) { 
			Match m = Regex.Match(s, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");
			return $"({m.Groups[1]}) {m.Groups[2]}-{m.Groups[3]}"; }
	}
}