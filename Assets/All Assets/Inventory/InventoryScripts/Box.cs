using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject currentObject; // 拖动到框中的对象

    public string GetContent()
    {
        if (currentObject != null)
        {
            // 获取当前对象的数值或符号
            if (currentObject != null && currentObject.TryGetComponent<INumber>(out INumber numberComponent))
            {
                return numberComponent.GetNumber().ToString();
            }
            else if (currentObject != null && currentObject.TryGetComponent<IOperator>(out IOperator oper))
            {
                return oper.GetOperator().ToString();
            }
        }
        return "";
    }
}