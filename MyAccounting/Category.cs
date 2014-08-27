using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting
{
    class Category
    {
        private int _cId;
        private string _cName;

        public int CId
        {
            get { return _cId; }
        }

        public string CName
        {
            get { return _cName; }
        }

        public Category(int id, string name)
        {
            this._cId = id;
            this._cName = name;
        }

        public override string ToString()
        {
            return this._cName;
        }
    }
}
