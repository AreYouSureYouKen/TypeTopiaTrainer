using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using System.Security.Cryptography;

public class Learner : MonoBehaviour
{
    private Dictionary<string, int> sumCount;
    private bool isLoggedIn = false;
    public int accountID;
    public Text response;
    public InputField inEmail;
    public InputField inPassword;
	public static string Username;
    public static int previousHighscore;
    // Use this for initialization
    void Start()
    {
        sumCount = new Dictionary<string, int>();

        int plus = PlayerPrefs.GetInt("Plus", 1);
        int minus = PlayerPrefs.GetInt("Minus", 1);
        int multiply = PlayerPrefs.GetInt("Multiply", 1);
        int divide = PlayerPrefs.GetInt("Divide", 1);

        DontDestroyOnLoad(this);
        sumCount.Add("+", plus);
        sumCount.Add("-", minus);
        sumCount.Add("x", multiply);
        sumCount.Add(":", divide);
    }

    // Update is called once per frame
    void Update()
    {
    }

    // voegt een enkele toe bij de aangegeven type som
    public void addSum(string type)
    {
        sumCount[type]++;
    }

    //haalt de meest gebruikte som op, type en aantal keer gemaakt
    public KeyValuePair<string, int> getMostUsed()
    {
        return sumCount.Aggregate((l, r) => l.Value > r.Value ? l : r);
    }

    // haalt de minst gebruikte som op, type en aantal keer gemaakt
    public KeyValuePair<string, int> getLeastUsed()
    {
        return sumCount.Aggregate((l, r) => l.Value < r.Value ? l : r);
    }

    // haalt het totale aantal gemaakte sommen op
    public int getSumCount()
    {
        int count = 0;
        foreach (KeyValuePair<string, int> entry in sumCount)
        {
            count += entry.Value;
        }
        return count;
    }

    /// <summary>
    /// haalt de percentages op van hoeveel de sommen gebruikt worden
    /// </summary>
    /// <returns>
    /// Dict sumtype met percentage</returns>
    public Dictionary<string,float> getPercentagesForUse()
    {
        Dictionary<string, float> dictSt = new Dictionary<string, float>();
        string url = "http://athena.fhict.nl/users/i292193/mathwars/getPercentages.php?accountID=" + accountID;
        WWW www = new WWW(url);
        while (!www.isDone)
        {
        }
        if (www.text != "")
        {
            // extract sorted keys and values
            string[] usages = www.text.Split(';');
            List<string> keys = new List<string>();
            List<float> values = new List<float>();
            keys.Add(usages[0]);
            values.Add(float.Parse(usages[1]));
            keys.Add(usages[2]);
            values.Add(float.Parse(usages[3]));
            keys.Add(usages[4]);
            values.Add(float.Parse(usages[5]));
            keys.Add(usages[6]);
            values.Add(float.Parse(usages[7]));
            //reverse values
            values.Reverse();
            int i = 0;
            // insert in dictionary with keys and reversed value order
            foreach (string key in keys)
            {
                dictSt.Add(key, values[i]);
                i++;
            }   
        }
        return dictSt;
    }

    /// <summary>
    /// slaat de gebruikte som hoeveelheden op
    /// </summary>
    public void saveSumCount()
    {
        if (isLoggedIn)
        {
            string url = "http://athena.fhict.nl/users/i292193/mathwars/updateUsages.php?accountID=" + this.accountID + "&plus=" + sumCount["+"] + "&minus=" + sumCount["-"] + "&multiply=" + sumCount["x"] + "&divide=" + sumCount[":"];
            WWW www = new WWW(url);
        }
        else
        {
            PlayerPrefs.SetInt("Plus", sumCount["+"]);
            PlayerPrefs.SetInt("Minus", sumCount["-"]);
            PlayerPrefs.SetInt("Multiply", sumCount["x"]);
            PlayerPrefs.SetInt("Divide", sumCount[":"]);
            PlayerPrefs.Save();
        }
    }


    public void btnLoginPress()
    {
        this.login(inEmail.text, inPassword.text);
    }

	public void btnGuestPress()
	{
		this.accountID = 0;
		Application.LoadLevel("mainmenu");
	}
	
	public void btnstartPress()
	{
        if (previousHighscore > 0)
        { Application.LoadLevel("generator"); }
        else
        {
            Application.LoadLevel("tutorial");
        }
	}

    /// <summary>
    /// Login in de database om je aantallen op te halen
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns>false op verkeerde login
    /// true op success</returns>
    public bool login(string username, string password)
    {
        try
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder databuild = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    databuild.Append(data[i].ToString("x2"));
                }
                string hashed = databuild.ToString();
                string url = "http://athena.fhict.nl/users/i292193/mathwars/getaccountID.php?username=" + username + "&password=" + hashed;
                WWW www = new WWW(url);
                while (!www.isDone)
                {

                }
                if (www.text != "")
                {
                    string[] wwwresponse = www.text.Split(';');
                    response.text = "login success";
					Username = username;
                    this.accountID = System.Int32.Parse(wwwresponse[0]);
					this.isLoggedIn=true;
                    getUsages(accountID);
                    previousHighscore = System.Int32.Parse(wwwresponse[1]);
                    Application.LoadLevel("mainmenu");
                    return true;
                }
                else
                {

                    response.text = "login failed";
                    return false;
                }

            }
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
            response.text = e.ToString();
            return false;
        }
    }

    //wanneer ingelogd worden hiermee de gebruikte aantallen weer gezet naar die uit de database
    private void getUsages(int accountID)
    {
        try
        {
            string url = "http://athena.fhict.nl/users/i292193/mathwars/getusages.php?accountID=" + accountID;
            WWW www = new WWW(url);
            while (!www.isDone)
            {

            }
            if (www.text != "")
            {
                string[] usages = www.text.Split(';');
                sumCount[usages[0]] = System.Int32.Parse(usages[1]);
                sumCount[usages[2]] = System.Int32.Parse(usages[3]);
                sumCount[usages[4]] = System.Int32.Parse(usages[5]);
                sumCount[usages[6]] = System.Int32.Parse(usages[7]);
            }
        }
        catch (System.Exception e)
        {
            response.text = e.ToString();
        }
    }


    public void btnRegisterPress()
    {
        response.text = this.register(inEmail.text, inPassword.text);
    }

    /// <summary>
    /// gebruikt om te registreren.
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns>
    /// false on error/duplicate
    /// true on success</returns>
    public string register(string username, string password)
    {
		if(username == "" || password == "" || username.Length >= 15)
		{
			return "Niet toegestaan om zonder naam en/of wachtwoord te registreren";
		}
        using (MD5 md5Hash = MD5.Create())
        {
            try
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder databuild = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    databuild.Append(data[i].ToString("x2"));
                }
                string hashed = databuild.ToString();

                string url = "http://athena.fhict.nl/users/i292193/mathwars/checkAvailability.php?username=" + username;
                WWW www = new WWW(url);
                while (!www.isDone)
                {

                }

                if (www.text != "")
                {
                    Debug.Log("duplicate username found");
                    response.text = "duplicate username found";
                    return "duplicate username found";
                }
                url = "http://athena.fhict.nl/users/i292193/mathwars/registerUser.php?username=" + username + "&password=" + hashed;
                www = new WWW(url);
                while (!www.isDone)
                {

                }
                if (www.text == "")
                {
                    return "Succesvol geregistreerd";
                }
                else
                {
                    return www.text;
                }
                
            }
            catch (System.Exception e)
            {
                Debug.Log(e);
                response.text = e.ToString();
                return "duplicate username found";
            }

        }
    }
}
