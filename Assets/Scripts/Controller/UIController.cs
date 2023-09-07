using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject CharacterChoicePanel;

    public Sprite Character1;
    public Sprite Character2;

    public Image CharacterImage;

    private RectTransform rectTransform;



    public void OnCharacterChoicePanel()
    {
        CharacterChoicePanel.SetActive(true);
    }

    public void ChangeCharacter1()
    {
        CharacterImage.sprite = Character1;

        rectTransform = CharacterImage.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(160, 160);

        CharacterChoicePanel.SetActive(false);
    }
    public void ChangeCharacter2()
    {
        CharacterImage.sprite = Character2;

        // UI Image�� RectTransform ��������
        rectTransform = CharacterImage.GetComponent<RectTransform>();
        // ���ο� ũ�� ����
        rectTransform.sizeDelta = new Vector2(80, 140);

        CharacterChoicePanel.SetActive(false);
    }
}
