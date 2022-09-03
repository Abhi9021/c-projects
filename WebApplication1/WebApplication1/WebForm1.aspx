<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    USERNAME:<asp:TextBox ID="txt1" runat="server" 
            BackColor="#3333CC" BorderColor="#66FFFF" BorderStyle="Solid" /><br />
    PASSWORD:<asp:TextBox ID="txt2" runat="server" 
            TextMode="Password" BackColor="#3333CC" BorderColor="#66CCFF" 
            BorderStyle="Solid" /><br />
   
    <asp:Button ID="btn1" Text="LOGIN"  runat="server" />
       <asp:Button ID="btn2" Text="RESET"  runat="server" />
    
    
    
    </div>
    </form>
</body>
</html>
