using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneManager : MonoBehaviour
{
    private List<string> runes;

    void Awake()
    {
        runes = new List<string>();
    }

    public void AddRune(string rune)
    {
        runes.Add(rune);
    }

    public void RemoveRune(string rune)
    {
        runes.Remove(rune);
    }

    public List<string> GetRunes()
    {
        return runes;
    }
}