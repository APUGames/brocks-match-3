using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Manage the player's turn amount
    [SerializeField]
    private int turnsLeft;

    [SerializeField]
    private Text turnsLeftText;

    [SerializeField]
    private int matchesFound;

    [SerializeField]
    private GameObject gameOverPanel;

    [SerializeField]
    private GameObject winPanel;

    public GridController gridController;

    private bool gameOver;
    
    bool win;

    public int GetTurnsLeft()
    {

        return turnsLeft;

    }

    public void MinusOneTurn()
    {

        turnsLeft--;

    }

    void Start()
    {

        gridController = GetComponent<GridController>();

        gameOverPanel.SetActive(false);
        winPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (!gameOver)
        {

            if (turnsLeft <= 0)
            {

                gameOver = true;

                win = false;

                turnsLeftText.GetComponent<Text>().text = "0";

            }
            else if (gridController.matchesFound >= 5)
            {

                gameOver = true;

                win = true;

                turnsLeftText.GetComponent<Text>().text = "0";

            }
            else
            {

                turnsLeftText.GetComponent<Text>().text = turnsLeft.ToString();

            }

        }
        else
        {

            if (win)
            {

                winPanel.SetActive(true);

            }
            else
            {

                gameOverPanel.SetActive(true);

            }

            //IsGameOver();

        }

    }

    public bool IsGameOver()
    {

        return gameOver;

    }

}
