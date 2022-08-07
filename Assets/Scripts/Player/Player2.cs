using UnityEngine;
using TMPro;

public class Player2 : MonoBehaviour
{
    public GameLogic2 GameLogic2;
    public int HP = 10;
    public TMP_Text Lives;
    void Update()
    {
        Lives.text = HP.ToString();
        if (HP <= 0) GameLogic2.OnDeath();
    }
}
