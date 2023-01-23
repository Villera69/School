
public class Person
{
    protected String name;
    protected String address;

    public Person(){}

    public Person(String name, String address){
        this.name = name;
        this.address = address;
    }

    public String GetName(){
        return name;
    }

    public String GetAddress(){
        return address;
    }

    public void SetAddress(String address){
        this.address = address;
    }

    public virtual String ToStringer(){
        return $"Person[name = {name}, address = {address}]";
    }
}