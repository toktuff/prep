<%@ Page Language="C#" MasterPageFile="master1.master" Inherits="Toktuff.FirstPage"%>

<script runat="server">
	protected void Page_Load() {
		Response.Write("Page_Load");
		if (!Page.IsPostBack) {
			string[] s = new string[] {
				"One", "Two", "Three"
			};
			rb.DataSource = s;
			rb.DataBind();
			rb.SelectedIndex = 0;
			
			textBox1.Text = "55";
		}
	}

	protected void DoSubmit(object sender, EventArgs a) {
		Response.Write("<p>DoSubmit</p>");
		label1.Text = "You entered: " + textBox1.Text + "(" + rb.SelectedItem.Text + ", " + rb.SelectedItem.Value + ")";
	}
</script>

<asp:Content ContentPlaceHolderId="mainCPH" runat="server">
  <body bgcolor="yellow">
    <center>
	<p> <%=System.DateTime.Now%> </p>
	<form id="mainForm" runat="server">
		<asp:RadioButtonList id="rb" runat="server"/>
		<asp:TextBox id="textBox1" runat="server"/>
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
		<asp:Button id="button1" runat="server" Text="Submit!" OnClick="DoSubmit"/>
	</form>
    </center>
  </body>
</asp:Content>