using UnityEngine;

public class Excercise00 : MonoBehaviour
{
    //private int value01;

    //private int value02, value03, value04;

    //private int value05 = 10;

    //private int value06 = 10, value07 = 20, value08 = 30;

    //private void Awake()
    //{
    //    value01 = 1;
    //    value02 = 2;
    //    value03 = 3;
    //    value04 = 4;
    //}

    private int currentHP = 10;
    private readonly int maxHP = 100;
    private const int maxMP = 100;

    public Excercise00()
    {
        maxHP = 200;
    }

    private void Awake()
    {
        int currentMP = 50;

        currentHP = 35;
        //maxHP = 200;
        //maxMP = 200;

        Debug.Log(currentHP);
        Debug.Log(currentMP);
        Debug.Log(maxHP);
    }

    private void Update()
    {
        //currentMP = 100;
    }
}
