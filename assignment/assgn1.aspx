<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assgn1.aspx.cs" Inherits="assignment.assgn1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-left: 0px;
        }
        .auto-style4 {
            width: 100%;
            height: 846px;
        }
        .auto-style8 {
            height: 33px;
            width: 275px;
        }
        .auto-style9 {
            height: 350px;
            width: 280px;
        }
        .auto-style10 {
            height: 350px;
        }
        .auto-style12 {
            height: 33px;
            width: 612px;
        }
        .auto-style13 {
            width: 612px;
        }
        .auto-style14 {
            width: 275px;
        }
        .auto-style15 {
            width: 275px;
            height: 26px;
        }
        .auto-style16 {
            width: 612px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">
                        <asp:Panel ID="Panel1" runat="server" Height="889px" Width="789px">
                            <table class="auto-style4">
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label14" runat="server" Text="Name"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox8" ErrorMessage="must be enter the name"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label15" runat="server" Text="Address"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label16" runat="server" Text="Age"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="age between 18 to 35" MaximumValue="35" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label17" runat="server" Text="Phone"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                                        <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="must be 10 digits" MaximumValue="10" MinimumValue="10" Type="Integer"></asp:RangeValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label18" runat="server" Text="Email"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox4" ErrorMessage="must be enter the email"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label19" runat="server" Text="Gender"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                                            <asp:ListItem Value="1">Female</asp:ListItem>
                                            <asp:ListItem Value="2">Male</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label20" runat="server" Text="State"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:DropDownList ID="DropDownList2" runat="server">
                                            <asp:ListItem Value="1">Ernakulam</asp:ListItem>
                                            <asp:ListItem Value="2">Kottayam</asp:ListItem>
                                            <asp:ListItem Value="3">Tvm</asp:ListItem>
                                            <asp:ListItem Value="4">Kollam</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label21" runat="server" Text="Qualification"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                                            <asp:ListItem Value="1">SSLC</asp:ListItem>
                                            <asp:ListItem Value="2">PLUS TWO</asp:ListItem>
                                            <asp:ListItem Value="3">UG</asp:ListItem>
                                            <asp:ListItem Value="4">PG</asp:ListItem>
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label22" runat="server" Text="Photo"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:FileUpload ID="FileUpload2" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label23" runat="server" Text="Username"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label24" runat="server" Text="Password"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox6" ErrorMessage="must be enter the password"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15"></td>
                                    <td class="auto-style16"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">
                                        <asp:Label ID="Label25" runat="server" Text="Confirm Password"></asp:Label>
                                    </td>
                                    <td class="auto-style13">
                                        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox7" ErrorMessage="must be enter same as password"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8"></td>
                                    <td class="auto-style12">
                                        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Display" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                    <td class="auto-style13">
                                        <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                    <td class="auto-style10"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style10"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
