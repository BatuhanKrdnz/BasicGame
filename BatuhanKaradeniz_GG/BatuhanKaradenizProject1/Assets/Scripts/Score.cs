using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public int i = 0;

    // Update is called once per frame
    void Update()
    {
        
       scoreTxt.text = i.ToString();
        i++;
    }
}
