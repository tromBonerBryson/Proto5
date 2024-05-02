using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    public int difficulty;
    private GameManager gameManager;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    // Update is called once per frame
    void SetDifficulty()
    {
        
        Debug.Log(gameObject.name + "was clicked");
        gameManager.StartGame(difficulty);
    }
}
