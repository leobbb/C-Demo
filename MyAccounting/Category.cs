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

    class Item
    {
        private int _iId;
        private string _iName;

        public int IId
        {
            get { return this._iId; }
        }
        public string IName
        {
            get { return this._iName; }
        }

        public Item(int id, string name)
        {
            this._iId = id;
            this._iName = name;
        }

        public override string ToString()
        {
            return IName;
        }
    }
}
