using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class EquationManager : MonoBehaviour
{
    public List<Box> boxes; // ���п���б�

    public void CalculateExpression()
    {
        string expression = "";
        foreach (Box box in boxes)
        {
            expression += box.GetContent();
        }
        Debug.Log("Expression: " + expression);

        // ������ʽ���
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
        // ʹ�ü򵥵��㷨�����ͼ�����ʽ
        // ����ʹ�� NCalc ������ƵĹ����������ӵı��ʽ
        System.Data.DataTable table = new System.Data.DataTable();
        return double.Parse(table.Compute(expression, "").ToString());
    }
}