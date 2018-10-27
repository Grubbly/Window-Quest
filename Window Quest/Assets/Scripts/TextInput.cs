using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour {

    public InputField inputField;
    public int turnInIndex = -1;
    public GameObject bang;
    private GameObject gameMaster;
    public GameObject window;

    /*
    *  plz_read
       plz_run
       plz_run2
       dank_boyz
       red_team
       white_text - flag{nothin_but_white}
       in_image - flag{7h3_m461c_15_1n_7h3_numb3r5}
       hedgehog needs to be admin, then login
       **Recycling bin
       Event viewer
       In game
       **Boo
    */

    private List<string> flags = new List<string> { "flag{p3rm15510n_Gr4n73d}",
                                                    "flag{w0wz4_y0u_5m4r7y}",
                                                    "flag{r1c3_4nd_n00dl35_4r3_my_f4v0r173}",
                                                    "flag{fr35h_l1k3_m3}",
                                                    "flag{red_team_always_wins}",
                                                    "flag{nothin_but_white}",
                                                    "flag{7h3_m461c_15_1n_7h3_numb3r5}",
                                                    "flag{h3d63h06_4dm1n_15_b357_4dm1n}",
                                                    "flag{views_are_great_for_filtering_logs}",
                                                    "flag{easter_egg_hunter}",
                                                    "flag{this_one_is_hard}",
                                                    "flag{5n34ky_P3At}"
                                                  };

    private void Awake()
    {
        inputField.onEndEdit.AddListener(AcceptStringInput);
        gameMaster = GameObject.Find("GameMaster");
    }

    private void AcceptStringInput(string userInput)
    {
        //userInput = userInput.ToLower(); //might be a good idea
        Debug.Log(userInput);
        checkFlag(userInput);
        InputComplete();
    }

    private void InputComplete()
    {
        inputField.ActivateInputField();
        inputField.text = null;
    }

    private void checkFlag(string input)
    {
        if (turnInIndex >= 0) {
            for (int i = 0; i < flags.Count; i++)
                if (input == flags[i] && i == turnInIndex)
                {
                    window.SetActive(true);

                    Debug.Log("Accepted " + input + " as flag " + turnInIndex + " Active " + window.activeSelf);

                    int emergencyCount = 0;
                    while (!window.activeSelf)
                    {
                        window.SetActive(true);

                        if (emergencyCount == 1000)
                            break;

                        emergencyCount++;
                    }

                    if (bang != null)
                        Destroy(bang);
                }
            Debug.Log("End Status for " + input + " Active: " + window.activeSelf);
        } else
        {
            Debug.Log(input + " was not taken by checkFlag" + " index: " + turnInIndex);
        }
    }
}
