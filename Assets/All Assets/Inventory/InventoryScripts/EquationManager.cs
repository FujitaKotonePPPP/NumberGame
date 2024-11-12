using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class EquationManager : MonoBehaviour
{
    public List<Box> boxes; // 所有框的列表

    public void CalculateExpression()
    {
        string expression = "";
        foreach (Box box in boxes)
        {
            expression += box.GetContent();
        }
        Debug.Log("Expression: " + expression);

        // 计算算式结果
        try
        {
            double result = EvaluateExpression(expression);
            Debug.Log("Result: " + result);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Failed to calculate the expression: " + e.Message);
        }
    }

    private double EvaluateExpression(string expression)
    {
        // 使用简单的算法解析和计算表达式
        // 可以使用 NCalc 库或类似的工具来处理复杂的表达式
        System.Data.DataTable table = new System.Data.DataTable();
        return double.Parse(table.Compute(expression, "").ToString());
    }
}