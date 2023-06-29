using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCount : MonoBehaviour
{
    public int Count;
    public int Score;

    public void IncrementKill()
    {
        Count++;
        Debug.Log($"Killed {Count} zombies so far");
    }

    public override string ToString()
    {
        return Count.ToString();
    }
    public void IncrementScore()
    {
        Score += 100;
        Debug.Log($"Killed {Score} zombies so far");
    }
    public string GetScoreString()
    {
        return Score.ToString();
    }

    
}
