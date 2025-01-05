using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton: to use methods from this class I don't need to get a component
    public static GameManager Instance; //Capitalize cause this is a static reference to my object

    private int playerPoints = 0;
    public int PlayerPoints { get => playerPoints; set => playerPoints = value; }

    [SerializeField] public int health = 5;

    private void Awake()
    {
        //PlayerPrefs.SetInt("health", health);
        //Singleton, reference Instance to this object instance
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            //assign the static instance to the object
            Instance = this;
            //maintain this instance to the next scene
            DontDestroyOnLoad(this.gameObject);
        }
    }
    private void Start()
    {
        PlayerPrefs.SetInt("health", health);
    }
    public static void SubstractInt(string key, int numberToSubstract)
    {
        //Check if the key exist
        if (PlayerPrefs.HasKey(key))
        {
            //Read old value
            int value = PlayerPrefs.GetInt(key);

            //De-Increment
            value -= numberToSubstract;

            //Save it back
            PlayerPrefs.SetInt(key, value);
        }
    }


}