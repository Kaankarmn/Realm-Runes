using UnityEngine; // Add more using directives as needed

public class Creature : MonoBehaviour
{
    // Properties for creature attributes like health, damage, etc.
    public float health;
    public float damage;

    // Add methods such as attack, take damage, etc.

    public void Attack()
    {
        // Attack logic here
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Logic for creature death
    }
}