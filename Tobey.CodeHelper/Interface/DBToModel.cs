using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobey.CodeHelper.Interface
{
    public class DBToModel
    {

        public virtual void RazorEngineInit()
        {
            string templPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template");
            string AppTempl = File.ReadAllText(templPath + "/" + "AppTempl.txt");
            string ControllerTempl = File.ReadAllText(templPath + "/" + "ControllerTempl.txt");
            string RepositoryTempl = File.ReadAllText(templPath + "/" + "RepositoryTempl.txt");
            string IRepositoryTempl = File.ReadAllText(templPath + "/" + "IRepositoryTempl.txt");

            RazorEngine.Engine.Razor.Compile(AppTempl, "AppTempl");
            RazorEngine.Engine.Razor.Compile(ControllerTempl, "ControllerTempl");
            RazorEngine.Engine.Razor.Compile(RepositoryTempl, "RepositoryTempl");
            RazorEngine.Engine.Razor.Compile(IRepositoryTempl, "IRepositoryTempl");
        }
    }
}
