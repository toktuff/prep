<%@ Page Language="C#" %>

<script runat="server">
	protected void Page_Load() {
		Response.Write("Page_Load");
		textBox1.Text = "55";
	}

	protected void DoSubmit(object sender, EventArgs a) {
		Response.Write("<p>DoSubmit</p>");
	}
</script>

<html>
  <body bgcolor="yellow">
    <center>
      <h2>Hello W3Schools!</h2>
	<p> <%=System.DateTime.Now%> </p>
	<form id="mainForm" runat="server">
		<asp:TextBox id = "textBox1" runat="server"/>
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
</html>