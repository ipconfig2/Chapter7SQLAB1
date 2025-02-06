<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentNew.aspx.cs" Inherits="Chapter7SQLAB1.StudentNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<p>Student_ID:</p><asp:TextBox ID="txtSTUDENTID" runat="server"></asp:TextBox> <br />
<p>First Name:</p><asp:TextBox ID="txtFNAME" runat="server"></asp:TextBox> <br />
<p>Last Name:</p><asp:TextBox ID="txtLNAME" runat="server"></asp:TextBox><br />
<p>Date of Birth:</p><asp:TextBox ID="txtddob" runat="server"></asp:TextBox><br />
<p>Gender:</p><asp:TextBox ID="txtGender" runat="server"></asp:TextBox><br />
<p>Account Balance:</p><asp:TextBox ID="txtAcc" runat="server"></asp:TextBox><br />
<p>Major:</p><asp:TextBox ID="txtMajor" runat="server"> </asp:TextBox> <br />
<p>Home_Phone:</p><asp:TextBox ID="txtHome_Phone" runat="server"> </asp:TextBox> <br />
<p>Cell_Phone:</p><asp:TextBox ID="txtCell_Phone" runat="server"> </asp:TextBox> <br />
<p>Work_Phone:</p><asp:TextBox ID="txtWork_Phone" runat="server"> </asp:TextBox> <br />
<p>Address_One:</p><asp:TextBox ID="txtAddress" runat="server"> </asp:TextBox> <br />
<p>CITY:</p><asp:TextBox ID="txtCity" runat="server"> </asp:TextBox> <br />
<p>State:</p><asp:TextBox ID="txtState" runat="server"> </asp:TextBox> <br />
<p>ZIP:</p><asp:TextBox ID="txtZip" runat="server"> </asp:TextBox> <br />
<p>TotalCredits:</p><asp:TextBox ID="txtTotalCredits" runat="server"> </asp:TextBox> <br />
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
<input type="reset" />
<asp:Button ID="btnClose" runat="server" Text="Close"/>
        </div>
    </form>
</body>
</html>
