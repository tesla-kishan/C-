class Program
{
    public static void Main(string[] args)
    {
        BankAccount acc1 = new BankAccount();
        acc1.AccNumber = 12345;
        Console.WriteLine("Account Number: " + acc1.AccNumber);
        // BankAccount B1 = new BankAccount();
        // B1.deposit(50000);
        // B1.deposit(40000);

        acc1.Deposit(50000);
        acc1.GetBalance();

        MathOps m1 = new MathOps();
        Console.WriteLine(m1.Add(1.2,2));  

        m1.person("kishan",21);

        // int []arr = {1,2,3};
        // foreach(int num in arr)
        // {
        //     Console.WriteLine(num);
        // }  

        // String s = "kishan";
        // foreach(char ch in s)
        // {
        //     Console.Write(ch + " ");
        // }


        // Console.WriteLine(sum(1,2,3,4));

        int x = 10;
        IncreasedBy10(ref x);
        Console.WriteLine(x);


        int q, r;   // no initialization required
        Divide(10, 3, out q, out r);
        Console.WriteLine("Quotient = " + q);
        Console.WriteLine("Remainder = " + r);

        Process();
        
    }
    // public static int sum(params int [] num)
    // params should be last and we cant use multiple params in singlr methods
    // {
    //     int total=0;
    //     foreach(int n in num){
    //         total+=n;
    //     }
    //     return total;
    // }


    public static void IncreasedBy10(ref int a)
    {
        a += 10;
    }

      public static void Divide(int a, int b, out int quotient, out int remainder)
    {
        quotient = a / b;
        remainder = a % b;
    }

        static void Process()
    {
        string status = "Processing...";

        void PrintMsg()
        {
            Console.WriteLine(status);
        }

        PrintMsg();
        calculator();
        Example();
    }

    static void calculator()
    {
        static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        static void Sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }

        Add(2,3);
        Sub(3,2);
    }

        static void Example()
    {
        int a=5;
        static int Square(int x)
        {
            return x * x;
        }
        Func<int, int> squareLambda = x => x * x;

        Console.WriteLine(Square(a));
        Console.WriteLine(squareLambda(a));
    }
}

