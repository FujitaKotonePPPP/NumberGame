using UnityEngine;

public interface IOperator
{
    string GetOperator();

}

public class OperatorMultiply : MonoBehaviour, IOperator
{
    public string GetOperator() { return "*"; }
}

public class OperatorDivide : MonoBehaviour, IOperator
{
    public string GetOperator() { return "/"; }
}
public class OperatorPlus : MonoBehaviour, IOperator
{
    public string GetOperator() { return "+"; }
}

public class OperatorMinus : MonoBehaviour, IOperator
{
    public string GetOperator() { return "-"; }
}
