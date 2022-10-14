using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class T : MonoBehaviour
{

    public float Tiempo;
    public Fighter player2;

    // Start is called before the first frame update
    void Start()
    {
        Tiempo = 4.5f;
    }

    void Tim()
    {
        if (Tiempo <= 0)
        {
            SceneManager.LoadScene("PlayStreetFighter");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo -= Time.deltaTime;

        if (player2.healtPercent <= 0)
        {
            Tim();
        }
    }
}
