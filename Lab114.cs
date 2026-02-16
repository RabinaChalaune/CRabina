using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Pkcs;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System;

namespace CRabina
{
    public partial class SimpleInterest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(Principle.Text);
            int r = Convert.ToInt32(Rate.Text);
            int t = Convert.ToInt32(Time.Text);
            int i = (p * t * r) / 100;
            Result.Text = i.ToString();
        }
    }
}

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleInterest.aspx.cs" Inherits="Lab3Asp.SimpleInterest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Interest</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text = "Principle : " runat="server" />
            <asp:TextBox ID = "Principle" runat="server" />
        </div>
        <div>
            <asp:Label Text = "Rate of Interest : " runat="server" />
            <asp:TextBox ID = "Rate" runat="server" />
        </div>
        <div>
            <asp:Label Text = "Time (in years) : " runat="server" />
            <asp:TextBox ID = "Time" runat="server" />
        </div>
        <div>
            <asp:Button ID = "Calculate" runat="server" Text="Calculate" OnClick="Calculate_Click" />
        </div>
        <div>
            <asp:Label Text = "Result : " runat="server" />
            <asp:TextBox ID = "Result" runat="server" />
        </div>
    </form>
</body>
</html>