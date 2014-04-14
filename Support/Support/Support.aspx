<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Support.aspx.cs" Inherits="Support.Support" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div data-role="collapsible" data-collapsed="false">
        <h3>Ways to contact the developer:</h3>
        <p>
            <ul>
                <li>By Using the form below</li>
                <li>By mailing to:
                    <address>
                        6120 N. Colton #17
                        Spokane, WA 99208
                    </address>
                </li>
                <li>Smoke Signals</li>
            </ul>
        </p>
    </div>
    <div data-role="collapsible" data-collapsed="true">
        <h3>Contact form:</h3>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Your Email Adrress:"></asp:Label>
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" Width="349px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Your Question or Comment:"></asp:Label>
            <br />
            <asp:TextBox ID="txtQuestion" runat="server" Columns="50" Height="8em" Rows="10"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
    </div>
</asp:Content>
