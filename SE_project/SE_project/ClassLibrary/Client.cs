
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Client : User {

    public Client(int id, string login, string password, string name, string surname, 
        DateTime birthdate, string email, string pesel = "0", string residence = "-", string phoneNum="-", bool status=true) : base(id, 0, login, password, name, surname, status, birthdate, pesel, residence, phoneNum)
    {
        Email = email;
        _orders = new List<Order>();
    }

    private  string _email;
    private List<Order> _orders;

    public string Email { get => _email; set => _email = value; }
    public List<Order> Orders { get => _orders; set => _orders = value; }

}