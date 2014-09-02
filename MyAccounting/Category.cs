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

        public Category(int id)
        {
            this._cId = id;
            this._cName = "未定义";
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

    class Item : Category
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

        public Item(int cid, int iid, string name)
            : base(cid)
        {
            this._iId = iid;
            this._iName = name;
        }

        public override string ToString()
        {
            return IName;
        }
    }
}
