using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        System.Collections.IList visibleTables = MetaModel.Default.VisibleTables;
        if (visibleTables.Count == 0) {
            throw new InvalidOperationException("Não há tabelas acessíveis. Certifique-se de que pelo menos um modelo de dados esteja registrado em Global.asax e scaffolding esteja habilitado ou implemente páginas personalizadas.");
        }
        Menu1.DataSource = visibleTables;
        Menu1.DataBind();
    }

}
