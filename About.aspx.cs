using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitHubNet
{
    public partial class About : System.Web.UI.Page
    {
        protected string testContent;

        protected void Page_Load(object sender, EventArgs e)
        {

            testContent = "Hello GitHub.";
        }
    }
}
