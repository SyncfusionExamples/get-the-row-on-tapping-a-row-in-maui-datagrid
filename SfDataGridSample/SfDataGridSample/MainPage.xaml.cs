using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataGrid_CellTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs e)
        {
            var empdata = (Employee)e.RowData;
            DisplayAlert("Setected Row Data",
              "Employee ID           : " + empdata.EmployeeID.ToString() +
              "\nEmployee Name     : " + empdata.Name.ToString() +
              "\nID Number              : " + empdata.IDNumber.ToString() +
              "\nTitle                         : " + empdata.Title.ToString() +
              "\nContact ID               : " + empdata.ContactID.ToString() +
              "\nBirth Date                : " + empdata.BirthDate.ToString("d") +
              "\nMarital Status          : " + empdata.MaritalStatus.ToString() +
              "\nGender                    : " + empdata.Gender.ToString() +
              "\nHire Date                : " + empdata.HireDate.ToString("d") +
              "\nSick Leave Hours    : " + empdata.SickLeaveHours.ToString() +
              "\nSalary                      : " + empdata.Salary.ToString() +
              "\nLogin ID                  : " + empdata.LoginID.ToString() +
              "\nManager ID             : " + empdata.ManagerID.ToString() +
              "\nEmployee Status     : " + empdata.EmployeeStatus.ToString() +
              "\nRating                     : " + empdata.Rating.ToString(),
              "Cancel");
        }
    }
}
