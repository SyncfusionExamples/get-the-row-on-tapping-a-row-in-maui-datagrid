# Get the Row Details on Tapping a row in MAUI DataGrid
In.NET [MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) (SfDataGrid), you can get the [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCellTappedEventArgs_RowData) while tapping a row by using the [SfDataGrid.CellTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTapped) event. It provides the RowData in its argument. Thus, using the RowData you can get the Row Details of the tapped cell in [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html).

Refer the below code example in which the CellTapped event is hooked in SfDataGrid.

## C#
```C#
private void dataGrid_CellTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs e)
{
    var empdata = (Employee)e.RowData;
    DisplayAlert("Setected Row Data",
        "Employee ID        : " + empdata.EmployeeID.ToString() +
        "\nEmployee Name    : " + empdata.Name.ToString() +
        "\nID Number        : " + empdata.IDNumber.ToString() +
        "\nTitle            : " + empdata.Title.ToString() +
        "\nContact ID       : " + empdata.ContactID.ToString() +
        "\nBirth Date       : " + empdata.BirthDate.ToString(“d”) +
        "\nMarital Status   : " + empdata.MaritalStatus.ToString() +
        "\nGender           : " + empdata.Gender.ToString() +
        "\nHire Date        : " + empdata.HireDate.ToString(“d”) +
        "\nSick Leave Hours : " + empdata.SickLeaveHours.ToString() +
        "\nSalary           : " + empdata.Salary.ToString() +
        "\nLogin ID         : " + empdata.LoginID.ToString() +
        "\nManager ID       : " + empdata.ManagerID.ToString() +
        "\nEmployee Status  : " + empdata.EmployeeStatus.ToString() +
        "\nRating           : " + empdata.Rating.ToString(),
        "Cancel");
}
```
## XAML
```XAML
<ContentPage.BindingContext>
        <local:EmployeeViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>

    <syncfusion:SfDataGrid x:Name ="dataGrid"
                    ItemsSource="{Binding Employees}" CellTapped="dataGrid_CellTapped">
    </syncfusion:SfDataGrid>
```
The following screenshot shows the Column header with different background,

![different Background Color for each column header in SfDataGrid](SeletecRowData.png)

Take a moment to pursue this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples.
Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid(SfDataGrid).
### Conclusion
I hope you enjoyed learning about how to bind DataTable collection to MAUI DataGrid (SfDataGrid).
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to know about its other groundbreaking feature representations. You can also explore our .NET MAUI DataGrid Documentation to understand how to present and manipulate data.
For current customers, you can check out our .NET MAUI components from the [License and Downloads](https://www.syncfusion.com/account/downloads) page. If you are new to Syncfusion, you can try our 30-day free trial to check out our .NET MAUI DataGrid and other .NET MAUI components.
If you have any queries or require clarifications, please let us know in comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/account/login?ReturnUrl=%2Faccount%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dc54e52f3eb3cde0c3f20474f1bc179ed%26redirect_uri%3Dhttps%253A%252F%252Fsupport.syncfusion.com%252Fagent%252Flogincallback%26response_type%3Dcode%26scope%3Dopenid%2520profile%2520agent.api%2520integration.api%2520offline_access%2520kb.api%26state%3D8db41f98953a4d9ba40407b150ad4cf2%26code_challenge%3DvwHoT64z2h21eP_A9g7JWtr3vp3iPrvSjfh5hN5C7IE%26code_challenge_method%3DS256%26response_mode%3Dquery) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid). We are always happy to assist you!
