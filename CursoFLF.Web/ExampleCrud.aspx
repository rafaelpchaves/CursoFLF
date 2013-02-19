<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExampleCrud.aspx.cs" Inherits="CursoFLF.Web.ExampleCrud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table width="80%" cellspacing="1" cellpadding="5" style="background: #ccc">
        <tr style="background: #fff">
            <td colspan="2">
                <strong>Gerenciamento de Clientes</strong>
            </td>
        </tr>
        <tr style="background: #fff">
            <td colspan="2">
                <asp:Label ID="statusLabel" runat="server" Text="" ForeColor="Red">
                </asp:Label>
            </td>
        </tr>
        <tr style="background: #fff">
            <td colspan="2">
                <asp:GridView ID="grid"
                    runat="server"
                    DataKeyNames="StudentId"
                    OnSelectedIndexChanging="grid_SelectedIndexChanging"
                    OnRowDeleting="grid_RowDeleting"
                    AutoGenerateColumns="false"
                    Width="100%">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <table width="100%" cellpadding="5" cellspacing="1">
                                    <tr>
                                        <td align="center" style="width: 5%;">&nbsp;                                  
                                        </td>
                                        <td align="center" style="width: 5%;">&nbsp;
                                        </td>
                                        <td align="left" style="width: 15%">Name
                                        </td>
                                        <td align="left" style="width: 15%">Address
                                        </td>
                                        <td align="left" style="width: 15%">Birthdate
                                        </td>
                                        <td align="left" style="width: 10%">Photo
                                        </td>
                                        <td align="left" style="width: 20%">Email
                                        </td>
                                        <td align="left" style="width: 15%">Mobile
                                        </td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table width="100%" cellpadding="0" cellspacing="1">
                                    <tr>
                                        <td align="center" style="width: 5%;">
                                            <asp:ImageButton ID="ImageButton1"
                                                runat="server" CommandName="Select"
                                                EnableTheming="false"
                                                ImageUrl="~/Images/edit.png"
                                                CausesValidation="false" />
                                        </td>
                                        <td align="center" style="width: 5%;">
                                            <asp:ImageButton ID="LinkButton2"
                                                runat="server"
                                                ImageUrl="~/Images/delete.png"
                                                CommandName="Delete"
                                                EnableTheming="false"
                                                CausesValidation="false" />
                                        </td>
                                        <td align="left" style="width: 15%">
                                            <asp:Label ID="lblName" runat="server"
                                                Text='<%# Eval("Name")%>'></asp:Label>
                                        </td>
                                        <td align="left" style="width: 15%">
                                            <asp:Label ID="lblAddress" runat="server"
                                                Text='<%# Eval("Address")%>'></asp:Label>
                                        </td>
                                        <td align="center" style="width: 15%">
                                            <asp:Label ID="lblBirthdate" runat="server"
                                                Text='<%# Eval("Birthdate")%>'></asp:Label>
                                        </td>
                                        <td align="center" style="width: 10%">
                                            <asp:Image ID="imgPhoto" runat="server" Width="30" Height="30"
                                                ImageUrl='<%# "~/Images/" + Eval("Image")%>' />
                                        </td>
                                        <td align="left" style="width: 20%">
                                            <asp:Label ID="lblEmail" runat="server"
                                                Text='<%# Eval("Email")%>'></asp:Label>
                                        </td>
                                        <td align="left" style="width: 15%">
                                            <asp:Label ID="lblMobile" runat="server"
                                                Text='<%# Eval("Mobile")%>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr style="background: #fff">
            <td>Name<asp:HiddenField ID="hdnId" runat="server" />
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="background: #fff">
            <td>Address
            </td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr style="background: #fff">
            <td>Birthdate
            </td>
            <td>
                <asp:TextBox ID="txtBirthdate" runat="server"></asp:TextBox>
                <asp:Calendar ID="calBirthdate" runat="server"
                    OnSelectionChanged="calBirthdate_SelectionChanged"></asp:Calendar>
            </td>
        </tr>
        <tr style="background: #fff">
            <td>Image
            </td>
            <td>
                <asp:Image ID="imgThumb" runat="server" Width="100" Height="100" />
                <asp:FileUpload ID="fupImage" runat="server" />
            </td>
        </tr>
        <tr style="background: #fff">
            <td>Email
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="background: #fff">
            <td>Mobile
            </td>
            <td>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr style="background: #fff">
            <td>Description
            </td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine">
                </asp:TextBox>
            </td>
        </tr>
        <tr style="background: #fff">
            <td>&nbsp;
            </td>
            <td>
                <asp:Button ID="btnAdd" ValidationGroup="add" OnClick="btnAdd_Click" runat="server" Text="Submit"></asp:Button>
                <asp:Button ID="btnReset" OnClick="btnReset_Click" runat="server" CausesValidation="false" Text="Reset"></asp:Button>
                <asp:Button ID="btnUpdate" ValidationGroup="add" OnClick="btnUpdate_Click" runat="server" Text="Update"></asp:Button>
                <asp:Button ID="btnCancel" CausesValidation="false" OnClick="btnCancel_Click" runat="server" Text="Cancel"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
