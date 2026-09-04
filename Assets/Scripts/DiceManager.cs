using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public int RollDice()
    {
        int die1 = Random.Range(1, 7);
        int die2 = Random.Range(1, 7);
        return die1 + die2;
    }
}
