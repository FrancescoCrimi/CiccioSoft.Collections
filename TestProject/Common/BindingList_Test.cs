using CiccioSoft.Collections.Tests.BindingList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiccioSoft.Collections.Tests.Common
{


    public abstract class BindingList_Test<BL> where BL : BindingList<string>
    {
        public abstract BL BListFactory();
    }

    public class Suca : BindingList_Test<BindingList<string>>
    {
        public override BindingList<string> BListFactory()
        {
            return new BindingList<string>();
        }
    }
}
