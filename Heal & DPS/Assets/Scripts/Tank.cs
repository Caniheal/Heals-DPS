using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tank : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public AudioSource healSound;

    public Health healthBar;
  //  float startTime = Time.time;
//    float curTime = Time.time - startTime;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        InvokeRepeating("TakeDamage", 2f, 2f);
        
    }
    void TakeDamage()
    {
        currentHealth -= 20;

        healthBar.SetHealth(currentHealth);
    }

    public void Heal()
    {
        currentHealth += 5;

        healthBar.SetHealth(currentHealth);

        healSound.Play();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene("Game 1");
        }
    }
}
