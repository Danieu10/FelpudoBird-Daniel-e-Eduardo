using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueBosss : MonoBehaviour
{
    public GameObject inimigo;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float tempoentreinimigos;
    float tempospawn;
    float tempo;
    public float velocidademovimento;
    public GameObject telavitoria;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        tempo += 1 * Time.deltaTime;
       if (tempo < 10)
       {
            if (Time.time > tempospawn)
            {
                SpawnBoladefogo();
                tempospawn = Time.time + tempoentreinimigos;
            }
            Debug.Log("primeiro");
       }
       else if(tempo>=10 && tempo < 12)
       {
            Debug.Log("segundo");
            transform.position += new Vector3(-1, 0, 0)* velocidademovimento;
       }
       else if(tempo >= 12 && tempo < 14)
       {
            Debug.Log("terceiro");
            transform.position += new Vector3(1, 0, 0) * velocidademovimento;
       }
       else if(tempo>=20)
       {
            telavitoria.SetActive(true);
        }
    }

    void SpawnBoladefogo()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(inimigo, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
