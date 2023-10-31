using prjMAUIDEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMAUIDEMO.ViewModels
{
    public class CCustomerViewModel
    {
        private List<CCustomer> _list = new List<CCustomer>();
        public CCustomerViewModel()
        {
            LoadData();
        }
        private int _position = 0;


        public CCustomer current { get { return _list[_position]; } }

        public List<CCustomer> all { get { return _list; } }



        public void LoadData()
        {
            _list.Add(new CCustomer() { id = 1, name = "Tom", phone = "0910147258", email = "tom@gmail.com", address = "Taipei" });
            _list.Add(new CCustomer() { id = 2, name = "Storm", phone = "0910258369", email = "strom@gmail.com", address = "Keelung" });
            _list.Add(new CCustomer() { id = 3, name = "Steam", phone = "0910369147", email = "steam@gmail.com", address = "Taoyuan" });
        }

        public void moveFirst()
        {
            _position = 0;

        }

        public void movePrevious()
        {
            _position--;
            if (_position < 0)
                _position = 0;
        }
        public void moveNext()
        {
            _position++;
            if (_position >= _list.Count)
                _position = _list.Count - 1;
        }
        public void moveLast()
        {
            _position = _list.Count - 1;
        }

        public void moveTo(int to)
        {
            _position = to;
        }

        public CCustomer queryByKeyword(string keyword)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].name.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].phone.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].email.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].address.ToUpper().Contains(keyword.ToUpper()))
                {
                    _position = i;
                    return _list[i];
                }
            }
            return null;
        }
    }
}
