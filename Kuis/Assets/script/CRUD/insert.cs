using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insert : MonoBehaviour
{
    string URL = "http://localhost/kuis/insert.php";
    public string Inputid, Inputnama, Inputscore1, Inputscore2, Inputscore3, Inputscore4, Inputscore5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddUser(Inputid, Inputnama, Inputscore1, Inputscore2, Inputscore3, Inputscore4, Inputscore5);
        }
     
    }

    public void AddUser(string id, string nama, string score1, string score2, string score3, string score4, string score5)
    {
        WWWForm form = new WWWForm();
        form.AddField("addid", id);
        form.AddField("addnama", nama);
        form.AddField("addscore1", score1);
        form.AddField("addscore2", score2);
        form.AddField("addscore3", score3);
        form.AddField("addscore4", score4);
        form.AddField("addscore5", score5);

        WWW www = new WWW(URL, form);
    }

}
