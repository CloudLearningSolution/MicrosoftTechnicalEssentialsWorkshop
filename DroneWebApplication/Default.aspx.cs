using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DroneDAL.Models;
using DroneDAL.Repos;
using DroneDAL.EF;
using DroneDAL;

namespace DroneWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
 
        public IEnumerable<Inventory> GetData()
        {
            /// <summary>
            /// TODO 1: Exercise 1:Debugging and Tracing WebSitePages
            ///         Task 1: Review and enable debugging
            ///             1. Navigate using Solution Explorer and select the Web.config file.
            ///             2. Locate markup syntax labeled debug.
            ///             3. Enable debug
            ///         Task 2: Add custom trace message
            ///             4. Call the static Trace.Write() method.
            ///             5. Provide 2 arguments, enter the name of your custom category; The second argument is the trace message.
            ///             6. Update the GetData method with your code statement. Read the WHERE TO CODE instruction below. .
            ///             7. Remove the comments and the syntax before saving your edits.
            ///             
            /// Instructor notes: Add the following method to the SOLUTION file, Trace.Write("Default.aspx", "Retrieving Trace Data")
            /// </summary>
            /// <returns></returns>
            // WHERE TO CODE: Place cursor at the end of this sentence and then Press Enter.

            return new InventoryRepo().GetAll();
        }
    }
}