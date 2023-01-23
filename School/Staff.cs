using System.Reflection.Emit;
public class Staff : Person
{
    String school;
    double pay;
     public Staff(String name, String address, String school, double pay){
        this.name = name;
        this.address = address;
        this.school = school;
        this.pay = pay;
    }

    public String GetSchool(){
        return school;
    }

    public void SetSchool(String school){
        this.school = school;
    }

    public double GetPay(){
        return pay;
    }

    public void SetPay(double pay){
        this.pay = pay;
    }

    public override String ToStringer(){
        return $"Staff[Person[name = {name}, address = {address}], school = {school}, pay = {pay}]";
    }
}