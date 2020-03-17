public class Customer{
    private int _id;
    private string _firstName;
    private string _lastName;
    private string _phone;
    private string _email;
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public int Id {
        get{
            return _id;
        }
    }

    public string FirstName { 
        get{
            return _firstName;
        }
        set{
            _firstName = value;
        }
    }

    public string LastName { 
         get{
             return _lastName;
         }
         set{
             _lastName = value;
         }
    }

    public string Phone { 
          get{
              return _phone;
          }
          set{
              _phone = value;
          }
    }

    public string Email { 
        get{
            return _email;
        }
        set{
            _email = value;
        }
    }

    public string Street {
        get{
            return _street;
        }
        set{
            _street = value;
        }
    }

    public string City {
        get{
            return _city;
        }
        set{
            _city = value;
        }
    }

    public string State {
        get{
            return _state;
        }
        set{
            _state = value;
        }
    }

    public string ZipCode {
        get{
            return _zipCode;
        }
        set{
            _zipCode = value;
        }
    }
}