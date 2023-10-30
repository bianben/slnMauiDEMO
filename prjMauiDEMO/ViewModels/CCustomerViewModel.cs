using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjMAUIDEMO.Models;

namespace prjMAUIDEMO.ViewModels
{
    public class CCustomerViewModel:INotifyPropertyChanged
    {
        private List<CCustomer> _list = new List<CCustomer>();
        private int _position;

        public event PropertyChangedEventHandler PropertyChanged;

        public CCustomerViewModel()
        {
            loadData();
        }
        public CCustomer current { get { return _list[_position]; } }
        public List<CCustomer> all { get { return _list; } }

        private void loadData()
        {
            _list.Add(new CCustomer() { id = 1, address = "Taipei", email = "john@gmail.com", name = "John", phone = "0955312654" });
            _list.Add(new CCustomer() { id = 2, address = "Taoyuan", email = "peggy@gmail.com", name = "Peggy", phone = "0934212336" });
            _list.Add(new CCustomer() { id = 5, address = "Taipei", email = "wman@gmail.com", name = "Wman", phone = "0980556221" });
        }
        public void moveFirst()
        {
            _position = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void movePrevious()
        {
            _position--;
            if (_position < 0) _position = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveNext()
        {
            _position++;
            if (_position > _list.Count - 1) _position = _list.Count - 1;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveLast()
        {
            _position = _list.Count - 1;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveTo(int to)
        {
            _position = to;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }

        public CCustomer queryByKeyword(string keyword)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (
                    _list[i].name.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].address.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].email.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].phone.ToUpper().Contains(keyword.ToUpper())
                    )
                {
                    _position = i;
                    PropertyChanged(this, new PropertyChangedEventArgs("current"));
                    return _list[i];
                }
            }
            return null;
        }
    }
}
