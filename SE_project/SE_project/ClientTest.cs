
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ClientTest : Test {



    public ClientTest(int id, string name, int type, double min, double max, int unit, int status) : base(id, name, type, min, max, unit, status)
    {
    }

    private int _orderID;

    private double _result;

    protected int OrderID { get => _orderID; set => _orderID = value; }
    protected double Result { get => _result; set => _result = value; }
}