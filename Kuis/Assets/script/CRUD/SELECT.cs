using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SELECT : MonoBehaviour
{
    string URL = "http://localhost/kuis/select.php";
    public string[] userData;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW user = new WWW(URL);
        yield return user;
        string userDataString = user.text;
        userData = userDataString.Split(';');

        print(GetValueData(userData[1], "nama:"));
    }

    string GetValueData(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|"))
        {
            value = value.Remove(value.IndexOf("|"));
        }
        return value;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
