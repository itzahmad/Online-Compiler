<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true"
    CodeBehind="WebForm1.aspx.cs" Inherits="WebSharpCompiler.WebForm1" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 style="background-color: #FFFFFF">Code</h2>
    <p>
        
        <asp:TextBox ID="txtCode" runat="server" Height="240px" Width="100%" 
            TextMode="MultiLine" CssClass="auto-style1" OnTextChanged="txtCode_TextChanged" BackColor="#004040" BorderColor="#400040" ForeColor="Silver"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnCompile" runat="server" onclick="btnCompile_Click" Text="Compile" />
        <asp:Button ID="btnClear" runat="server"  onclick="btnClear_Click" Text="Clear" />
    </p>
    <h2>Compiler Output</h2>
    <p>
        <asp:ListBox ID="lstCompilerOutput" runat="server" Width="100%" OnSelectedIndexChanged="lstCompilerOutput_SelectedIndexChanged" BackColor="#004040" ForeColor="Silver"></asp:ListBox>
    </p>
</asp:Content>
