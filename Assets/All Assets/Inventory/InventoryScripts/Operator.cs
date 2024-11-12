using UnityEngine;

public class Operator : MonoBehaviour, IOperator
{
    [SerializeField]
    private string operatorValue;

    public string GetOperator()
    {
        return operatorValue;
    }
}