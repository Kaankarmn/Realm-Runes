using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    // Combo variables
    private int comboCount = 0;
    private float comboTimer = 0f;
    private float comboDuration = 1f; // Time window to reset combo

    // Spell variables
    private List<string> spellList = new List<string> { "Fireball", "Ice Blast", "Lightning Strike" };

    void Update()
    {
        // Check for input to increase combo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseCombo();
        }

        // Update combo timer
        if (comboCount > 0)
        {
            comboTimer += Time.deltaTime;
            if (comboTimer > comboDuration)
            {
                ResetCombo();
            }
        }
    }

    private void IncreaseCombo()
    {
        comboCount++;
        comboTimer = 0f;
        Debug.Log("Combo Count: " + comboCount);

        // Example of using a specific combo mechanic when reaching a certain count
        if (comboCount >= 3)
        {
            ExecuteCombo();
        }
    }

    private void ResetCombo()
    {
        comboCount = 0;
        Debug.Log("Combo Reset.");
    }

    private void ExecuteCombo()
    {
        Debug.Log("Combo Executed!" + " Total Hits: " + comboCount);
        ResetCombo();
    }

    public void CastSpell(int spellIndex)
    {
        if (spellIndex < 0 || spellIndex >= spellList.Count)
        {
            Debug.LogError("Invalid spell index");
            return;
        }
        Debug.Log("Casting spell: " + spellList[spellIndex]);
        // Add logic to cast the spell
    }
}
