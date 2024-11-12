using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject currentObject; // �϶������еĶ���

    public string GetContent()
    {
        if (currentObject != null)
        {
            // ��ȡ��ǰ�������ֵ�����
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