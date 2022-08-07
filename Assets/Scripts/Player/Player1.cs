using UnityEngine;
using TMPro;

public class Player1 : MonoBehaviour
{
    public GameLogic1 GameLogic1;
    public int HP = 10;
    public TMP_Text Lives;
    void Update()
    {
        Lives.text = HP.ToString();
        if (HP <= 0) GameLogic1.OnDeath();
    }
}
