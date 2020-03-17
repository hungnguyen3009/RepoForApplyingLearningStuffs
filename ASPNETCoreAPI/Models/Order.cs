using System;

public class Order
{
    private int _id;
    private string _status;
    private DateTime _orderDate;
    private DateTime _requiredDate;
    private DateTime _shippedDate;

    public int Id {
        get{
            return _id;
        }
        set{
            _id = value;
        }
    }
}