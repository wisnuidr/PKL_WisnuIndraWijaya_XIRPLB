using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class update : MonoBehaviour
{
    string URL = "http://localhost/kuis/update.php";
    public string Inputid, Inputnama, Inputscore1, Inputscore2, Inputscore3, Inputscore4, Inputscore5, WhereField, WhereCondition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateUser(Inputid, Inputnama, Inputscore1, Inputscore2, Inputscore3, Inputscore4, Inputscore5, WhereField, WhereCondition);
        }
    }

    public void UpdateUser(string id, string nama, string score1, string score2, string score3, string score4, string score5, string wF, string wC)
    {
        WWWForm form = new WWWForm();
        form.AddField("editid",id);
        form.AddField("editnama",nama);
        form.AddField("editscore1", score1);
        form.AddField("editscore2", score2);
        form.AddField("editscore3", score3);
        form.AddField("editscore4", score4);
        form.AddField("editscore5", score5);

        form.AddField("whereField",wF);
        form.AddField("whereCondition", wC);

        WWW www = new WWW(URL, form);
    }

}
