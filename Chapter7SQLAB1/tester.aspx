<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tester.aspx.cs" Inherits="Chapter7SQLAB1.tester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                    <asp:GridView ID="GrdView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PATIENTID" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="PATIENTID" HeaderText="PATIENTID" ReadOnly="True" SortExpression="PATIENTID" />
                            <asp:BoundField DataField="FNAME" HeaderText="FNAME" SortExpression="FNAME" />
                            <asp:BoundField DataField="M_I" HeaderText="M_I" SortExpression="M_I" />
                            <asp:BoundField DataField="LNAME" HeaderText="LNAME" SortExpression="LNAME" />
                            <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                            <asp:BoundField DataField="GENDER" HeaderText="GENDER" SortExpression="GENDER" />
                            <asp:BoundField DataField="PHONE" HeaderText="PHONE" SortExpression="PHONE" />
                            <asp:BoundField DataField="STREET" HeaderText="STREET" SortExpression="STREET" />
                            <asp:BoundField DataField="CITY" HeaderText="CITY" SortExpression="CITY" />
                            <asp:BoundField DataField="STATE_ADD" HeaderText="STATE_ADD" SortExpression="STATE_ADD" />
                            <asp:BoundField DataField="ZIP" HeaderText="ZIP" SortExpression="ZIP" />
                            <asp:BoundField DataField="COUNTRY" HeaderText="COUNTRY" SortExpression="COUNTRY" />
                            <asp:BoundField DataField="INSURANCE" HeaderText="INSURANCE" SortExpression="INSURANCE" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LouisPharmacyConnectionString %>" ProviderName="<%$ ConnectionStrings:LouisPharmacyConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [PATIENTS]"></asp:SqlDataSource>
        </div>

    </form>
</body>
</html>
