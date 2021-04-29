using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void PlayMusic()
    {
        FindObjectOfType<AudioManager>().Play("MainMusic");
    }

    public void PlayTension()
    {
        FindObjectOfType<AudioManager>().Play("Tension");
    }

    public void PlayVictory()
    {
        FindObjectOfType<AudioManager>().Play("Victory");
    }

    public void PlayGameOver()
    {
        FindObjectOfType<AudioManager>().Play("GameOver");
    }

    public void PlayBonus()
    {
        FindObjectOfType<AudioManager>().Play("Bonus");
    }

    public void PlayInstructions()
    {
        FindObjectOfType<AudioManager>().Play("Instructions");
    }

    public void PlayCartoon()
    {
        FindObjectOfType<AudioManager>().Play("Cartoon");
    }

    public void PlayMonster()
    {
        FindObjectOfType<AudioManager>().Play("Monster");
    }

    public void UpdateMusicVolume()
    {
        
    }

}
