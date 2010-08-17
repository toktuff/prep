using System;

namespace Toktuff {
    public class FirstPage : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
	    Response.Write("Hello from codebehind!!");
	}
    }
}