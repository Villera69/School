public class Student : Person
{
    String program;
    int year;
    double fee;

    public Student(String name, String address, String program, int year, double fee){
        this.name = name;
        this.address = address;
        this.program = program;
        this.year = year;
        this.fee = fee;
    }

    public String GetProgram(){
        return program;
    }

    public void SetProgram(String program){
        this.program = program;
    }

    public int GetYear(){
        return year;
    }

    public void SetYear(int year){
        this.year = year;
    }

    public double GetFee(){
        return fee;
    }

    public void SetFee(double fee){
        this.fee = fee;
    }

    public override String ToStringer(){
        return $"Student[Person[name = {name}, address = {address}], program = {program}, year = {year}, fee = {fee}]";
    }
}