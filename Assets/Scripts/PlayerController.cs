using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public string playerName = "Rakotoson";
    public int money = 150000; // Ariary
    public int position = 0;
    public List<string> properties = new List<string>();

    public void Move(int steps, int boardSize)
    {
        position = (position + steps) % boardSize;
    }

    public void BuyProperty(string property, int cost)
    {
        if (money >= cost)
        {
            money -= cost;
            properties.Add(property);
        }
    }
}
