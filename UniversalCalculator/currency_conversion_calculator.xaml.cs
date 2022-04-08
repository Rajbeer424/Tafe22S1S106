using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class currency_conversion_calculator : Page
	{
		public currency_conversion_calculator()
		{
			this.InitializeComponent();
		}
		private async void currencyButton_Click(object sender, RoutedEventArgs e)
		{
			double amount, totalConversionAmount;
			// declare variables
			// Using Try catch block to catch exceptions like vehicle price should be in numeric format
			try
			{
				amount = double.Parse(amountTextBox.Text);
			}
			catch (Exception exception)
			{
				// catch the exception and generate message
				var dialogMessage = new MessageDialog("Please Enter the Valid Amount  " + exception.Message);
				await dialogMessage.ShowAsync();
				amountTextBox.Focus(FocusState.Programmatic);
				amountTextBox.SelectAll();
				return;
			}
			totalConversionAmount = CalcCurrency(amount);
			outputTextBlock.Text = "\n" + amountTextBox.Text + " US Dollars = \n"
												 + totalConversionAmount.ToString() + "British Pound";

		}

		private double CalcCurrency(double cAmount)
		// methhod for currency conversion
		{
			double totalAmount = 0;
			if (fromComboBox.SelectedIndex == 0 && toComboBox.SelectedIndex == 0)
			// if combobox select first option then currency conversion 
			{
				totalAmount = cAmount * 0.72872436;
			}
			if (fromComboBox.SelectedIndex == 0 && toComboBox.SelectedIndex == 1)
			// if combobox select second then currency conversion 
			{
				totalAmount = cAmount * 74.257327;
			}
			if (fromComboBox.SelectedIndex == 0 && toComboBox.SelectedIndex == 3)
			// if combobox select third  currency conversion 
			{
				totalAmount = cAmount * 0.85189982;
			}
			if (fromComboBox.SelectedIndex == 1 && toComboBox.SelectedIndex == 0)
			// if combobox select first option then currency conversion 
			{
				totalAmount = cAmount * 0.8556672;
			}
			if (fromComboBox.SelectedIndex == 1 && toComboBox.SelectedIndex == 1)
			// if combobox select second then currency conversion 
			{
				totalAmount = cAmount * 87.00755;
			}
			if (fromComboBox.SelectedIndex == 1 && toComboBox.SelectedIndex == 2)
			// if combobox select third  currency conversion 
			{
				totalAmount = cAmount * 1.371907;
			}
			if (fromComboBox.SelectedIndex == 2 && toComboBox.SelectedIndex == 1)
			// if combobox select first option then currency conversion 
			{
				totalAmount = cAmount * 101.68635;
			}
			if (fromComboBox.SelectedIndex == 2 && toComboBox.SelectedIndex == 2)
			// if combobox select second then currency conversion 
			{
				totalAmount = cAmount * 1.371907;
			}
			if (fromComboBox.SelectedIndex == 2 && toComboBox.SelectedIndex == 3)
			// if combobox select third  currency conversion 
			{
				totalAmount = cAmount * 1.1686692;
			}
			if (fromComboBox.SelectedIndex == 3 && toComboBox.SelectedIndex == 0)
			// if combobox select third  currency conversion 
			{
				totalAmount = cAmount * 0.0098339397;
			}
			if (fromComboBox.SelectedIndex == 3 && toComboBox.SelectedIndex == 2)
			// if combobox select third  currency conversion 
			{
				totalAmount = cAmount * 0.011492628;
			}
			if (fromComboBox.SelectedIndex == 3 && toComboBox.SelectedIndex == 3)
			// if combobox select third  currency conversion 
			{
				totalAmount = cAmount * 0.013492774;
			}
			return totalAmount;
			// return totalAmount
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage));
		}

	}
}
