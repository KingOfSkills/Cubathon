using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    //STATIC so they are preserved through classes!
    public static string playerName = "";    //Player Name
    public static float playerSpeed = 2000;    //Speed of Cube

    [SerializeField] private InputField nameInputField;   
    [SerializeField] private Slider speedSlider;
    [SerializeField] private Text nameText;
    [SerializeField] private Text speedText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (nameText != null)
        {
            ShowName();
        }
    }

    public void UpdateName()
    {
        playerName = nameInputField.text;
        //nameText.text = playerName;
    }
    public void ShowName()
    {
        nameText.text = playerName;
    }
    public void UpdateSpeed()
    {
        playerSpeed = speedSlider.value;
        speedText.text = playerSpeed.ToString();
    }

    public float GetSpeed() { return playerSpeed; }
}
