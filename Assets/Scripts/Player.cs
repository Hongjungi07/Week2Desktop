using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName = "Noname";
    private int currentHP = 100;

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        Debug.Log(currentHP);
    }
}
