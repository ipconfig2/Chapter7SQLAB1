<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Chapter7SQLAB1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <Script type="text/javascript">
        function SelectAll(id)

        var grid = document.getElementById("<%=grdStudent.ClientID %>");

        var cell;

        if (grid.rows.length > 0)
        {
            for (i = 1; i < grid.rows.length; i++)
            {
                cell = grid.rows[i].cells[0];

                for (j = 0; j < cell.childNodes.length; j++)
                {
                    if (cell.childNodes[j].type == "checkbox")
                    {
                        cell.childNodes[j].checked = document.getElementById(id).checked;
                    }
                }


            }
        }





    </Script>
<head runat="server">
    <title></title>
    <link href="main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
<tr>
<td style="width:15%" rowspan="3" valign="middle"> &nbsp;<asp:HyperLink 
        ID="hplNew" runat="server" Target="_blank" NavigateUrl="~/StudentNew.aspx?ID=0">New 
   Student</asp:HyperLink></td>

<td colspan="2" style="height: 20px; width: 538px;" > 
    <asp:Label ID="Label1" runat="server" Text="Search criteria" Font-Bold="True" Font-Size="Medium"></asp:Label>

</td>
</tr>
<tr>
<td colspan="2" style="width: 538px" >
    <asp:Panel ID="pnlSearch" runat="server" Width="100%">
        <table border="1" cellpadding="1" style="width: 100%; border-top-style: ridge; border-right-style: ridge; border-left-style: ridge; border-bottom-style: ridge;">
            <tr>
                <td style="width: 25%; height: 26px;">
                    Student ID:</td>
                <td style="border-style: ridge;" class="auto-style1">
        <asp:TextBox ID="txtStudentID" runat="server" MaxLength="6" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 25%">
                    First Name:</td>
                <td style="border-style: ridge;" class="auto-style2">
      <asp:TextBox ID="txtFName" runat="server" Width="80%"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 25%">
                    Last Name:</td>
                <td style="border-style: ridge;" class="auto-style2">
        <asp:TextBox ID="txtLName" runat="server" Width="80%"></asp:TextBox></td>
            </tr>
        </table>
    </asp:Panel>
</td>
</tr>
<tr >
<td colspan="2" align="center" style="width: 700px">
    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"  />
<asp:GridView ID="grdStudent" AutoGenerateColumns="False"  
    CssClass="GridView" runat="server" Width="100%" AllowPaging="True" 
        AllowSorting="True" OnSelectedIndexChanged="grdStudent_SelectedIndexChanged">
    <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="Go To First Page" LastPageText="Go To Last Page"
      Position="Top" 
         />
    <Columns>
       <asp:TemplateField HeaderText="Student ID" >
    
            <HeaderTemplate>
                <asp:CheckBox ID="cbSelectAll" runat="server"  />
                &nbsp;
                <asp:LinkButton ID="lbtnDelete" runat="server" OnCommand="Delete_Click" 
                    CommandName="lbtnDelete" CommandArgument='<%#Eval("STUDENT_ID") %>'>Delete</asp:LinkButton>
            </HeaderTemplate>
           

    <ItemTemplate> 
<asp:CheckBox ID="chkStudentID" runat="server" AutoPostBack="false" /> 
        <asp:Label ID="hidStudentID" runat="server" Text='<%#Eval("STUDENT_ID") %>' Visible="false"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
         <asp:BoundField DataField="STUDENT_ID" HeaderText="STUDENT_ID" SortExpression="STUDENT_ID" />
        <asp:BoundField DataField="fname" HeaderText="First Name" SortExpression="fname" />
        <asp:BoundField DataField="lname" HeaderText="Last Name" SortExpression="lname" />
  <asp:HyperLinkField DataNavigateUrlFields="STUDENT_ID" 
      DataNavigateUrlFormatString="Display.aspx?ID={0} &type=view"           
       HeaderText="View" Text="View" runat="server" Target="_blank" >  
                <HeaderStyle HorizontalAlign="Left" />
            </asp:HyperLinkField>
 <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:LinkButton ID="lbtnEdit" runat="server" 
                OnCommand="lbtnEdit_Click" CommandName="lbtnEdit" 
                CommandArgument='<% # Eval  ("STUDENT_ID") %>'>Edit</asp:LinkButton>&nbsp;&nbsp;
                <asp:ImageButton ID="imgDelete" runat="server" CommandArgument='<% # Eval  ("STUDENT_ID") %>' OnCommand="Delete_Click"   
              CommandName="lbtnDelete" ImageUrl="~/images/delete.jpg" Height ="30"  Width ="30" />||
           <asp:ImageButton ID="imgEdit" runat="server" CommandArgument='<% # Eval  ("STUDENT_ID") %>' OnCommand="lbtnEdit_Click"   
              CommandName="lbtnEdit" ImageUrl="~/images/edit.png" Height ="30"  Width ="30" />
           
           
                
                </ItemTemplate>
      <ItemTemplate>

          <asp:ImageButton ID="imgDelete" runat="server" CommandArgument='<% # Eval  ("STUDENT_ID") %>' OnCommand="Delete_Click"   
              CommandName="lbtnDelete" ImageUrl="~/images/delete.jpg" Height ="30"  Width ="30" />||
           <asp:ImageButton ID="imgEdit" runat="server" CommandArgument='<% # Eval  ("STUDENT_ID") %>' OnCommand="lbtnEdit_Click"   
              CommandName="lbtnEdit" ImageUrl="~/images/edit.png" Height ="30"  Width ="30" />
           
           
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
            
            </asp:TemplateField>
    
    </Columns>
    
     <EmptyDataTemplate>
                No Records Found Matching Your Search!
            </EmptyDataTemplate>
    
    </asp:GridView>
 
    </td>  
  </tr>
  
<tr>
<td colspan="3" style="width: 100%">
    &nbsp;</td>

</tr>
</table>


        </div>
    </form>
</body>
</html>
