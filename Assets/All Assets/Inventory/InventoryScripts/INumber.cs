using UnityEngine;

public interface INumber
{
    int GetNumber();
}

// 让 NumberZero 到 NumberNine 实现 INumber 接口
public class NumberZero : MonoBehaviour, INumber
{
    public int GetNumber() { return 0; }
}

public class NumberOne : MonoBehaviour, INumber
{
    public int GetNumber() { return 1; }
}
public class NumberTwo : MonoBehaviour, INumber
{
    public int GetNumber() { return 2; }
}

public class NumberThree : MonoBehaviour, INumber
{
    public int GetNumber() { return 3; }
}
public class NumberFour : MonoBehaviour, INumber
{
    public int GetNumber() { return 4; }
}

public class NumberFive : MonoBehaviour, INumber
{
    public int GetNumber() { return 5; }
}
public class NumberSix : MonoBehaviour, INumber
{
    public int GetNumber() { return 6; }
}

public class NumberSeven : MonoBehaviour, INumber
{
    public int GetNumber() { return 7; }
}

public class NumberEight : MonoBehaviour, INumber
{
    public int GetNumber() { return 8; }
}

public class NumberNine : MonoBehaviour, INumber
{
    public int GetNumber() { return 9; }
}