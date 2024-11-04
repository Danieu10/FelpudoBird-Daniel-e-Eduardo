using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public TextMeshProUGUI pontuacaotexto;
    public float pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            pontuacao += 1 * Time.deltaTime;
            pontuacaotexto.text = "Pontos: " + ((int)pontuacao).ToString();

            if (pontuacao>=20)
            {
                SceneManager.LoadScene("uruca");
            }
        }
    }
}
