using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawab : MonoBehaviour
{
    public GameObject feed_benar, feed_salah;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    public void jawaban(bool jawab)
    {   //jika benar
        if (jawab)
        {
            feed_benar.SetActive (false);
            feed_benar.SetActive (true);

            int score = PlayerPrefs.GetInt("score") + 10;
            PlayerPrefs.SetInt("score", score);
        }
        //jika salah
        else
        {
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
        }
        gameObject.SetActive(false);
        transform.parent.GetChild (gameObject.transform.GetSiblingIndex () + 1).gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
