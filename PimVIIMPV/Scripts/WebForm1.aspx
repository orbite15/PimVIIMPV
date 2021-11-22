<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PimVIIMPV.Scripts.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro Pessoa</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Divisão do campos de cadastro da Pessoa  -->
        <div class="pessoa">
            <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Enabled="False"></asp:TextBox>
            <asp:Label ID="lblnome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
            <asp:Label ID="lblcpf" runat="server" Text="CPF"></asp:Label>
            <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
            
        </div>

        <div class="endereco">

            <asp:Label ID="lbllog" runat="server" Text="logradouro"></asp:Label>
            <asp:TextBox ID="txtlog" runat="server"></asp:TextBox>

            <asp:Label ID="lblnum" runat="server" Text="nº"></asp:Label>
            <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>

            <asp:Label ID="lblcep" runat="server" Text="cep"></asp:Label>
            <asp:TextBox ID="txtcep" runat="server"></asp:TextBox>

            <asp:Label ID="lblbairro" runat="server" Text="Bairro"></asp:Label>
            <asp:TextBox ID="txtbairro" runat="server"></asp:TextBox>

            <asp:Label ID="lblcidade" runat="server" Text="Cidade"></asp:Label>
            <asp:TextBox ID="txtcidade" runat="server"></asp:TextBox>

            <asp:Label ID="lblestado" runat="server" Text="Estado"></asp:Label>

            <asp:DropDownList ID="DDLestado" runat="server">
                <asp:ListItem>AC</asp:ListItem>
                <asp:ListItem>AL</asp:ListItem>
                <asp:ListItem>AP</asp:ListItem>
                <asp:ListItem>AM</asp:ListItem>
                <asp:ListItem>BA</asp:ListItem>
                <asp:ListItem>CE</asp:ListItem>
                <asp:ListItem>ES</asp:ListItem>
                <asp:ListItem>GO</asp:ListItem>
                <asp:ListItem>MA</asp:ListItem>
                <asp:ListItem>MT</asp:ListItem>
                <asp:ListItem>MS</asp:ListItem>
                <asp:ListItem>MG</asp:ListItem>
                <asp:ListItem>PA</asp:ListItem>
                <asp:ListItem>PB</asp:ListItem>
                <asp:ListItem>PR</asp:ListItem>
                <asp:ListItem>PE</asp:ListItem>
                <asp:ListItem>PI</asp:ListItem>
                <asp:ListItem>RJ</asp:ListItem>
                <asp:ListItem>RN</asp:ListItem>
                <asp:ListItem>RS</asp:ListItem>
                <asp:ListItem>RO</asp:ListItem>
                <asp:ListItem>RR</asp:ListItem>
                <asp:ListItem>SC</asp:ListItem>
                <asp:ListItem>SP</asp:ListItem>
                <asp:ListItem>SE</asp:ListItem>
                <asp:ListItem>TO</asp:ListItem>
                <asp:ListItem>DF</asp:ListItem>
            </asp:DropDownList>

        </div>
        <!-- Divisão dos botões na pagina  -->
        <div class="botao">
            <asp:Button ID="btninserir" runat="server" Text="Inserir" OnClick="btninserir_Click" />
            <asp:Button ID="btndelete" runat="server" Text="Deletar" OnClick="btndelete_Click" />
            <asp:Button ID="btnatualizar" runat="server" Text="Atualizar" OnClick="btnatualizar_Click" />
        </div>
        <div class="consulta">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" Height="173px" Width="450px" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                    <asp:BoundField DataField="cpf" HeaderText="cpf" SortExpression="cpf" />
                    <asp:BoundField DataField="logradouro" HeaderText="logradouro" SortExpression="nome" />
                    <asp:BoundField DataField="numero" HeaderText="numero" SortExpression="nome" />
                    <asp:BoundField DataField="cep" HeaderText="cep" SortExpression="nome" />
                    <asp:BoundField DataField="bairro" HeaderText="bairro" SortExpression="nome" />
                    <asp:BoundField DataField="cidade" HeaderText="cidade" SortExpression="nome" />
                    <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="nome" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:db_pessoaConnectionString %>" ProviderName="<%$ ConnectionStrings:db_pessoaConnectionString.ProviderName %>" 
                SelectCommand="Select ta.ID, ta.nome, ta.cpf
                , tb.logradouro, tb.numero , tb.cep, tb.bairro, tb.cidade, tb.estado
                From db_pessoa.tb_pessoa as ta 
                inner join tb_endereco as tb on ta.FK_id_end = tb.ID"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
