using System.Xml.Linq;
using System;

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs"
Inherits="Lab3Asp.Registration" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Registration</title>
</head>
<body>
 <h1>Registration Form</h1>
 <form id="form1" runat="server">
 <span id="error_message" runat="server"></span>
 <div>
 <asp:Label Text = "Name" runat="server" />
 <asp:TextBox runat = "server" ID="txtName" />
 <span id="errName" runat="server"></span>
 <br />
 <asp:Label Text = "Email" runat="server" />
 <asp:TextBox runat = "server" ID="txtEmail" TextMode="Email" />
 <span id="errEmail" runat="server"></span>
 <br />
 <asp:Label Text = "Phone" runat="server" />
 <asp:TextBox runat = "server" ID="txtPhone" TextMode="Number" />
 <span id="errPhone" runat="server"></span>
 <br />
 <asp:Label Text = "DOB" runat="server" />
 <asp:TextBox runat = "server" ID="txtDOB" TextMode="Date" />
 <span id="errDOB" runat="server"></span>
 <br />
 <asp:Label Text = "Gender" runat="server" />
 <asp:RadioButtonList ID = "rdoGender" runat="server">
 <asp:ListItem Text = "Male" Value="Male" />
 <asp:ListItem Text = "Female" Value="Female" /> <asp:ListItem Text = "Others" Value="Others" />
 </asp:RadioButtonList >
 < span id = "errGender" runat = "server" ></ span >
 < br />
 < asp:Label Text = "Gender" runat="server" />
 <asp:RadioButtonList ID = "rdoMaritalStatus" runat="server">
 <asp:ListItem Text = "Married" Value="1" />
 <asp:ListItem Text = "Unmarried" Value="0" />
 </asp:RadioButtonList >
 < span id = "errMaritalStatus" runat = "server" ></ span >
 < br />
 < asp:Button Text = "Register" ID="btnSave" OnClick="Click_Register" runat="server" />
 </div>
 <span id="success" runat="server"></span>
 </form>
</body>
</html>

using System;
namespace Lab3Asp
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Click_Register(object sender, EventArgs e)
        {
            //reset error variable
            errName.InnerText = errEmail.InnerText = errPhone.InnerText = errDOB.InnerText =
           errMaritalStatus.InnerText = errGender.InnerText = "";
            //set error counter to 0
            int error = 0;
            //get form data into variable
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string dob = txtDOB.Text;
            string gender = rdoGender.Text;
            string marital_status = rdoMaritalStatus.Text;
            if (String.IsNullOrEmpty(name))
            {
                error++;
                errName.InnerText = "Enter Name";
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                error++;
                errPhone.InnerText = "Enter phone";
            }
            if (String.IsNullOrEmpty(email))
            {
                error++;
                errEmail.InnerText = "Enter Email";
            }
            if (String.IsNullOrEmpty(dob))
            {
                error++;
                errDOB.InnerText = "Enter DOB";
            }
            if (String.IsNullOrEmpty(gender))
            {
                error++;
                errGender.InnerText = "Select Gender";
            }
            if (String.IsNullOrEmpty(marital_status))
            {
                error++;
                errMaritalStatus.InnerText = "Select Martial Status";
            }
            if (error == 0)
            {
                success.InnerText = "Success...";
            }
            else
            {
                success.InnerText = "Failed...";
            }
        }
    }
}