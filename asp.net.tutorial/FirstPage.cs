using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Toktuff {
    public class FirstPage : Page {

       	public TextBox textBox1;
	
	protected void Page_Load(object sender, EventArgs e) {
	    Response.Write("Hello textBox1 is null?");
	    textBox1.Text = "testing";
	}
    }
}