<%@ Page Language="C#" MasterPageFile="master1.master" Inherits="Toktuff.FirstPage"%>

<asp:Content ContentPlaceHolderId="mainCPH" runat="server">
	<form id="mainForm" runat="server">
		<asp:RadioButtonList id="rb" runat="server"/>
		<asp:TextBox id=textBox1 runat="server"/>
		<p>
			<asp:Label id="label1" runat="server"/>
		</p>
		<p>
			<asp:RangeValidator
				runat="server"
				MinimumValue="1"
				MaximumValue="100"
				ControlToValidate="textBox1"
				Type="Integer"
				Text="Must be an integer between 1 and 100!"/>
		</p>
		<asp:Button id="button1" runat="server" Text="Submit!"/>
	</form>
</asp:Content>