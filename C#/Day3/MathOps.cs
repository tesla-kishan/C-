class MathOps
{
    public  int Add(int a,int b)
    {
        return a+b;
    }
    // public static int Add(int a,int b,int c)
    // {
    //     return a+b+c;
    // }
    public  double Add(double a,double b)
    {
        return a+b;
    }
    public void person(String name , int age , char gender='M')
    //cannnot use optional parameters earlier , it should be at last
    // first required parameters then optional parameters (assign before like gender= "M")
    // params cannot be used in ref in out
    {
        Console.WriteLine($"{name}: {age}");
    }
}