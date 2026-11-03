interface IOperator
{
    int Calculate(int a, int b);
}

class AddOperator : IOperator
{
    public int Calculate(int a, int b)
    {
        return a + b;
    }
}

class SubtractOperator : IOperator
{
    public int Calculate(int a, int b)
    {
        return a - b;
    }
}

class MultiplyOperator : IOperator
{
    public int Calculate(int a, int b)
    {
        return a * b;
    }
}

class Calculator
{
    private IOperator _operator;
    public Calculator(IOperator op)
    {
        _operator = op;
    }
    public void SetOperator(IOperator op)
    {
        _operator = op;
    }
    public int Calculate(int a, int b)
    {
        return _operator.Calculate(a, b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator(new AddOperator());
        Console.WriteLine(calculator.Calculate(5, 5));

        calculator.SetOperator(new SubtractOperator());
        Console.WriteLine(calculator.Calculate(10, 3));

        calculator.SetOperator(new MultiplyOperator());
        Console.WriteLine(calculator.Calculate(3, 3));
    }
}