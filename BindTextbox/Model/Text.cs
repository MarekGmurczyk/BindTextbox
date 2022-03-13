using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindTextbox.Model
{
    class Text
    {
        private string _text = "My private text.";
        public string MyText
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }           
        }
        private void ModifiedText()
        {
            MyText = _text;
        }
    }
}
