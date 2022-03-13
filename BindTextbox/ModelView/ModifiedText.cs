using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindTextbox.Model;

namespace BindTextbox.ModelView
{
    class ModifiedText
    {
        private string _myText;
        public string TextFromModel
        {
            get
            {
                return PerformClass(_myText);
            }
            set
            {
                _myText = value;
            }
        }
        private string PerformClass(string _myText)
        {
            Text t = new Text();
            return t.MyText + _myText;
        }


    }
    
}
