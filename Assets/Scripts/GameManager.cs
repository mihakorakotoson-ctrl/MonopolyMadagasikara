using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController player1;
    public BoardManager board;
    public DiceManager dice;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // touche espace = lancer les dés
        {
            int roll = dice.RollDice();
            player1.Move(roll, board.boardSpaces.Count);
            Debug.Log(player1.playerName + " avance de " + roll + 
                      " cases et arrive sur " + board.boardSpaces[player1.position]);
        }
    }
}
