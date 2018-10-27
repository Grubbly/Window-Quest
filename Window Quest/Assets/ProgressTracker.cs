using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour {

    public List<GameObject> windows;
    private List<GameObject> checkWindows;
    public int count = 1;
    public GameObject win;
    bool gameover = false;
    bool notDone = false;


    private void Update()
    {
        if (count % 1000 == 0)
        {
            if (!gameover)
            {
                notDone = false;
                foreach (GameObject window in windows)
                    if (!window.GetComponent<windowControl>().window.activeSelf)
                        notDone = true;
            }

            if (!notDone && !gameover)
            {
                win.SetActive(true);
                gameover = true;
            }
        }
        count++;
    }
}
