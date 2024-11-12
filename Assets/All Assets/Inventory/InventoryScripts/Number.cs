using UnityEngine;

public class Number : MonoBehaviour, INumber
{
    [SerializeField]
    private int numberValue;

    public int GetNumber()
    {
        return numberValue;
    }
}