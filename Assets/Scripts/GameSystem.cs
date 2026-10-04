using UnityEngine;

public class GameSystem : MonoBehaviour
{
    private void Awake()
    {
        Player player;

        player = GameObject.Find("PlayerObject").GetComponent<Player>();

        player.playerName = "고박사";

        player.TakeDamage(10);
    }
}
