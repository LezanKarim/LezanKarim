using UnityEngine.UI;
using UnityEngine;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Stats : MonoBehaviour
{
    public Text counterText;
    public Text ScoreText;
    public Text DeathText;


    public float counter;
    public float Score;

    void Start()
    {
        StartCoroutine(Wait());
    }
    void Update()
    {
        counterText.text = "Tid: " + counter.ToString();
        ScoreText.text = "Poeng: " + Score.ToString();
        DeathText.text = "Antall forsøk: " + GameObject.Find("Body").GetComponent<Respawn>().Deaths.ToString();

        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1);
        counter++;
        StartCoroutine(Wait1());
    }

    IEnumerator Wait1()
    {

        yield return new WaitForSeconds(1);
        counter++;
        StartCoroutine(Wait());
    }

}