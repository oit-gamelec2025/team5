using UnityEngine;
using UnityEngine.UI;

public class ChoiceSelector : MonoBehaviour
{
    public Button optionAButton;
    public Button optionBButton;
    public Button optionCButton;

    void Start()
    {
        optionAButton.onClick.AddListener(() => SelectOption("A"));
        optionBButton.onClick.AddListener(() => SelectOption("B"));
        optionCButton.onClick.AddListener(() => SelectOption("C"));
    }

    void SelectOption(string option)
    {
        Debug.Log("選ばれた選択肢: " + option);
        // ここに選択後の処理を書く（シーン遷移、UI更新など）
    }
}